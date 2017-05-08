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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.partitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovaPartitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opzioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficoltàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaStoricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXTBomb
            // 
            this.TXTBomb.Enabled = false;
            this.TXTBomb.Location = new System.Drawing.Point(11, 39);
            this.TXTBomb.Name = "TXTBomb";
            this.TXTBomb.Size = new System.Drawing.Size(100, 20);
            this.TXTBomb.TabIndex = 1;
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGo.Location = new System.Drawing.Point(117, 38);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(48, 20);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "GO!!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // TXTTime
            // 
            this.TXTTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTTime.Location = new System.Drawing.Point(171, 38);
            this.TXTTime.Name = "TXTTime";
            this.TXTTime.Size = new System.Drawing.Size(100, 20);
            this.TXTTime.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partitaToolStripMenuItem,
            this.opzioniToolStripMenuItem,
            this.storicoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // partitaToolStripMenuItem
            // 
            this.partitaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovaPartitaToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.partitaToolStripMenuItem.Name = "partitaToolStripMenuItem";
            this.partitaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.partitaToolStripMenuItem.Text = "Partita";
            // 
            // nuovaPartitaToolStripMenuItem
            // 
            this.nuovaPartitaToolStripMenuItem.Name = "nuovaPartitaToolStripMenuItem";
            this.nuovaPartitaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuovaPartitaToolStripMenuItem.Text = "Nuova Partita";
            this.nuovaPartitaToolStripMenuItem.Click += new System.EventHandler(this.nuovaPartitaToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // opzioniToolStripMenuItem
            // 
            this.opzioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficoltàToolStripMenuItem});
            this.opzioniToolStripMenuItem.Name = "opzioniToolStripMenuItem";
            this.opzioniToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.opzioniToolStripMenuItem.Text = "Opzioni";
            // 
            // difficoltàToolStripMenuItem
            // 
            this.difficoltàToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principianteToolStripMenuItem,
            this.intermedioToolStripMenuItem,
            this.espertoToolStripMenuItem});
            this.difficoltàToolStripMenuItem.Name = "difficoltàToolStripMenuItem";
            this.difficoltàToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.difficoltàToolStripMenuItem.Text = "Difficoltà";
            // 
            // storicoToolStripMenuItem
            // 
            this.storicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizzaStoricoToolStripMenuItem});
            this.storicoToolStripMenuItem.Name = "storicoToolStripMenuItem";
            this.storicoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.storicoToolStripMenuItem.Text = "Storico";
            // 
            // visualizzaStoricoToolStripMenuItem
            // 
            this.visualizzaStoricoToolStripMenuItem.Name = "visualizzaStoricoToolStripMenuItem";
            this.visualizzaStoricoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.visualizzaStoricoToolStripMenuItem.Text = "Visualizza Storico";
            this.visualizzaStoricoToolStripMenuItem.Click += new System.EventHandler(this.visualizzaStoricoToolStripMenuItem_Click);
            // 
            // principianteToolStripMenuItem
            // 
            this.principianteToolStripMenuItem.Name = "principianteToolStripMenuItem";
            this.principianteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.principianteToolStripMenuItem.Text = "Principiante";
            this.principianteToolStripMenuItem.Click += new System.EventHandler(this.principianteToolStripMenuItem_Click);
            // 
            // intermedioToolStripMenuItem
            // 
            this.intermedioToolStripMenuItem.Name = "intermedioToolStripMenuItem";
            this.intermedioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.intermedioToolStripMenuItem.Text = "Intermedio";
            this.intermedioToolStripMenuItem.Click += new System.EventHandler(this.intermedioToolStripMenuItem_Click);
            // 
            // espertoToolStripMenuItem
            // 
            this.espertoToolStripMenuItem.Name = "espertoToolStripMenuItem";
            this.espertoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.espertoToolStripMenuItem.Text = "Esperto";
            this.espertoToolStripMenuItem.Click += new System.EventHandler(this.espertoToolStripMenuItem_Click);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Campo Minato";
            this.Load += new System.EventHandler(this.Game_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTBomb;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TXTTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem partitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovaPartitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opzioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficoltàToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaStoricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem principianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intermedioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espertoToolStripMenuItem;
    }
}