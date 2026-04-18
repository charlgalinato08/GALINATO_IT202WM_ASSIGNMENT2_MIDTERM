// ============================================================
// DailyPlannerForm.cs  —  CHILD FORM A: Daily Planner
// Users can add tasks with a priority level and view them
// in a list. They can also clear all tasks.
// ============================================================
using System;
using System.Windows.Forms;

namespace ProductivityTracker
{
    public class DailyPlannerForm : Form
    {
        // ── Controls ──────────────────────────────────────────────────────
        private Label lblTitle;
        private Label lblTaskName;
        private TextBox txtTaskName;
        private Label lblPriority;
        private ComboBox cboPriority;
        private Button btnAddTask;
        private Button btnClear;
        private ListBox lstTasks;
        private Label lblTaskList;

        public DailyPlannerForm()
        {
            SetupForm();
        }

        private void SetupForm()
        {
            // ── Form settings ──────────────────────────────────────────────
            this.Text = "📅 Daily Planner";
            this.Size = new System.Drawing.Size(450, 500);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(10, 10);

            // ── Title label ───────────────────────────────────────────────
            lblTitle = new Label();
            lblTitle.Text = "Daily Planner";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(20, 15);
            lblTitle.Size = new System.Drawing.Size(200, 30);

            // ── Task Name label and textbox ────────────────────────────────
            lblTaskName = new Label();
            lblTaskName.Text = "Task Name:";
            lblTaskName.Location = new System.Drawing.Point(20, 60);
            lblTaskName.Size = new System.Drawing.Size(100, 23);

            txtTaskName = new TextBox();
            txtTaskName.Location = new System.Drawing.Point(130, 57);
            txtTaskName.Size = new System.Drawing.Size(280, 23);
            txtTaskName.ForeColor = System.Drawing.Color.Gray;
            txtTaskName.Text = "Enter task name...";
            txtTaskName.GotFocus += (s, e) =>
            {
                if (txtTaskName.Text == "Enter task name...")
                {
                    txtTaskName.Text = "";
                    txtTaskName.ForeColor = System.Drawing.Color.Black;
                }
            };
            txtTaskName.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtTaskName.Text))
                {
                    txtTaskName.Text = "Enter task name...";
                    txtTaskName.ForeColor = System.Drawing.Color.Gray;
                }
            };

            // ── Priority label and combobox ───────────────────────────────
            lblPriority = new Label();
            lblPriority.Text = "Priority:";
            lblPriority.Location = new System.Drawing.Point(20, 100);
            lblPriority.Size = new System.Drawing.Size(100, 23);

            cboPriority = new ComboBox();
            cboPriority.Location = new System.Drawing.Point(130, 97);
            cboPriority.Size = new System.Drawing.Size(150, 23);
            cboPriority.DropDownStyle = ComboBoxStyle.DropDownList; // No typing, only select
            cboPriority.Items.Add("🔴 High");
            cboPriority.Items.Add("🟡 Medium");
            cboPriority.Items.Add("🟢 Low");
            cboPriority.SelectedIndex = 1; // Default: Medium

            // ── Buttons ────────────────────────────────────────────────────
            btnAddTask = new Button();
            btnAddTask.Text = "Add Task";
            btnAddTask.Location = new System.Drawing.Point(130, 140);
            btnAddTask.Size = new System.Drawing.Size(100, 30);
            btnAddTask.BackColor = System.Drawing.Color.SteelBlue;
            btnAddTask.ForeColor = System.Drawing.Color.White;
            btnAddTask.FlatStyle = FlatStyle.Flat;
            btnAddTask.Click += new EventHandler(btnAddTask_Click);

            btnClear = new Button();
            btnClear.Text = "Clear All";
            btnClear.Location = new System.Drawing.Point(245, 140);
            btnClear.Size = new System.Drawing.Size(100, 30);
            btnClear.BackColor = System.Drawing.Color.IndianRed;
            btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Click += new EventHandler(btnClear_Click);

            // ── Task list ──────────────────────────────────────────────────
            lblTaskList = new Label();
            lblTaskList.Text = "Task List:";
            lblTaskList.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            lblTaskList.Location = new System.Drawing.Point(20, 190);
            lblTaskList.Size = new System.Drawing.Size(200, 23);

            lstTasks = new ListBox();
            lstTasks.Location = new System.Drawing.Point(20, 220);
            lstTasks.Size = new System.Drawing.Size(390, 220);
            lstTasks.Font = new System.Drawing.Font("Segoe UI", 10);

            // ── Add controls to form ───────────────────────────────────────
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblTaskName);
            this.Controls.Add(txtTaskName);
            this.Controls.Add(lblPriority);
            this.Controls.Add(cboPriority);
            this.Controls.Add(btnAddTask);
            this.Controls.Add(btnClear);
            this.Controls.Add(lblTaskList);
            this.Controls.Add(lstTasks);
        }

        // ── Add Task button clicked ────────────────────────────────────────
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation: task name must not be empty
                if (string.IsNullOrWhiteSpace(txtTaskName.Text))
                {
                    MessageBox.Show("Please enter a task name!", "Empty Field",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTaskName.Focus();
                    return;
                }

                // Build the task string and add to list
                string priority = cboPriority.SelectedItem.ToString();
                string task = $"{priority}  |  {txtTaskName.Text.Trim()}";
                lstTasks.Items.Add(task);

                // Clear the textbox after adding
                txtTaskName.Clear();
                txtTaskName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Clear All button clicked ───────────────────────────────────────
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lstTasks.Items.Count == 0)
            {
                MessageBox.Show("The list is already empty!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to clear all tasks?",
                "Clear Tasks",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                lstTasks.Items.Clear();
        }
    }
}
