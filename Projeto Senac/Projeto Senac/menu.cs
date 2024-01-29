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
    public partial class mnprincipal : Form
    {
        public mnprincipal()
        {
            InitializeComponent();
        }

        private void mnprincipal_Load(object sender, EventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadusuario_Click(object sender, EventArgs e)
        {
            cadreset menu = new cadreset();
            menu.ShowDialog();
            
        }

        private void cadprod_Click(object sender, EventArgs e)
        {
            Entrada_de_estoque menu = new Entrada_de_estoque();
            menu.ShowDialog();
        }

        private void estq_Click(object sender, EventArgs e)
        {
            estoque menu = new estoque();
            menu.ShowDialog();
        }

        private void caixa_Click(object sender, EventArgs e)
        {
            caixa menu = new caixa();
            menu.ShowDialog();
        }
    }
}
