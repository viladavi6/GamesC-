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
    public partial class game_add : Form
    {
        public game_add()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (game.Text.Trim().Length == 0)
            {
                check.SetError(game, "Preencha o campo Jogo");
                return;
            }
            else
            {
                check.SetError(game, "");
            }
            if (studio.Text.Trim().Length == 0)
            {
                check.SetError(studio, "Preencha o campo Estúdio");
                return;
            }
            else
            {
                check.SetError(studio, "");
            }
            if (plat.Text.Trim().Length == 0)
            {
                check.SetError(plat, "Preencha o campo Plataforma");
                return;
            }
            else
            {
                check.SetError(plat, "");
            }
            if (valor.Text.Trim().Length == 0)
            {
                check.SetError(valor, "Preencha o campo Valor");
                return;
            }
            else
            {
                check.SetError(valor, "");
            }
            if (qty.Text.Trim().Length == 0)
            {
                check.SetError(qty, "Preencha o campo Quantidade");
                return;
            }
            else
            {
                check.SetError(qty, "");
            }
            try
            {
                Conexao.Conectar();

                string sql = @"insert into game.jogos values (@jogo_nm, @jogo_studio, @jogo_plat, @jogo_val, @jogo_qty)";
                SqlCommand self = new SqlCommand(sql, Conexao.conn);

                self.Parameters.AddWithValue("jogo_nm", game.Text);
                self.Parameters.AddWithValue("jogo_studio", studio.Text);
                self.Parameters.AddWithValue("jogo_plat", plat.Text);
                self.Parameters.AddWithValue("jogo_val", valor.Text);
                self.Parameters.AddWithValue("jogo_qty", qty.Text);

                self.ExecuteNonQuery();

                MessageBox.Show("Jogo Adicionado com sucesso!");

                Conexao.Fechar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
