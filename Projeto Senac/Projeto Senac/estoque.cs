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
    public partial class estoque : Form
    {
        public estoque()
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

        private void estoque_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"delete from game.jogos 
                where cod = @cod";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("cod", cod.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Jogo removido com sucesso!");

                cod.Clear();
                ga.Clear();
                st.Clear();
                plata.Clear();
                _valor.Clear();
                _qty.Clear();
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

       
        private void alt_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"update game.jogos set 
                    jogo_nm = @jogo_nm, jogo_studio = @jogo_studio, jogo_plat = @jogo_plat, jogo_vl = @jogo_vl, jogo_qty = @jogo_qty
                    where jogo_cod = @jogo_cod";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("jogo_cod", jogos.jogo_cod);
                cmd.Parameters.AddWithValue("jogo_nm", ga.Text);
                cmd.Parameters.AddWithValue("jogo_studio", st.Text);
                cmd.Parameters.AddWithValue("jogo_plat", plata.Text);
                cmd.Parameters.AddWithValue("jogo_vl", _valor.Text);
                cmd.Parameters.AddWithValue("jogo_qty", _qty.Text);

                cod.Clear();
                ga.Clear();
                st.Clear();
                plata.Clear();
                _valor.Clear();
                _qty.Clear();

                // Executar o comando no banco
                cmd.ExecuteNonQuery();

                MessageBox.Show("Jogo alterado com sucesso!");
                
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            jogos.jogo_cod = "";
            gamespesquisa btnpesq = new gamespesquisa();
            btnpesq.ShowDialog();

            if (jogos.jogo_cod != "")
            {
                cod.Text = jogos.jogo_cod;
                ga.Text = jogos.jogo_nm;
                st.Text = jogos.jogo_studio;
                plata.Text = jogos.jogo_plat;
                _valor.Text = jogos.jogo_vl;
                _qty.Text = jogos.jogo_qty;

            }
        }

        private void game_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"delete from game.console
                where con_cod = @con_cod";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("con_cod", concod.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Console removido com sucesso!");

                concod.Clear();
                cons.Clear();
                conemp.Clear();
                conval.Clear();
                conqty.Clear();

                
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"update game.console set 
                    con_nm = @con_nm, con_emp = @con_emp, con_valor = @con_valor, con_qty = @con_qty 
                    where con_cod = @con_cod";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("con_cod", consoles.con_cod);
                cmd.Parameters.AddWithValue("con_nm", cons.Text);
                cmd.Parameters.AddWithValue("con_emp", conemp.Text);
                cmd.Parameters.AddWithValue("con_valor", conval.Text);
                cmd.Parameters.AddWithValue("con_qty", conqty.Text);


                concod.Clear();
                cons.Clear();
                conemp.Clear();
                conval.Clear();
                conqty.Clear();

                // Executar o comando no banco
                cmd.ExecuteNonQuery();

                MessageBox.Show("Console alterado com sucesso!");

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            consoles.con_cod = "";
            consoleest pesqcons = new consoleest();
            pesqcons.ShowDialog();

            if (consoles.con_cod != "")
            {
                concod.Text = consoles.con_cod;
                cons.Text = consoles.con_nm;
                conemp.Text = consoles.con_emp;
                conval.Text = consoles.con_valor;
                conqty.Text = consoles.con_qty;
               
            }
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"update game.gift set 
                    gift_vl = @gift_vl, gift_plat = @gift_plat, gift_qty = @gift_qty
                    where gift_cod = @gift_cod";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("gift_cod", gift.gift_cod);
                cmd.Parameters.AddWithValue("gift_vl", gfval.Text);
                cmd.Parameters.AddWithValue("gift_plat", gfpl.Text);
                cmd.Parameters.AddWithValue("gift_qty", gfqty.Text);
                


               

                // Executar o comando no banco
                cmd.ExecuteNonQuery();

                MessageBox.Show("Gift alterado com sucesso!");

                gfcod.Clear();
                gfval.Clear();
                gfpl.Clear();
                gfqty.Clear();

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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"delete from game.gift
                where gift_cod = @gift_cod";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("gift_cod", concod.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Gift removido com sucesso!");

                gfcod.Clear();
                gfval.Clear();
                gfpl.Clear();
                gfqty.Clear();


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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            gift.gift_cod = "";
            estgift pesqgift = new estgift();
            pesqgift.ShowDialog();

            if (gift.gift_cod != "")
            {
                gfcod.Text = gift.gift_cod;
                gfval.Text = gift.gift_vl;
                gfpl.Text = gift.gift_plat;
                gfqty.Text = gift.gift_qty;
                

            }
        }

        private void gfcod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

