
using System;
using System.Windows.Forms;

namespace ProductivityTracker
{
    public partial class MDIProductivityDashboard : Form
    {
        public MDIProductivityDashboard()
        {
            InitializeComponent();
        }

       
        private void OpenChildForm(Form childForm)
        {
            
            foreach (Form openForm in this.MdiChildren)
            {
                if (openForm.GetType() == childForm.GetType())
                {
                    openForm.Activate(); // Just bring it to the front
                    childForm.Dispose();
                    return;
                }
            }

            
            childForm.MdiParent = this;
            childForm.Show();
        }

        
        private void menuDailyPlanner_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DailyPlannerForm());
        }

        
        private void menuHabitTracker_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HabitTrackerForm());
        }

       
        private void menuNotes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NotesJournalForm());
        }

        
        private void menuFocusTimer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FocusTimerForm());
        }

       
        private void menuExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        
        private void menuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        
        private void menuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

       
        private void menuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        
        private void menuAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AboutForm());
        }

       
        private void toolBtnPlanner_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DailyPlannerForm());
        }

        private void toolBtnHabit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HabitTrackerForm());
        }

        private void toolBtnNotes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NotesJournalForm());
        }

        private void toolBtnTimer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FocusTimerForm());
        }

        private void toolBtnAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AboutForm());
        }
    }
}
