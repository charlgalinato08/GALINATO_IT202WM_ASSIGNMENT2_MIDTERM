
using System;
using System.Windows.Forms;

namespace ProductivityTracker
{
    public class HabitTrackerForm : Form
    {
       
        private Label lblTitle;
        private Label lblHabitName;
        private TextBox txtHabitName;
        private Button btnAddHabit;
        private Button btnMarkDone;
        private Label lblHabits;
        private ListBox lstHabits;
        private Label lblCompleted;
        private ListBox lstCompleted;

        public HabitTrackerForm()
        {
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "✅ Habit Tracker";
            this.Size = new System.Drawing.Size(480, 520);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(30, 30);

            
            lblTitle = new Label();
            lblTitle.Text = "Habit Tracker";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(20, 15);
            lblTitle.Size = new System.Drawing.Size(250, 30);

            
            lblHabitName = new Label();
            lblHabitName.Text = "Habit Name:";
            lblHabitName.Location = new System.Drawing.Point(20, 60);
            lblHabitName.Size = new System.Drawing.Size(100, 23);

            txtHabitName = new TextBox();
            txtHabitName.Location = new System.Drawing.Point(130, 57);
            txtHabitName.Size = new System.Drawing.Size(300, 23);
            txtHabitName.ForeColor = System.Drawing.Color.Gray;
            txtHabitName.Text = "e.g. Drink 8 glasses of water";
            txtHabitName.GotFocus += (s, ev) =>
            {
                if (txtHabitName.Text == "e.g. Drink 8 glasses of water")
                {
                    txtHabitName.Text = "";
                    txtHabitName.ForeColor = System.Drawing.Color.Black;
                }
            };
            txtHabitName.LostFocus += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtHabitName.Text))
                {
                    txtHabitName.Text = "e.g. Drink 8 glasses of water";
                    txtHabitName.ForeColor = System.Drawing.Color.Gray;
                }
            };

           
            btnAddHabit = new Button();
            btnAddHabit.Text = "Add Habit";
            btnAddHabit.Location = new System.Drawing.Point(130, 95);
            btnAddHabit.Size = new System.Drawing.Size(110, 30);
            btnAddHabit.BackColor = System.Drawing.Color.SeaGreen;
            btnAddHabit.ForeColor = System.Drawing.Color.White;
            btnAddHabit.FlatStyle = FlatStyle.Flat;
            btnAddHabit.Click += new EventHandler(btnAddHabit_Click);

            btnMarkDone = new Button();
            btnMarkDone.Text = "✔ Mark as Done";
            btnMarkDone.Location = new System.Drawing.Point(255, 95);
            btnMarkDone.Size = new System.Drawing.Size(130, 30);
            btnMarkDone.BackColor = System.Drawing.Color.DarkOrange;
            btnMarkDone.ForeColor = System.Drawing.Color.White;
            btnMarkDone.FlatStyle = FlatStyle.Flat;
            btnMarkDone.Click += new EventHandler(btnMarkDone_Click);

           
            lblHabits = new Label();
            lblHabits.Text = "Habits To Do:";
            lblHabits.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            lblHabits.Location = new System.Drawing.Point(20, 145);
            lblHabits.Size = new System.Drawing.Size(200, 23);

            lstHabits = new ListBox();
            lstHabits.Location = new System.Drawing.Point(20, 170);
            lstHabits.Size = new System.Drawing.Size(420, 130);
            lstHabits.Font = new System.Drawing.Font("Segoe UI", 10);

            
            lblCompleted = new Label();
            lblCompleted.Text = "✅ Completed Habits:";
            lblCompleted.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            lblCompleted.ForeColor = System.Drawing.Color.SeaGreen;
            lblCompleted.Location = new System.Drawing.Point(20, 315);
            lblCompleted.Size = new System.Drawing.Size(250, 23);

            lstCompleted = new ListBox();
            lstCompleted.Location = new System.Drawing.Point(20, 340);
            lstCompleted.Size = new System.Drawing.Size(420, 130);
            lstCompleted.Font = new System.Drawing.Font("Segoe UI", 10);
            lstCompleted.ForeColor = System.Drawing.Color.SeaGreen;

            
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblHabitName);
            this.Controls.Add(txtHabitName);
            this.Controls.Add(btnAddHabit);
            this.Controls.Add(btnMarkDone);
            this.Controls.Add(lblHabits);
            this.Controls.Add(lstHabits);
            this.Controls.Add(lblCompleted);
            this.Controls.Add(lstCompleted);
        }

        
        private void btnAddHabit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHabitName.Text))
                {
                    MessageBox.Show("Please enter a habit name!", "Empty Field",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHabitName.Focus();
                    return;
                }

                lstHabits.Items.Add(txtHabitName.Text.Trim());
                txtHabitName.Clear();
                txtHabitName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void btnMarkDone_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (lstHabits.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a habit to mark as done!", "No Selection",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                string habit = lstHabits.SelectedItem.ToString();
                lstCompleted.Items.Add("✔ " + habit);
                lstHabits.Items.RemoveAt(lstHabits.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
