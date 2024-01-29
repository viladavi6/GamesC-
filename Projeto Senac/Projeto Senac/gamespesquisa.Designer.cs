namespace Projeto_Senac
{
    partial class gamespesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gamespesquisa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pesq = new System.Windows.Forms.PictureBox();
            this.pesqga = new System.Windows.Forms.TextBox();
            this.jogosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.datgames = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jogosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datgames)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.pesquisaToolStripMenuItem.Text = "Estoque Jogos";
            this.pesquisaToolStripMenuItem.Click += new System.EventHandler(this.pesquisaToolStripMenuItem_Click);
            // 
            // jogosBindingSource
            // 
            this.jogosBindingSource.DataMember = "jogos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(767, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pesq
            // 
            this.pesq.Image = ((System.Drawing.Image)(resources.GetObject("pesq.Image")));
            this.pesq.Location = new System.Drawing.Point(743, 30);
            this.pesq.Name = "pesq";
            this.pesq.Size = new System.Drawing.Size(45, 44);
            this.pesq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pesq.TabIndex = 32;
            this.pesq.TabStop = false;
            this.pesq.Click += new System.EventHandler(this.pesq_Click);
            // 
            // pesqga
            // 
            this.pesqga.Location = new System.Drawing.Point(12, 37);
            this.pesqga.Multiline = true;
            this.pesqga.Name = "pesqga";
            this.pesqga.Size = new System.Drawing.Size(725, 31);
            this.pesqga.TabIndex = 33;
            this.pesqga.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // jogosBindingSource1
            // 
            this.jogosBindingSource1.DataMember = "jogos";
            // 
            // datgames
            // 
            this.datgames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgames.Location = new System.Drawing.Point(12, 92);
            this.datgames.Name = "datgames";
            this.datgames.Size = new System.Drawing.Size(776, 346);
            this.datgames.TabIndex = 34;
            this.datgames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // gamespesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.datgames);
            this.Controls.Add(this.pesqga);
            this.Controls.Add(this.pesq);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "gamespesquisa";
            this.Load += new System.EventHandler(this.gamespesquisa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jogosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datgames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource jogosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jogonmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jogostudioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jogoplatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jogovlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jogoqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pesq;
        private System.Windows.Forms.TextBox pesqga;
        private System.Windows.Forms.BindingSource jogosBindingSource1;
        private System.Windows.Forms.DataGridView datgames;
    }
}