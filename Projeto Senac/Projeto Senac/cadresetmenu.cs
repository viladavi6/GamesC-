using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Senac
{
    public partial class cadreset : Form
    {
        public cadreset()
        {
            InitializeComponent();
        }

        private void cadastroResetDeAcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"update game.acessos set
                    senha = @senha,
                    tipo_usuario = @tipo_usuario
                    where usuario = @usuario";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("usuario", user.Text);
                cmd.Parameters.AddWithValue("senha", pass.Text);
                cmd.Parameters.AddWithValue("tipo_usuario", tipouser.Text);

                // Executar o comando no banco
                cmd.ExecuteNonQuery();

                MessageBox.Show("Senha alterada com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Fechar();
            }

            Close();
        }
       

        private void cadastrar_Click(object sender, EventArgs e)
        {
            if (user.Text.Trim().Length == 0)
            {
                check.SetError(user, "Preencha o usuário");
                return;
            }
            else
            {
                check.SetError(user, "");
            }
            if (pass.Text.Trim().Length == 0)
            {
                check.SetError(pass, "Preencha a senha");
                return;
            }
            else
            {
                check.SetError(pass, "");
            }
            if (tipouser.Text.Trim().Length == 0)
            {
                check.SetError(tipouser, "Selecione o tipo de acesso");
                return;
            }
            else
            {
                check.SetError(tipouser, "");
            }
            try
            {
                Conexao.Conectar();

                string sql = @"insert into game.acessos values (@usuario, @senha, @tipo_usuario)";
                SqlCommand self = new SqlCommand(sql, Conexao.conn);

                self.Parameters.AddWithValue("usuario", user.Text);
                self.Parameters.AddWithValue("senha", pass.Text);
                self.Parameters.AddWithValue("tipo_usuario", tipouser.Text);

                self.ExecuteNonQuery();

                MessageBox.Show("Usuário criado com sucesso!");

                Conexao.Fechar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            Close();
        }

        private void cadreset_Load(object sender, EventArgs e)
        {

        }

        private void tipouser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

