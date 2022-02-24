namespace KafeTekno.UI
{
    partial class AnaForm
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
            this.tsmiUrunler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGecmisSiparisler = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwMasalar = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUrunler,
            this.tsmiGecmisSiparisler});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(767, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiUrunler
            // 
            this.tsmiUrunler.Name = "tsmiUrunler";
            this.tsmiUrunler.Size = new System.Drawing.Size(88, 29);
            this.tsmiUrunler.Text = "Ürünler";
            // 
            // tsmiGecmisSiparisler
            // 
            this.tsmiGecmisSiparisler.Name = "tsmiGecmisSiparisler";
            this.tsmiGecmisSiparisler.Size = new System.Drawing.Size(168, 29);
            this.tsmiGecmisSiparisler.Text = "Geçmiş Siparişler";
            // 
            // lvwMasalar
            // 
            this.lvwMasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwMasalar.HideSelection = false;
            this.lvwMasalar.Location = new System.Drawing.Point(0, 37);
            this.lvwMasalar.Name = "lvwMasalar";
            this.lvwMasalar.Size = new System.Drawing.Size(767, 449);
            this.lvwMasalar.TabIndex = 1;
            this.lvwMasalar.UseCompatibleStateImageBehavior = false;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 486);
            this.Controls.Add(this.lvwMasalar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AnaForm";
            this.Text = "Kafe Tekno";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUrunler;
        private System.Windows.Forms.ToolStripMenuItem tsmiGecmisSiparisler;
        private System.Windows.Forms.ListView lvwMasalar;
    }
}