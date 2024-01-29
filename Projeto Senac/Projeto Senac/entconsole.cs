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
    public partial class entconsole : Form
    {
        public entconsole()
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
            if (cons.Text.Trim().Length == 0)
            {
                check.SetError(cons, "Preencha o campo Console");
                return;
            }
            else
            {
                check.SetError(cons, "");
            }
            if (emp.Text.Trim().Length == 0)
            {
                check.SetError(emp, "Preencha o campo Empresa");
                return;
            }
            else
            {
                check.SetError(emp, "");
            }
            if (val.Text.Trim().Length == 0)
            {
                check.SetError(val, "Preencha o campo Valor");
                return;
            }
            else
            {
                check.SetError(val, "");
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

                string sql = @"insert into game.console values (@con_nm, @con_emp, @con_valor, @con_qty)";
                SqlCommand self = new SqlCommand(sql, Conexao.conn);

                self.Parameters.AddWithValue("con_nm", cons.Text);
                self.Parameters.AddWithValue("con_emp", emp.Text);
                self.Parameters.AddWithValue("con_valor", val.Text);
                self.Parameters.AddWithValue("con_qty", qty.Text);

                self.ExecuteNonQuery();

                MessageBox.Show("Console Adicionado com sucesso!");

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
