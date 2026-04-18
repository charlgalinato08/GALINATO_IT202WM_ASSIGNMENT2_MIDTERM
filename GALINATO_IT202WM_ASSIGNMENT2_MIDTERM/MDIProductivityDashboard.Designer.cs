// ============================================================
// MDIProductivityDashboard.Designer.cs  —  AUTO-GENERATED UI
// This sets up all the visual controls for the main window.
// ============================================================
namespace ProductivityTracker
{
    partial class MDIProductivityDashboard
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDailyPlanner;
        private System.Windows.Forms.ToolStripMenuItem menuHabitTracker;
        private System.Windows.Forms.ToolStripMenuItem menuNotes;
        private System.Windows.Forms.ToolStripMenuItem menuFocusTimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCascade;
        private System.Windows.Forms.ToolStripMenuItem menuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuTileVertical;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBtnPlanner;
        private System.Windows.Forms.ToolStripButton toolBtnHabit;
        private System.Windows.Forms.ToolStripButton toolBtnNotes;
        private System.Windows.Forms.ToolStripButton toolBtnTimer;
        private System.Windows.Forms.ToolStripButton toolBtnAbout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDailyPlanner = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHabitTracker = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFocusTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtnPlanner = new System.Windows.Forms.ToolStripButton();
            this.toolBtnHabit = new System.Windows.Forms.ToolStripButton();
            this.toolBtnNotes = new System.Windows.Forms.ToolStripButton();
            this.toolBtnTimer = new System.Windows.Forms.ToolStripButton();
            this.toolBtnAbout = new System.Windows.Forms.ToolStripButton();

            // ── MenuStrip ──────────────────────────────────────────────────
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.dashboardToolStripMenuItem,
                this.windowToolStripMenuItem,
                this.helpToolStripMenuItem
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);

            // ── Dashboard Menu ─────────────────────────────────────────────
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuDailyPlanner,
                this.menuHabitTracker,
                this.menuNotes,
                this.menuFocusTimer,
                this.toolStripSeparator1,
                this.menuExit
            });
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Text = "Dashboard";

            this.menuDailyPlanner.Name = "menuDailyPlanner";
            this.menuDailyPlanner.Text = "📅 Daily Planner";
            this.menuDailyPlanner.Click += new System.EventHandler(this.menuDailyPlanner_Click);

            this.menuHabitTracker.Name = "menuHabitTracker";
            this.menuHabitTracker.Text = "✅ Habit Tracker";
            this.menuHabitTracker.Click += new System.EventHandler(this.menuHabitTracker_Click);

            this.menuNotes.Name = "menuNotes";
            this.menuNotes.Text = "📝 Notes / Journal";
            this.menuNotes.Click += new System.EventHandler(this.menuNotes_Click);

            this.menuFocusTimer.Name = "menuFocusTimer";
            this.menuFocusTimer.Text = "⏱ Focus Timer";
            this.menuFocusTimer.Click += new System.EventHandler(this.menuFocusTimer_Click);

            this.menuExit.Name = "menuExit";
            this.menuExit.Text = "❌ Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);

            // ── Window Menu ────────────────────────────────────────────────
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuCascade,
                this.menuTileHorizontal,
                this.menuTileVertical
            });
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Text = "Window";

            this.menuCascade.Name = "menuCascade";
            this.menuCascade.Text = "Cascade";
            this.menuCascade.Click += new System.EventHandler(this.menuCascade_Click);

            this.menuTileHorizontal.Name = "menuTileHorizontal";
            this.menuTileHorizontal.Text = "Tile Horizontal";
            this.menuTileHorizontal.Click += new System.EventHandler(this.menuTileHorizontal_Click);

            this.menuTileVertical.Name = "menuTileVertical";
            this.menuTileVertical.Text = "Tile Vertical";
            this.menuTileVertical.Click += new System.EventHandler(this.menuTileVertical_Click);

            // ── Help Menu ──────────────────────────────────────────────────
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuAbout
            });
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Text = "Help";

            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);

            // ── ToolStrip ──────────────────────────────────────────────────
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolBtnPlanner,
                this.toolBtnHabit,
                this.toolBtnNotes,
                this.toolBtnTimer,
                this.toolBtnAbout
            });
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";

            this.toolBtnPlanner.Text = "📅 Planner";
            this.toolBtnPlanner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnPlanner.Click += new System.EventHandler(this.toolBtnPlanner_Click);

            this.toolBtnHabit.Text = "✅ Habits";
            this.toolBtnHabit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnHabit.Click += new System.EventHandler(this.toolBtnHabit_Click);

            this.toolBtnNotes.Text = "📝 Notes";
            this.toolBtnNotes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnNotes.Click += new System.EventHandler(this.toolBtnNotes_Click);

            this.toolBtnTimer.Text = "⏱ Timer";
            this.toolBtnTimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnTimer.Click += new System.EventHandler(this.toolBtnTimer_Click);

            this.toolBtnAbout.Text = "ℹ About";
            this.toolBtnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnAbout.Click += new System.EventHandler(this.toolBtnAbout_Click);

            // ── Main Form ──────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;           // ← THIS MAKES IT AN MDI PARENT
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIProductivityDashboard";
            this.Text = "🧠 Productivity & Habit Tracker MDI System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
