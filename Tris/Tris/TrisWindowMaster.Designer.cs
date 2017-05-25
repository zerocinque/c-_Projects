namespace Tris
{
    partial class TrisWindowMaster
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singlePlayerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplayerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settimgsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyMenuComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.modeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsPlayerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsComputerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settimgsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameMenuItem,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameMenuItem
            // 
            this.newGameMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singlePlayerMenuItem,
            this.multiplayerMenuItem});
            this.newGameMenuItem.Name = "newGameMenuItem";
            this.newGameMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameMenuItem.Text = "New Game";
            // 
            // singlePlayerMenuItem
            // 
            this.singlePlayerMenuItem.Name = "singlePlayerMenuItem";
            this.singlePlayerMenuItem.Size = new System.Drawing.Size(152, 22);
            this.singlePlayerMenuItem.Text = "Single Player";
            this.singlePlayerMenuItem.Click += new System.EventHandler(this.singlePlayerMenuItem_Click);
            // 
            // multiplayerMenuItem
            // 
            this.multiplayerMenuItem.Name = "multiplayerMenuItem";
            this.multiplayerMenuItem.Size = new System.Drawing.Size(152, 22);
            this.multiplayerMenuItem.Text = "Multiplayer";
            this.multiplayerMenuItem.Click += new System.EventHandler(this.multiplayerMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitMenuItem.Text = "Exit";
            // 
            // settimgsToolStripMenuItem
            // 
            this.settimgsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyMenuItem,
            this.modeMenuItem});
            this.settimgsToolStripMenuItem.Name = "settimgsToolStripMenuItem";
            this.settimgsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.settimgsToolStripMenuItem.Text = "Settimgs";
            // 
            // difficultyMenuItem
            // 
            this.difficultyMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyMenuComboBox});
            this.difficultyMenuItem.Name = "difficultyMenuItem";
            this.difficultyMenuItem.Size = new System.Drawing.Size(122, 22);
            this.difficultyMenuItem.Text = "Difficulty";
            // 
            // difficultyMenuComboBox
            // 
            this.difficultyMenuComboBox.Name = "difficultyMenuComboBox";
            this.difficultyMenuComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // modeMenuItem
            // 
            this.modeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerVsPlayerMenuItem,
            this.playerVsComputerMenuItem});
            this.modeMenuItem.Name = "modeMenuItem";
            this.modeMenuItem.Size = new System.Drawing.Size(122, 22);
            this.modeMenuItem.Text = "Mode";
            // 
            // playerVsPlayerMenuItem
            // 
            this.playerVsPlayerMenuItem.Name = "playerVsPlayerMenuItem";
            this.playerVsPlayerMenuItem.Size = new System.Drawing.Size(177, 22);
            this.playerVsPlayerMenuItem.Text = "Player vs Player";
            // 
            // playerVsComputerMenuItem
            // 
            this.playerVsComputerMenuItem.Name = "playerVsComputerMenuItem";
            this.playerVsComputerMenuItem.Size = new System.Drawing.Size(177, 22);
            this.playerVsComputerMenuItem.Text = "Player vs Computer";
            // 
            // TrisWindowMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrisWindowMaster";
            this.Text = "Tris";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settimgsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultyMenuItem;
        private System.Windows.Forms.ToolStripComboBox difficultyMenuComboBox;
        private System.Windows.Forms.ToolStripMenuItem modeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsPlayerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsComputerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singlePlayerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplayerMenuItem;
    }
}

