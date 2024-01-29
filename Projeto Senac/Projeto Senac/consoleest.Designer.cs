namespace Projeto_Senac
{
    partial class consoleest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consoleest));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estoqueConsolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesqcon = new System.Windows.Forms.TextBox();
            this.pesq = new System.Windows.Forms.PictureBox();
            this.datcons = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datcons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueConsolesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estoqueConsolesToolStripMenuItem
            // 
            this.estoqueConsolesToolStripMenuItem.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estoqueConsolesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.estoqueConsolesToolStripMenuItem.Name = "estoqueConsolesToolStripMenuItem";
            this.estoqueConsolesToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.estoqueConsolesToolStripMenuItem.Text = "Estoque Consoles";
            // 
            // pesqcon
            // 
            this.pesqcon.Location = new System.Drawing.Point(12, 44);
            this.pesqcon.Multiline = true;
            this.pesqcon.Name = "pesqcon";
            this.pesqcon.Size = new System.Drawing.Size(725, 31);
            this.pesqcon.TabIndex = 34;
            this.pesqcon.TextChanged += new System.EventHandler(this.pesqga_TextChanged);
            // 
            // pesq
            // 
            this.pesq.Image = ((System.Drawing.Image)(resources.GetObject("pesq.Image")));
            this.pesq.Location = new System.Drawing.Point(743, 39);
            this.pesq.Name = "pesq";
            this.pesq.Size = new System.Drawing.Size(45, 44);
            this.pesq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pesq.TabIndex = 35;
            this.pesq.TabStop = false;
            this.pesq.Click += new System.EventHandler(this.pesq_Click);
            // 
            // datcons
            // 
            this.datcons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datcons.Location = new System.Drawing.Point(12, 89);
            this.datcons.Name = "datcons";
            this.datcons.Size = new System.Drawing.Size(776, 349);
            this.datcons.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(767, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // consoleest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.datcons);
            this.Controls.Add(this.pesq);
            this.Controls.Add(this.pesqcon);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "consoleest";
            this.Load += new System.EventHandler(this.consoleest_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datcons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estoqueConsolesToolStripMenuItem;
        private System.Windows.Forms.TextBox pesqcon;
        private System.Windows.Forms.PictureBox pesq;
        private System.Windows.Forms.DataGridView datcons;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}