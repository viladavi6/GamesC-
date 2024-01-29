namespace Projeto_Senac
{
    partial class cadreset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadreset));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadacess = new System.Windows.Forms.ToolStripMenuItem();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resetar = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.tipouser = new System.Windows.Forms.ComboBox();
            this.acessosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.acesso = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.ErrorProvider(this.components);
            this.acessosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.acessosTableAdapter = new Projeto_Senac.loja_gamesDataSetTableAdapters.acessosTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acessosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadacess});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadacess
            // 
            this.cadacess.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadacess.ForeColor = System.Drawing.Color.White;
            this.cadacess.Name = "cadacess";
            this.cadacess.Size = new System.Drawing.Size(145, 20);
            this.cadacess.Text = "Cadastro/Reset";
            this.cadacess.Click += new System.EventHandler(this.cadastroResetDeAcessosToolStripMenuItem_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(269, 236);
            this.user.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(125, 21);
            this.user.TabIndex = 1;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(269, 276);
            this.pass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(125, 21);
            this.pass.TabIndex = 2;
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.SystemColors.Control;
            this.voltar.Location = new System.Drawing.Point(585, 383);
            this.voltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(58, 40);
            this.voltar.TabIndex = 5;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(208, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(208, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Senha";
            // 
            // resetar
            // 
            this.resetar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.resetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetar.ForeColor = System.Drawing.SystemColors.Control;
            this.resetar.Location = new System.Drawing.Point(83, 383);
            this.resetar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.resetar.Name = "resetar";
            this.resetar.Size = new System.Drawing.Size(58, 40);
            this.resetar.TabIndex = 9;
            this.resetar.Text = "Reset";
            this.resetar.UseVisualStyleBackColor = false;
            this.resetar.Click += new System.EventHandler(this.resetar_Click);
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.cadastrar.Location = new System.Drawing.Point(11, 383);
            this.cadastrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(58, 40);
            this.cadastrar.TabIndex = 10;
            this.cadastrar.Text = "Criar";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // tipouser
            // 
            this.tipouser.FormattingEnabled = true;
            this.tipouser.Items.AddRange(new object[] {
            "usuario",
            "administrador"});
            this.tipouser.Location = new System.Drawing.Point(269, 313);
            this.tipouser.Name = "tipouser";
            this.tipouser.Size = new System.Drawing.Size(125, 23);
            this.tipouser.TabIndex = 11;
            this.tipouser.SelectedIndexChanged += new System.EventHandler(this.tipouser_SelectedIndexChanged);
            // 
            // acessosBindingSource1
            // 
            this.acessosBindingSource1.DataMember = "acessos";
            // acesso
            // 
            this.acesso.AutoSize = true;
            this.acesso.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acesso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.acesso.Location = new System.Drawing.Point(206, 323);
            this.acesso.Name = "acesso";
            this.acesso.Size = new System.Drawing.Size(55, 13);
            this.acesso.TabIndex = 12;
            this.acesso.Text = "Acesso";
            // 
            // check
            // 
            this.check.ContainerControl = this;
            // 
            // acessosBindingSource
            // 
            this.acessosBindingSource.DataMember = "acessos";
            // 
            // acessosTableAdapter
            // 
            //this.acessosTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(628, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 105);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cadreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(654, 435);
            this.ControlBox = false;
            this.Controls.Add(this.acesso);
            this.Controls.Add(this.tipouser);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.resetar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cadreset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.cadreset_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acessosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acessosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadacess;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button voltar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button resetar;
        public System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.ComboBox tipouser;
        private System.Windows.Forms.Label acesso;
        private System.Windows.Forms.ErrorProvider check;
        private System.Windows.Forms.BindingSource acessosBindingSource;
        //private loja_gamesDataSetTableAdapters.acessosTableAdapter acessosTableAdapter;
        private System.Windows.Forms.BindingSource acessosBindingSource1;
    }
}