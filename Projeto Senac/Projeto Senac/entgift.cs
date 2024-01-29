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
    public partial class entgift : Form
    {
        public entgift()
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

        private void qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (va.Text.Trim().Length == 0)
            {
                check.SetError(va, "Preencha o campo Valor");
                return;
            }
            else
            {
                check.SetError(va, "");
            }
            if (pl.Text.Trim().Length == 0)
            {
                check.SetError(pl, "Preencha o campo Plataforma");
                return;
            }
            else
            {
                check.SetError(pl, "");
            }
            if (qt.Text.Trim().Length == 0)
            {
                check.SetError(qt, "Preencha o campo Quantidade");
                return;
            }
            else
            {
                check.SetError(qt, "");
            }
            try
            {
                Conexao.Conectar();

                string sql = @"insert into game.gift values (@gift_vl, @gift_plat, @gift_qty)";
                SqlCommand self = new SqlCommand(sql, Conexao.conn);

                self.Parameters.AddWithValue("gift_vl", va.Text);
                self.Parameters.AddWithValue("gift_plat", pl.Text);
                self.Parameters.AddWithValue("gift_qty", qt.Text);

                self.ExecuteNonQuery();

                MessageBox.Show("GiftCard Adicionado com sucesso!");

                Conexao.Fechar();

                

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            
            Close();
        }
    }
}
