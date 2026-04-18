// ============================================================
// FocusTimerForm.cs  —  CHILD FORM D: Focus Timer
// User enters minutes, clicks Start to begin a countdown.
// The timer ticks every second. Stop button pauses it.
// ============================================================
using System;
using System.Windows.Forms;

namespace ProductivityTracker
{
    public class FocusTimerForm : Form
    {
        // ── Controls ──────────────────────────────────────────────────────
        private Label lblTitle;
        private Label lblMinutes;
        private TextBox txtMinutes;
        private Button btnStart;
        private Button btnStop;
        private Label lblCountdown;      // The big countdown display
        private Label lblStatus;

        // ── Timer (built-in Windows Forms timer) ──────────────────────────
        private Timer countdownTimer;
        private int remainingSeconds = 0; // How many seconds are left

        public FocusTimerForm()
        {
            SetupForm();
            SetupTimer();
        }

        private void SetupForm()
        {
            this.Text = "⏱ Focus Timer";
            this.Size = new System.Drawing.Size(380, 380);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(70, 70);

            // ── Title ──────────────────────────────────────────────────────
            lblTitle = new Label();
            lblTitle.Text = "Focus Timer";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(20, 15);
            lblTitle.Size = new System.Drawing.Size(200, 30);

            // ── Minutes input ──────────────────────────────────────────────
            lblMinutes = new Label();
            lblMinutes.Text = "Minutes:";
            lblMinutes.Location = new System.Drawing.Point(20, 60);
            lblMinutes.Size = new System.Drawing.Size(80, 23);

            txtMinutes = new TextBox();
            txtMinutes.Location = new System.Drawing.Point(110, 57);
            txtMinutes.Size = new System.Drawing.Size(80, 23);
            txtMinutes.MaxLength = 3; // Max 999 minutes

            // ── Big countdown label ────────────────────────────────────────
            lblCountdown = new Label();
            lblCountdown.Text = "00:00";
            lblCountdown.Font = new System.Drawing.Font("Segoe UI", 48, System.Drawing.FontStyle.Bold);
            lblCountdown.ForeColor = System.Drawing.Color.SteelBlue;
            lblCountdown.Location = new System.Drawing.Point(60, 100);
            lblCountdown.Size = new System.Drawing.Size(260, 100);
            lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── Buttons ────────────────────────────────────────────────────
            btnStart = new Button();
            btnStart.Text = "▶ Start";
            btnStart.Location = new System.Drawing.Point(70, 220);
            btnStart.Size = new System.Drawing.Size(110, 40);
            btnStart.BackColor = System.Drawing.Color.SeaGreen;
            btnStart.ForeColor = System.Drawing.Color.White;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new System.Drawing.Font("Segoe UI", 11);
            btnStart.Click += new EventHandler(btnStart_Click);

            btnStop = new Button();
            btnStop.Text = "⏹ Stop";
            btnStop.Location = new System.Drawing.Point(200, 220);
            btnStop.Size = new System.Drawing.Size(110, 40);
            btnStop.BackColor = System.Drawing.Color.IndianRed;
            btnStop.ForeColor = System.Drawing.Color.White;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new System.Drawing.Font("Segoe UI", 11);
            btnStop.Enabled = false; // Disabled until timer starts
            btnStop.Click += new EventHandler(btnStop_Click);

            // ── Status label ───────────────────────────────────────────────
            lblStatus = new Label();
            lblStatus.Text = "Enter minutes and press Start.";
            lblStatus.Location = new System.Drawing.Point(20, 280);
            lblStatus.Size = new System.Drawing.Size(340, 30);
            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblStatus.ForeColor = System.Drawing.Color.Gray;

            // ── Add to form ────────────────────────────────────────────────
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblMinutes);
            this.Controls.Add(txtMinutes);
            this.Controls.Add(lblCountdown);
            this.Controls.Add(btnStart);
            this.Controls.Add(btnStop);
            this.Controls.Add(lblStatus);
        }

        // ── Setup the Timer component ──────────────────────────────────────
        private void SetupTimer()
        {
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1000 ms = 1 second
            countdownTimer.Tick += new EventHandler(countdownTimer_Tick);
        }

        // ── Start button ───────────────────────────────────────────────────
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate: must not be empty
                if (string.IsNullOrWhiteSpace(txtMinutes.Text))
                {
                    MessageBox.Show("Please enter the number of minutes!", "Empty Field",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMinutes.Focus();
                    return;
                }

                // Validate: must be a number
                if (!int.TryParse(txtMinutes.Text, out int minutes))
                {
                    MessageBox.Show("Please enter a valid number!", "Invalid Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMinutes.Focus();
                    return;
                }

                // Validate: must be positive
                if (minutes <= 0)
                {
                    MessageBox.Show("Please enter a number greater than 0!", "Invalid Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convert minutes to seconds and start
                remainingSeconds = minutes * 60;
                UpdateCountdownDisplay();

                countdownTimer.Start();
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                txtMinutes.Enabled = false;
                lblStatus.Text = "⏱ Timer is running...";
                lblStatus.ForeColor = System.Drawing.Color.SeaGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Stop button ────────────────────────────────────────────────────
        private void btnStop_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            txtMinutes.Enabled = true;
            lblStatus.Text = "⏹ Timer stopped.";
            lblStatus.ForeColor = System.Drawing.Color.IndianRed;
        }

        // ── Timer Tick (runs every 1 second) ──────────────────────────────
        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            remainingSeconds--; // Subtract 1 second

            if (remainingSeconds <= 0)
            {
                // Time is up!
                remainingSeconds = 0;
                UpdateCountdownDisplay();
                countdownTimer.Stop();

                btnStart.Enabled = true;
                btnStop.Enabled = false;
                txtMinutes.Enabled = true;
                lblStatus.Text = "🎉 Time's up!";
                lblStatus.ForeColor = System.Drawing.Color.DarkOrange;

                MessageBox.Show("🎉 Focus session complete! Great job!", "Time's Up!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UpdateCountdownDisplay();
            }
        }

        // ── Update the countdown display (MM:SS format) ────────────────────
        private void UpdateCountdownDisplay()
        {
            int minutes = remainingSeconds / 60;
            int seconds = remainingSeconds % 60;
            lblCountdown.Text = $"{minutes:D2}:{seconds:D2}"; // e.g. 04:35
        }

        // ── Stop the timer when the form is closed ─────────────────────────
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            countdownTimer.Stop();
            countdownTimer.Dispose();
            base.OnFormClosing(e);
        }
    }
}
