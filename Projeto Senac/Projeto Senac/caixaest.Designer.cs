namespace Projeto_Senac
{
    partial class caixaest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(caixaest));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estoqueDeVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.datgift = new System.Windows.Forms.DataGridView();
            this.gfbox = new System.Windows.Forms.TextBox();
            this.gfpesq = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datgift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gfpesq)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueDeVendaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estoqueDeVendaToolStripMenuItem
            // 
            this.estoqueDeVendaToolStripMenuItem.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estoqueDeVendaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.estoqueDeVendaToolStripMenuItem.Name = "estoqueDeVendaToolStripMenuItem";
            this.estoqueDeVendaToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.estoqueDeVendaToolStripMenuItem.Text = "Estoque de venda";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(774, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // datgift
            // 
            this.datgift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgift.Location = new System.Drawing.Point(14, 92);
            this.datgift.Name = "datgift";
            this.datgift.Size = new System.Drawing.Size(776, 346);
            this.datgift.TabIndex = 40;
            // 
            // gfbox
            // 
            this.gfbox.Location = new System.Drawing.Point(14, 37);
            this.gfbox.Multiline = true;
            this.gfbox.Name = "gfbox";
            this.gfbox.Size = new System.Drawing.Size(725, 31);
            this.gfbox.TabIndex = 39;
            // 
            // gfpesq
            // 
            this.gfpesq.Image = ((System.Drawing.Image)(resources.GetObject("gfpesq.Image")));
            this.gfpesq.Location = new System.Drawing.Point(745, 30);
            this.gfpesq.Name = "gfpesq";
            this.gfpesq.Size = new System.Drawing.Size(45, 44);
            this.gfpesq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gfpesq.TabIndex = 38;
            this.gfpesq.TabStop = false;
            // 
            // caixaest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.datgift);
            this.Controls.Add(this.gfbox);
            this.Controls.Add(this.gfpesq);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "caixaest";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datgift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gfpesq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estoqueDeVendaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView datgift;
        private System.Windows.Forms.TextBox gfbox;
        private System.Windows.Forms.PictureBox gfpesq;
    }
}