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
    public partial class consoleest : Form
    {
        public consoleest()
        {
            InitializeComponent();
        }

        private void pesqga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"select * from game.console 
                    where con_nm like '" + pesqcon.Text + "%'";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                datcons.DataSource = dt;
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
            linha = datcons.CurrentRow;
            consoles.con_cod = linha.Cells["con_cod"].Value.ToString();
            consoles.con_nm = linha.Cells["con_nm"].Value.ToString();
            consoles.con_emp = linha.Cells["con_emp"].Value.ToString();
            consoles.con_valor = linha.Cells["con_valor"].Value.ToString();
            consoles.con_qty = linha.Cells["con_qty"].Value.ToString();
           

            Close();
        }

        private void consoleest_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = "select * from game.console";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                // DataTable - Cópia da tabela para memória
                DataTable dt = new DataTable();
                // Carregar o DataTable com os dados da tabela
                dt.Load(cmd.ExecuteReader());
                datcons.DataSource = dt;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
