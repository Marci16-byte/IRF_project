namespace SwimSocietyAdminApp
{
    partial class Form1
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
        /// 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuSwimmersButton = new System.Windows.Forms.Button();
            this.menuStatsButton = new System.Windows.Forms.Button();
            this.menuExitButton = new System.Windows.Forms.Button();
            this.menuClubsButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menüToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swimmersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clubsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.menuSwimmersButton);
            this.panel1.Controls.Add(this.menuStatsButton);
            this.panel1.Controls.Add(this.menuExitButton);
            this.panel1.Controls.Add(this.menuClubsButton);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 729);
            this.panel1.TabIndex = 0;
            // 
            // menuSwimmersButton
            // 
            this.menuSwimmersButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuSwimmersButton.FlatAppearance.BorderSize = 0;
            this.menuSwimmersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSwimmersButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuSwimmersButton.Location = new System.Drawing.Point(126, 139);
            this.menuSwimmersButton.Name = "menuSwimmersButton";
            this.menuSwimmersButton.Size = new System.Drawing.Size(160, 40);
            this.menuSwimmersButton.TabIndex = 0;
            this.menuSwimmersButton.Text = "Úszók kezelése";
            this.menuSwimmersButton.UseVisualStyleBackColor = false;
            this.menuSwimmersButton.Click += new System.EventHandler(this.menuSwimmersButton_Click);
            // 
            // menuStatsButton
            // 
            this.menuStatsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStatsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStatsButton.Location = new System.Drawing.Point(773, 139);
            this.menuStatsButton.Name = "menuStatsButton";
            this.menuStatsButton.Size = new System.Drawing.Size(150, 40);
            this.menuStatsButton.TabIndex = 0;
            this.menuStatsButton.Text = "Statisztikák";
            this.menuStatsButton.UseVisualStyleBackColor = false;
            this.menuStatsButton.Click += new System.EventHandler(this.menuStatsButton_Click);
            // 
            // menuExitButton
            // 
            this.menuExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuExitButton.BackColor = System.Drawing.Color.White;
            this.menuExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuExitButton.Location = new System.Drawing.Point(462, 638);
            this.menuExitButton.Name = "menuExitButton";
            this.menuExitButton.Size = new System.Drawing.Size(150, 40);
            this.menuExitButton.TabIndex = 3;
            this.menuExitButton.Text = "Kilépés";
            this.menuExitButton.UseVisualStyleBackColor = false;
            this.menuExitButton.Click += new System.EventHandler(this.menuExitButton_Click);
            // 
            // menuClubsButton
            // 
            this.menuClubsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuClubsButton.FlatAppearance.BorderSize = 0;
            this.menuClubsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuClubsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuClubsButton.Location = new System.Drawing.Point(452, 111);
            this.menuClubsButton.Name = "menuClubsButton";
            this.menuClubsButton.Size = new System.Drawing.Size(160, 40);
            this.menuClubsButton.TabIndex = 1;
            this.menuClubsButton.Text = "Klubok kezelése";
            this.menuClubsButton.UseVisualStyleBackColor = false;
            this.menuClubsButton.Click += new System.EventHandler(this.menuClubsButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.menüToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.menüToolStripMenuItem.Text = "Fájl";
            // 
            // menüToolStripMenuItem1
            // 
            this.menüToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.swimmersToolStripMenuItem,
            this.clubsToolStripMenuItem,
            this.statsToolStripMenuItem});
            this.menüToolStripMenuItem1.Name = "menüToolStripMenuItem1";
            this.menüToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem1.Text = "Menü";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Kilépés";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // swimmersToolStripMenuItem
            // 
            this.swimmersToolStripMenuItem.Name = "swimmersToolStripMenuItem";
            this.swimmersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.swimmersToolStripMenuItem.Text = "Úszók kezelése";
            this.swimmersToolStripMenuItem.Click += new System.EventHandler(this.swimmersToolStripMenuItem_Click);
            // 
            // clubsToolStripMenuItem
            // 
            this.clubsToolStripMenuItem.Name = "clubsToolStripMenuItem";
            this.clubsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clubsToolStripMenuItem.Text = "Klubok kezelése";
            this.clubsToolStripMenuItem.Click += new System.EventHandler(this.clubsToolStripMenuItem_Click);
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statsToolStripMenuItem.Text = "Statisztikák";
            this.statsToolStripMenuItem.Click += new System.EventHandler(this.statsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1920, 1024);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MÚSZ Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menuSwimmersButton;
        private System.Windows.Forms.Button menuClubsButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem1;
        private System.Windows.Forms.Button menuStatsButton;
        private System.Windows.Forms.Button menuExitButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swimmersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clubsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
    }
}

