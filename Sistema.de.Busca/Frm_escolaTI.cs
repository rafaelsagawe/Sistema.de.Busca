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
    public partial class Frm_escolaTI : Form
    {
        public Frm_escolaTI()
        {
            InitializeComponent();
        }

        private void Frm_escolaTI_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cENSO_2016DataSet.Escolas_equipamentos_de_TI'. Você pode movê-la ou removê-la conforme necessário.
            this.escolas_equipamentos_de_TITableAdapter.Fill(this.cENSO_2016DataSet.Escolas_equipamentos_de_TI);
        }
    }
}
