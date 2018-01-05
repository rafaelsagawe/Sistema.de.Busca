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
    public partial class Frm_enderecos : Form
    {
        public Frm_enderecos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cENSO_2016DataSet.Supervisão'. Você pode movê-la ou removê-la conforme necessário.
            this.supervisãoTableAdapter.Fill(this.cENSO_2016DataSet.Supervisão);
            // TODO: esta linha de código carrega dados na tabela 'cENSO_2016DataSet.TS_ESCOLA'. Você pode movê-la ou removê-la conforme necessário.
            // TODO: esta linha de código carrega dados na tabela 'cENSO_2016DataSet.Escolas_com_Localização_e_Situação'. Você pode movê-la ou removê-la conforme necessário.
            // TODO: esta linha de código carrega dados na tabela 'cENSO_2016DataSet.Escolas_com_Localização_e_Situação'. Você pode movê-la ou removê-la conforme necessário.

        }

        private void escolas_com_Localização_e_SituaçãoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                    }

        private void tS_ESCOLABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.cENSO_2016DataSet);

        }
    }
}
