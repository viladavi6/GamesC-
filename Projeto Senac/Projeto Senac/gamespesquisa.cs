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
    public partial class gamespesquisa : Form
    {
        public gamespesquisa()
        {
            InitializeComponent();
        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gamespesquisa_Load(object sender, EventArgs e)
        {
            
            try
            {
                Conexao.Conectar();
                string sql = "select * from game.jogos";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                // DataTable - Cópia da tabela para memória
                DataTable dt = new DataTable();
                // Carregar o DataTable com os dados da tabela
                dt.Load(cmd.ExecuteReader());
                datgames.DataSource = dt;
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

        private void pesq_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha;
            linha = datgames.CurrentRow;
            jogos.jogo_cod = linha.Cells["jogo_cod"].Value.ToString();
            jogos.jogo_nm = linha.Cells["jogo_nm"].Value.ToString();
            jogos.jogo_studio = linha.Cells["jogo_studio"].Value.ToString();
            jogos.jogo_plat = linha.Cells["jogo_plat"].Value.ToString();
            jogos.jogo_vl = linha.Cells["jogo_vl"].Value.ToString();
            jogos.jogo_qty = linha.Cells["jogo_qty"].Value.ToString();

            Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"select * from game.jogos 
                    where jogo_nm like '" + pesqga.Text + "%'";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                datgames.DataSource = dt;
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

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
