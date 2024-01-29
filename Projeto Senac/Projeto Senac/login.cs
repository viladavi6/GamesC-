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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();

                string sql = @"select * from game.acessos
	                where usuario = @usuario 
	                and senha = @senha";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("usuario", login.Text);
                cmd.Parameters.AddWithValue("senha", senha.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                // Verifica se houve retorno de algum registro
                if (dr.HasRows)
                {
                    // Abrir o sistema - LOGIN EFETUADO
                    dr.Read();
                    if (dr["tipo_usuario"].ToString() == "administrador")
                    {
                        mnprincipal menu = new mnprincipal();
                        Visible = false;
                        menu.ShowDialog();
                        Visible = true;
                        login.Clear();
                        senha.Clear();
                        login.Focus();
                    }
                    else if (dr["tipo_usuario"].ToString() == "usuario")
                    {
                        mnprincipal menu = new mnprincipal();
                        Visible = false;
                        menu.cadusuario.Visible = false;
                        menu.ShowDialog();
                        Visible = true;
                        login.Clear();
                        senha.Clear();
                        login.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha inválidos!");
                }

                Conexao.Fechar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

