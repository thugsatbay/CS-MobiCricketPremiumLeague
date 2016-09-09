namespace MobiCricketPremiumLeague
{
    partial class MobiCriLeague
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
            this.rootPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginBidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editManagersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.rootPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootPanel
            // 
            this.rootPanel.Controls.Add(this.mainPanel);
            this.rootPanel.Controls.Add(this.menuStrip1);
            this.rootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootPanel.Location = new System.Drawing.Point(0, 0);
            this.rootPanel.Name = "rootPanel";
            this.rootPanel.Size = new System.Drawing.Size(1350, 687);
            this.rootPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1350, 663);
            this.mainPanel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.tossToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPlayersToolStripMenuItem,
            this.enterPlayersToolStripMenuItem,
            this.toolStripSeparator1,
            this.editManagersToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // enterPlayersToolStripMenuItem
            // 
            this.enterPlayersToolStripMenuItem.Name = "enterPlayersToolStripMenuItem";
            this.enterPlayersToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.enterPlayersToolStripMenuItem.Text = "Enter Players";
            this.enterPlayersToolStripMenuItem.Click += new System.EventHandler(this.enterPlayersToolStripMenuItem_Click);
            // 
            // viewPlayersToolStripMenuItem
            // 
            this.viewPlayersToolStripMenuItem.Name = "viewPlayersToolStripMenuItem";
            this.viewPlayersToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.viewPlayersToolStripMenuItem.Text = "View Players";
            this.viewPlayersToolStripMenuItem.Click += new System.EventHandler(this.viewPlayersToolStripMenuItem_Click);
            // 
            // tossToolStripMenuItem
            // 
            this.tossToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginBidToolStripMenuItem,
            this.rosterToolStripMenuItem});
            this.tossToolStripMenuItem.Name = "tossToolStripMenuItem";
            this.tossToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.tossToolStripMenuItem.Text = "Toss";
            // 
            // beginBidToolStripMenuItem
            // 
            this.beginBidToolStripMenuItem.Name = "beginBidToolStripMenuItem";
            this.beginBidToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beginBidToolStripMenuItem.Text = "Begin Bid";
            this.beginBidToolStripMenuItem.Click += new System.EventHandler(this.beginBidToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.supportToolStripMenuItem.Text = "Support";
            this.supportToolStripMenuItem.Click += new System.EventHandler(this.supportToolStripMenuItem_Click);
            // 
            // rosterToolStripMenuItem
            // 
            this.rosterToolStripMenuItem.Name = "rosterToolStripMenuItem";
            this.rosterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rosterToolStripMenuItem.Text = "Save Roster";
            this.rosterToolStripMenuItem.Click += new System.EventHandler(this.rosterToolStripMenuItem_Click);
            // 
            // editManagersToolStripMenuItem
            // 
            this.editManagersToolStripMenuItem.Name = "editManagersToolStripMenuItem";
            this.editManagersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editManagersToolStripMenuItem.Text = "Edit Managers";
            this.editManagersToolStripMenuItem.Click += new System.EventHandler(this.editManagersToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // MobiCriLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1350, 687);
            this.Controls.Add(this.rootPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 725);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1364, 725);
            this.Name = "MobiCriLeague";
            this.Text = "Mobility Cricket Premium League";
            this.Load += new System.EventHandler(this.MobiCriLeague_Load);
            this.rootPanel.ResumeLayout(false);
            this.rootPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rootPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginBidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem viewPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rosterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editManagersToolStripMenuItem;
    }
}

