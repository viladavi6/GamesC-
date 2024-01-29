namespace Projeto_Senac
{
    partial class estgift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(estgift));
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.giftCardEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datgift = new System.Windows.Forms.DataGridView();
            this.gfbox = new System.Windows.Forms.TextBox();
            this.gfpesq = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gfpesq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giftCardEstoqueToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(800, 24);
            this.menuStrip3.TabIndex = 10;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // giftCardEstoqueToolStripMenuItem
            // 
            this.giftCardEstoqueToolStripMenuItem.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giftCardEstoqueToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.giftCardEstoqueToolStripMenuItem.Name = "giftCardEstoqueToolStripMenuItem";
            this.giftCardEstoqueToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.giftCardEstoqueToolStripMenuItem.Text = "GiftCard Estoque";
            // 
            // datgift
            // 
            this.datgift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgift.Location = new System.Drawing.Point(14, 92);
            this.datgift.Name = "datgift";
            this.datgift.Size = new System.Drawing.Size(776, 346);
            this.datgift.TabIndex = 37;
            // 
            // gfbox
            // 
            this.gfbox.Location = new System.Drawing.Point(14, 37);
            this.gfbox.Multiline = true;
            this.gfbox.Name = "gfbox";
            this.gfbox.Size = new System.Drawing.Size(725, 31);
            this.gfbox.TabIndex = 36;
            this.gfbox.TextChanged += new System.EventHandler(this.gfbox_TextChanged);
            // 
            // gfpesq
            // 
            this.gfpesq.Image = ((System.Drawing.Image)(resources.GetObject("gfpesq.Image")));
            this.gfpesq.Location = new System.Drawing.Point(745, 30);
            this.gfpesq.Name = "gfpesq";
            this.gfpesq.Size = new System.Drawing.Size(45, 44);
            this.gfpesq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gfpesq.TabIndex = 35;
            this.gfpesq.TabStop = false;
            this.gfpesq.Click += new System.EventHandler(this.gfpesq_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(767, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // estgift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.datgift);
            this.Controls.Add(this.gfbox);
            this.Controls.Add(this.gfpesq);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip3);
            this.Name = "estgift";
            this.Load += new System.EventHandler(this.estgift_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gfpesq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem giftCardEstoqueToolStripMenuItem;
        private System.Windows.Forms.DataGridView datgift;
        private System.Windows.Forms.TextBox gfbox;
        private System.Windows.Forms.PictureBox gfpesq;
    }
}