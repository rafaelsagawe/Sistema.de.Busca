using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.de.Busca
{
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }
        private void Frm_principal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void endereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_enderecos frm_end = new Frm_enderecos();
            frm_end.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_registros frm_reg = new Frm_registros();
            frm_reg.Show();
        }

        private void informáticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_escolaTI frm_ti = new Frm_escolaTI();
            frm_ti.Show();
        }

        private void mapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_mapa frm_map = new Frm_mapa();
            frm_map.Show();
        }
    }
}
