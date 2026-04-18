// ============================================================
// AboutForm.cs  —  CHILD FORM E: About
// Shows system description, developer name, and version.
// ============================================================
using System;
using System.Windows.Forms;

namespace ProductivityTracker
{
    public class AboutForm : Form
    {
        public AboutForm()
        {
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "ℹ About";
            this.Size = new System.Drawing.Size(420, 340);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Fixed size
            this.MaximizeBox = false;

            // ── App Icon / Title ───────────────────────────────────────────
            Label lblAppName = new Label();
            lblAppName.Text = "🧠 Productivity & Habit Tracker";
            lblAppName.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            lblAppName.Location = new System.Drawing.Point(20, 20);
            lblAppName.Size = new System.Drawing.Size(380, 35);
            lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── Divider line ───────────────────────────────────────────────
            Label divider = new Label();
            divider.BorderStyle = BorderStyle.Fixed3D;
            divider.Location = new System.Drawing.Point(20, 60);
            divider.Size = new System.Drawing.Size(360, 2);

            // ── Description ────────────────────────────────────────────────
            Label lblDesc = new Label();
            lblDesc.Text =
                "This is an MDI (Multiple Document Interface) application\n" +
                "built with C# Windows Forms .NET.\n\n" +
                "It helps users track daily tasks, habits, notes,\n" +
                "and focus sessions — all inside one window.";
            lblDesc.Font = new System.Drawing.Font("Segoe UI", 10);
            lblDesc.Location = new System.Drawing.Point(20, 75);
            lblDesc.Size = new System.Drawing.Size(370, 120);
            lblDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // ── Developer ──────────────────────────────────────────────────
            Label lblDev = new Label();
            lblDev.Text = " Developer: [Charl Galinato]";
            lblDev.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            lblDev.Location = new System.Drawing.Point(20, 200);
            lblDev.Size = new System.Drawing.Size(370, 25);
            lblDev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── Version ────────────────────────────────────────────────────
            Label lblVersion = new Label();
            lblVersion.Text = "📌 Version: 1.0.0";
            lblVersion.Font = new System.Drawing.Font("Segoe UI", 10);
            lblVersion.ForeColor = System.Drawing.Color.Gray;
            lblVersion.Location = new System.Drawing.Point(20, 230);
            lblVersion.Size = new System.Drawing.Size(370, 25);
            lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── Course ─────────────────────────────────────────────────────
            Label lblCourse = new Label();
            lblCourse.Text = "ICTN05C – Integrative Programming and Technologies\nLyceum of the Philippines – Cavite";
            lblCourse.Font = new System.Drawing.Font("Segoe UI", 9);
            lblCourse.ForeColor = System.Drawing.Color.Gray;
            lblCourse.Location = new System.Drawing.Point(20, 260);
            lblCourse.Size = new System.Drawing.Size(370, 40);
            lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── Close button ───────────────────────────────────────────────
            Button btnClose = new Button();
            btnClose.Text = "Close";
            btnClose.Location = new System.Drawing.Point(155, 265);
            btnClose.Size = new System.Drawing.Size(90, 30);
            btnClose.BackColor = System.Drawing.Color.SteelBlue;
            btnClose.ForeColor = System.Drawing.Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Click += (sender, e) => this.Close();

            // ── Add to form ────────────────────────────────────────────────
            this.Controls.Add(lblAppName);
            this.Controls.Add(divider);
            this.Controls.Add(lblDesc);
            this.Controls.Add(lblDev);
            this.Controls.Add(lblVersion);
            this.Controls.Add(lblCourse);
            this.Controls.Add(btnClose);
        }
    }
}
