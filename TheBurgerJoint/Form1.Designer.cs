namespace TheBurgerJoint
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.WelcomePnl = new System.Windows.Forms.Panel();
            this.WelcomeTblPnl = new System.Windows.Forms.TableLayoutPanel();
            this.WelcomeToLbl = new System.Windows.Forms.Label();
            this.WelcomeTitleLbl = new System.Windows.Forms.Label();
            this.WelcomeBeginLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.WelcomePnl.SuspendLayout();
            this.WelcomeTblPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomePnl
            // 
            this.WelcomePnl.AutoSize = true;
            this.WelcomePnl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.WelcomePnl.Controls.Add(this.WelcomeTblPnl);
            this.WelcomePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WelcomePnl.Location = new System.Drawing.Point(2, 2);
            this.WelcomePnl.Name = "WelcomePnl";
            this.WelcomePnl.Size = new System.Drawing.Size(780, 557);
            this.WelcomePnl.TabIndex = 0;
            // 
            // WelcomeTblPnl
            // 
            this.WelcomeTblPnl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.WelcomeTblPnl.ColumnCount = 3;
            this.WelcomeTblPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.WelcomeTblPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.WelcomeTblPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.WelcomeTblPnl.Controls.Add(this.WelcomeToLbl, 1, 1);
            this.WelcomeTblPnl.Controls.Add(this.WelcomeTitleLbl, 1, 2);
            this.WelcomeTblPnl.Controls.Add(this.WelcomeBeginLbl, 1, 3);
            this.WelcomeTblPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WelcomeTblPnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeTblPnl.Location = new System.Drawing.Point(0, 0);
            this.WelcomeTblPnl.Name = "WelcomeTblPnl";
            this.WelcomeTblPnl.RowCount = 4;
            this.WelcomeTblPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.WelcomeTblPnl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.WelcomeTblPnl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.WelcomeTblPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.WelcomeTblPnl.Size = new System.Drawing.Size(780, 557);
            this.WelcomeTblPnl.TabIndex = 2;
            this.WelcomeTblPnl.Click += new System.EventHandler(this.BeginOrder_Click);
            // 
            // WelcomeToLbl
            // 
            this.WelcomeToLbl.AutoSize = true;
            this.WelcomeToLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WelcomeToLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WelcomeToLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WelcomeToLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeToLbl.Location = new System.Drawing.Point(93, 206);
            this.WelcomeToLbl.Name = "WelcomeToLbl";
            this.WelcomeToLbl.Size = new System.Drawing.Size(594, 69);
            this.WelcomeToLbl.TabIndex = 1;
            this.WelcomeToLbl.Text = "Welcome to";
            this.WelcomeToLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeToLbl.Click += new System.EventHandler(this.BeginOrder_Click);
            // 
            // WelcomeTitleLbl
            // 
            this.WelcomeTitleLbl.AutoSize = true;
            this.WelcomeTitleLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WelcomeTitleLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WelcomeTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeTitleLbl.ForeColor = System.Drawing.Color.Chocolate;
            this.WelcomeTitleLbl.Location = new System.Drawing.Point(93, 275);
            this.WelcomeTitleLbl.Name = "WelcomeTitleLbl";
            this.WelcomeTitleLbl.Size = new System.Drawing.Size(594, 76);
            this.WelcomeTitleLbl.TabIndex = 2;
            this.WelcomeTitleLbl.Text = "The Burger Joint";
            this.WelcomeTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeTitleLbl.Click += new System.EventHandler(this.BeginOrder_Click);
            // 
            // WelcomeBeginLbl
            // 
            this.WelcomeBeginLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WelcomeBeginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBeginLbl.Location = new System.Drawing.Point(93, 351);
            this.WelcomeBeginLbl.Name = "WelcomeBeginLbl";
            this.WelcomeBeginLbl.Size = new System.Drawing.Size(594, 206);
            this.WelcomeBeginLbl.TabIndex = 0;
            this.WelcomeBeginLbl.Text = "Touch Screen to Begin";
            this.WelcomeBeginLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WelcomeBeginLbl.Click += new System.EventHandler(this.BeginOrder_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.TickEvent);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.WelcomePnl);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Buffalo Burgers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.WelcomePnl.ResumeLayout(false);
            this.WelcomeTblPnl.ResumeLayout(false);
            this.WelcomeTblPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel WelcomePnl;
        private System.Windows.Forms.Label WelcomeToLbl;
        private System.Windows.Forms.TableLayoutPanel WelcomeTblPnl;
        private System.Windows.Forms.Label WelcomeTitleLbl;
        private System.Windows.Forms.Label WelcomeBeginLbl;
        private System.Windows.Forms.Timer timer1;
    }
}

