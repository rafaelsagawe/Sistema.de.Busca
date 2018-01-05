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
    public partial class Frm_registros : Form
    {
        public Frm_registros()
        {
            InitializeComponent();
        }

        private void Frm_registros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cENSO_2016DataSet.Escolas_Registros'. Você pode movê-la ou removê-la conforme necessário.
            this.escolas_RegistrosTableAdapter.Fill(this.cENSO_2016DataSet.Escolas_Registros);

        }
    }
}
