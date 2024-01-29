using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Senac
{
    public partial class Entrada_de_estoque : Form
    {
        public Entrada_de_estoque()
        {
            InitializeComponent();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            entgift menu = new entgift();
            menu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game_add menu = new game_add();
            menu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entconsole menu = new entconsole();
            menu.ShowDialog();
        }
    }
}
