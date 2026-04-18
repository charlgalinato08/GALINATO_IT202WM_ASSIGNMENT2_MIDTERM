// ============================================================
// NotesJournalForm.cs  —  CHILD FORM C: Notes / Journal
// A simple notepad where users can write and save notes.
// Notes are saved to a .txt file on the desktop.
// ============================================================
using System;
using System.IO;
using System.Windows.Forms;

namespace ProductivityTracker
{
    public class NotesJournalForm : Form
    {
        // ── Controls ──────────────────────────────────────────────────────
        private Label lblTitle;
        private TextBox txtNotes;
        private Button btnSave;
        private Button btnClear;
        private Label lblStatus;

        public NotesJournalForm()
        {
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "📝 Notes / Journal";
            this.Size = new System.Drawing.Size(500, 480);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(50, 50);

            // ── Title ──────────────────────────────────────────────────────
            lblTitle = new Label();
            lblTitle.Text = "Notes / Journal";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(20, 15);
            lblTitle.Size = new System.Drawing.Size(300, 30);

            // ── Multi-line text box ────────────────────────────────────────
            txtNotes = new TextBox();
            txtNotes.Location = new System.Drawing.Point(20, 55);
            txtNotes.Size = new System.Drawing.Size(440, 320);
            txtNotes.Multiline = true;          // Allow multiple lines
            txtNotes.ScrollBars = ScrollBars.Vertical; // Scroll when text is long
            txtNotes.Font = new System.Drawing.Font("Segoe UI", 11);
            txtNotes.Text = "Write your notes or journal entry here...";
            txtNotes.GotFocus += (s, e) =>
            {
                if (txtNotes.Text == "Write your notes or journal entry here...")
                {
                    txtNotes.Text = "";
                }
            };
            txtNotes.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtNotes.Text))
                {
                    txtNotes.Text = "Write your notes or journal entry here...";
                }
            };

            // ── Buttons ────────────────────────────────────────────────────
            btnSave = new Button();
            btnSave.Text = "💾 Save Note";
            btnSave.Location = new System.Drawing.Point(20, 390);
            btnSave.Size = new System.Drawing.Size(130, 35);
            btnSave.BackColor = System.Drawing.Color.SteelBlue;
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Click += new EventHandler(btnSave_Click);

            btnClear = new Button();
            btnClear.Text = "🗑 Clear";
            btnClear.Location = new System.Drawing.Point(165, 390);
            btnClear.Size = new System.Drawing.Size(100, 35);
            btnClear.BackColor = System.Drawing.Color.IndianRed;
            btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Click += new EventHandler(btnClear_Click);

            // ── Status label (shows save confirmation) ─────────────────────
            lblStatus = new Label();
            lblStatus.Text = "";
            lblStatus.Location = new System.Drawing.Point(280, 398);
            lblStatus.Size = new System.Drawing.Size(200, 23);
            lblStatus.ForeColor = System.Drawing.Color.SeaGreen;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Italic);

            // ── Add to form ────────────────────────────────────────────────
            this.Controls.Add(lblTitle);
            this.Controls.Add(txtNotes);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnClear);
            this.Controls.Add(lblStatus);
        }

        // ── Save Note button ───────────────────────────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNotes.Text))
                {
                    MessageBox.Show("Please write something before saving!", "Empty Note",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Save to desktop as MyNotes.txt
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "MyNotes.txt");

                // Append the note with a timestamp
                string entry = $"\n--- {DateTime.Now} ---\n{txtNotes.Text.Trim()}\n";
                File.AppendAllText(filePath, entry);

                lblStatus.Text = "✔ Note saved to Desktop!";
                MessageBox.Show("Note saved successfully to your Desktop as 'MyNotes.txt'!",
                    "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving note: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Clear button ───────────────────────────────────────────────────
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNotes.Text))
            {
                MessageBox.Show("The note is already empty!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to clear the note?",
                "Clear Note",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtNotes.Clear();
                lblStatus.Text = "";
            }
        }
    }
}
