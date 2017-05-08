namespace CampoMinatoWF
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
            this.TXTBomb = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TXTTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TXTBomb
            // 
            this.TXTBomb.Enabled = false;
            this.TXTBomb.Location = new System.Drawing.Point(12, 12);
            this.TXTBomb.Name = "TXTBomb";
            this.TXTBomb.Size = new System.Drawing.Size(100, 20);
            this.TXTBomb.TabIndex = 1;
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGo.Location = new System.Drawing.Point(118, 11);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(48, 20);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "GO!!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TXTTime
            // 
            this.TXTTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTTime.Location = new System.Drawing.Point(172, 11);
            this.TXTTime.Name = "TXTTime";
            this.TXTTime.Size = new System.Drawing.Size(100, 20);
            this.TXTTime.TabIndex = 3;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TXTTime);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.TXTBomb);
            this.Name = "Game";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Campo Minato";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTBomb;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TXTTime;
    }
}