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
    public partial class estgift : Form
    {
        public estgift()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gfbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"select * from game.gift 
                    where gift_plat like '" + gfbox.Text + "%'";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                datgift.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        private void gfpesq_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha;
            linha = datgift.CurrentRow;
            gift.gift_cod = linha.Cells["gift_cod"].Value.ToString();
            gift.gift_vl = linha.Cells["gift_vl"].Value.ToString();
            gift.gift_plat = linha.Cells["gift_plat"].Value.ToString();
            gift.gift_qty = linha.Cells["gift_qty"].Value.ToString();
            

            Close();
        }

        private void estgift_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = "select * from game.gift";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                // DataTable - Cópia da tabela para memória
                DataTable dt = new DataTable();
                // Carregar o DataTable com os dados da tabela
                dt.Load(cmd.ExecuteReader());
                datgift.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Fechar();
            }
        }
    }
}
