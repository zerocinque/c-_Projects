namespace Tris
{
    partial class Game
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
            this.player1Text = new System.Windows.Forms.TextBox();
            this.player2Text = new System.Windows.Forms.TextBox();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.myTimerLabel1 = new TrisLibrary.MyTimerLabel();
            this.myClockLabel = new TrisLibrary.MyClockLabel();
            this.playButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1Text
            // 
            this.player1Text.Location = new System.Drawing.Point(12, 28);
            this.player1Text.Name = "player1Text";
            this.player1Text.Size = new System.Drawing.Size(100, 20);
            this.player1Text.TabIndex = 0;
            // 
            // player2Text
            // 
            this.player2Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.player2Text.Location = new System.Drawing.Point(167, 28);
            this.player2Text.Name = "player2Text";
            this.player2Text.Size = new System.Drawing.Size(100, 20);
            this.player2Text.TabIndex = 1;
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(12, 12);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(62, 13);
            this.player1Label.TabIndex = 2;
            this.player1Label.Text = "Giocatore 1";
            // 
            // player2Label
            // 
            this.player2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.player2Label.AutoSize = true;
            this.player2Label.Location = new System.Drawing.Point(205, 12);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(62, 13);
            this.player2Label.TabIndex = 3;
            this.player2Label.Text = "Giocatore 2";
            // 
            // myTimerLabel1
            // 
            this.myTimerLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.myTimerLabel1.Location = new System.Drawing.Point(112, 19);
            this.myTimerLabel1.Name = "myTimerLabel1";
            this.myTimerLabel1.Size = new System.Drawing.Size(55, 16);
            this.myTimerLabel1.TabIndex = 6;
            this.myTimerLabel1.Text = "00:00";
            this.myTimerLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myClockLabel
            // 
            this.myClockLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.myClockLabel.Location = new System.Drawing.Point(112, 38);
            this.myClockLabel.Name = "myClockLabel";
            this.myClockLabel.Size = new System.Drawing.Size(55, 16);
            this.myClockLabel.TabIndex = 7;
            this.myClockLabel.Text = "hh:mm:ss";
            this.myClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playButton.Location = new System.Drawing.Point(112, 63);
            this.playButton.Margin = new System.Windows.Forms.Padding(0);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(55, 23);
            this.playButton.TabIndex = 8;
            this.playButton.Text = "GIOCA!";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(279, 261);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.myClockLabel);
            this.Controls.Add(this.myTimerLabel1);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.player2Text);
            this.Controls.Add(this.player1Text);
            this.Name = "Game";
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox player1Text;
        private System.Windows.Forms.TextBox player2Text;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Timer timer1;
        private TrisLibrary.MyTimerLabel myTimerLabel1;
        private TrisLibrary.MyClockLabel myClockLabel;
        private System.Windows.Forms.Button playButton;
    }
}