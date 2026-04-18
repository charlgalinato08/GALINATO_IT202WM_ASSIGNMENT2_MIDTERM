// ============================================================
// MDIProductivityDashboard.cs  —  MAIN PARENT FORM (MDI)
// This is the main window. All other forms open inside it.
// ============================================================
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

        // ── Helper: open a child form, prevent duplicates ──────────────────
        private void OpenChildForm(Form childForm)
        {
            // Check if this form is already open
            foreach (Form openForm in this.MdiChildren)
            {
                if (openForm.GetType() == childForm.GetType())
                {
                    openForm.Activate(); // Just bring it to the front
                    childForm.Dispose();
                    return;
                }
            }

            // Set the parent and show
            childForm.MdiParent = this;
            childForm.Show();
        }

        // ── Menu: Dashboard → Daily Planner ───────────────────────────────
        private void menuDailyPlanner_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DailyPlannerForm());
        }

        // ── Menu: Dashboard → Habit Tracker ───────────────────────────────
        private void menuHabitTracker_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HabitTrackerForm());
        }

        // ── Menu: Dashboard → Notes ────────────────────────────────────────
        private void menuNotes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NotesJournalForm());
        }

        // ── Menu: Dashboard → Focus Timer ─────────────────────────────────
        private void menuFocusTimer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FocusTimerForm());
        }

        // ── Menu: Dashboard → Exit ─────────────────────────────────────────
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

        // ── Menu: Window → Cascade ─────────────────────────────────────────
        private void menuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        // ── Menu: Window → Tile Horizontal ────────────────────────────────
        private void menuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        // ── Menu: Window → Tile Vertical ──────────────────────────────────
        private void menuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        // ── Menu: Help → About ─────────────────────────────────────────────
        private void menuAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AboutForm());
        }

        // ── ToolStrip Buttons (same as menu items) ─────────────────────────
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
