namespace Sistema.de.Busca
{
    partial class Frm_enderecos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_enderecos));
            this.cENSO_2016DataSet = new Sistema.de.Busca.CENSO_2016DataSet();
            this.supervisãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supervisãoTableAdapter = new Sistema.de.Busca.CENSO_2016DataSetTableAdapters.SupervisãoTableAdapter();
            this.tableAdapterManager = new Sistema.de.Busca.CENSO_2016DataSetTableAdapters.TableAdapterManager();
            this.supervisãoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.supervisãoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.supervisãoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cENSO_2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supervisãoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supervisãoBindingNavigator)).BeginInit();
            this.supervisãoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supervisãoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cENSO_2016DataSet
            // 
            this.cENSO_2016DataSet.DataSetName = "CENSO_2016DataSet";
            this.cENSO_2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supervisãoBindingSource
            // 
            this.supervisãoBindingSource.DataMember = "Supervisão";
            this.supervisãoBindingSource.DataSource = this.cENSO_2016DataSet;
            // 
            // supervisãoTableAdapter
            // 
            this.supervisãoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CO_AREA_CURSOTableAdapter = null;
            this.tableAdapterManager.CO_CURSOTableAdapter = null;
            this.tableAdapterManager.CO_DISTRITOTableAdapter = null;
            this.tableAdapterManager.CO_MESORREGIAOTableAdapter = null;
            this.tableAdapterManager.CO_MICRORREGIAOTableAdapter = null;
            this.tableAdapterManager.CO_MUNICIPIOTableAdapter = null;
            this.tableAdapterManager.CO_UFTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.IN_AGUA_CACIMBATableAdapter = null;
            this.tableAdapterManager.IN_AGUA_FILTRADATableAdapter = null;
            this.tableAdapterManager.IN_AGUA_FONTE_RIOTableAdapter = null;
            this.tableAdapterManager.IN_AGUA_INEXISTENTETableAdapter = null;
            this.tableAdapterManager.IN_AGUA_POCO_ARTESIANOTableAdapter = null;
            this.tableAdapterManager.IN_AGUA_REDE_PUBLICATableAdapter = null;
            this.tableAdapterManager.IN_ALIMENTACAOTableAdapter = null;
            this.tableAdapterManager.IN_ALMOXARIFADOTableAdapter = null;
            this.tableAdapterManager.IN_ALOJAM_ALUNOTableAdapter = null;
            this.tableAdapterManager.IN_ALOJAM_PROFESSORTableAdapter = null;
            this.tableAdapterManager.IN_AREA_VERDETableAdapter = null;
            this.tableAdapterManager.IN_AUDITORIOTableAdapter = null;
            this.tableAdapterManager.IN_BANDA_LARGATableAdapter = null;
            this.tableAdapterManager.IN_BANHEIRO_CHUVEIROTableAdapter = null;
            this.tableAdapterManager.IN_BANHEIRO_DENTRO_PREDIOTableAdapter = null;
            this.tableAdapterManager.IN_BANHEIRO_EITableAdapter = null;
            this.tableAdapterManager.IN_BANHEIRO_FORA_PREDIOTableAdapter = null;
            this.tableAdapterManager.IN_BANHEIRO_PNETableAdapter = null;
            this.tableAdapterManager.IN_BERCARIOTableAdapter = null;
            this.tableAdapterManager.IN_BIBLIOTECA_SALA_LEITURATableAdapter = null;
            this.tableAdapterManager.IN_BIBLIOTECATableAdapter = null;
            this.tableAdapterManager.IN_BRASIL_ALFABETIZADOTableAdapter = null;
            this.tableAdapterManager.IN_COM_PEDAGOGICATableAdapter = null;
            this.tableAdapterManager.IN_COMPUTADORTableAdapter = null;
            this.tableAdapterManager.IN_COMUM_CRECHETableAdapter = null;
            this.tableAdapterManager.IN_COMUM_EJA_FUNDTableAdapter = null;
            this.tableAdapterManager.IN_COMUM_EJA_MEDIOTableAdapter = null;
            this.tableAdapterManager.IN_COMUM_EJA_PROFTableAdapter = null;
            this.tableAdapterManager.IN_COMUM_FUND_AFTableAdapter = null;
            this.tableAdapterManager.IN_COMUM_FUND_AITableAdapter = null;
            this.tableAdapterManager.IN_COMUM_MEDIO_INTEGRADOTableAdapter = null;
            this.tableAdapterManager.IN_COMUM_MEDIO_MEDIOTableAdapter = null;
            this.tableAdapterManager.IN_COMUM_MEDIO_NORMALTableAdapter = null;
            this.tableAdapterManager.IN_COMUM_PRETableAdapter = null;
            this.tableAdapterManager.IN_COMUM_PROFTableAdapter = null;
            this.tableAdapterManager.IN_CONVENIADA_PPTableAdapter = null;
            this.tableAdapterManager.IN_COZINHATableAdapter = null;
            this.tableAdapterManager.IN_DEPENDENCIAS_OUTRASTableAdapter = null;
            this.tableAdapterManager.IN_DEPENDENCIAS_PNETableAdapter = null;
            this.tableAdapterManager.IN_DESPENSATableAdapter = null;
            this.tableAdapterManager.IN_EDUCACAO_INDIGENATableAdapter = null;
            this.tableAdapterManager.IN_EJATableAdapter = null;
            this.tableAdapterManager.IN_ENERGIA_GERADORTableAdapter = null;
            this.tableAdapterManager.IN_ENERGIA_INEXISTENTETableAdapter = null;
            this.tableAdapterManager.IN_ENERGIA_OUTROSTableAdapter = null;
            this.tableAdapterManager.IN_ENERGIA_REDE_PUBLICATableAdapter = null;
            this.tableAdapterManager.IN_EQUIP_COPIADORATableAdapter = null;
            this.tableAdapterManager.IN_EQUIP_DVDTableAdapter = null;
            this.tableAdapterManager.IN_EQUIP_FAXTableAdapter = null;
            this.tableAdapterManager.IN_EQUIP_FOTOTableAdapter = null;
            this.tableAdapterManager.IN_EQUIP_IMPRESSORA_MULTTableAdapter = null;
            this.tableAdapterManager.IN_EQUIP_IMPRESSORATableAdapter = null;
            this.tableAdapterManager.IN_EQUIP_RETROPROJETORTableAdapter = null;
            this.tableAdapterManager.IN_IESTableAdapter = null;
            this.tableAdapterManager.IN_INTERNETTableAdapter = null;
            this.tableAdapterManager.IN_LICENCIATURATableAdapter = null;
            this.tableAdapterManager.Portal_Info_distorcaoTableAdapter = null;
            this.tableAdapterManager.Portal_Info_mapa_estatisticoTableAdapter = null;
            this.tableAdapterManager.Portal_Info_projecaoTableAdapter = null;
            this.tableAdapterManager.TI_NITableAdapter = null;
            this.tableAdapterManager.TP_ESCOLARIDADETableAdapter = null;
            this.tableAdapterManager.TP_LOCALIZACAOTableAdapter = null;
            this.tableAdapterManager.TP_SITUACAO_CURSOTableAdapter = null;
            this.tableAdapterManager.TP_SITUACAO_FUNCIONAMENTOTableAdapter = null;
            this.tableAdapterManager.TP_TIPO_CONTRATACAOTableAdapter = null;
            this.tableAdapterManager.TP_TIPO_DOCENTETableAdapter = null;
            this.tableAdapterManager.TP_TIPO_IESTableAdapter = null;
            this.tableAdapterManager.TS_DOCENTESTableAdapter = null;
            this.tableAdapterManager.TS_ESCOLATableAdapter = null;
            this.tableAdapterManager.TS_MATRICULATableAdapter = null;
            this.tableAdapterManager.UE_CEPTableAdapter = null;
            this.tableAdapterManager.UE_CNPJTableAdapter = null;
            this.tableAdapterManager.UE_DIRETORTableAdapter = null;
            this.tableAdapterManager.UE_DOCENTE_CPFTableAdapter = null;
            this.tableAdapterManager.UE_DOCENTE_EMAILTableAdapter = null;
            this.tableAdapterManager.UE_DOCENTE_ENDERECOTableAdapter = null;
            this.tableAdapterManager.UE_DOCENTE_NOMETableAdapter = null;
            this.tableAdapterManager.UE_DOCENTE_PAISTableAdapter = null;
            this.tableAdapterManager.UE_EMAILTableAdapter = null;
            this.tableAdapterManager.UE_ENDERECO_urgTableAdapter = null;
            this.tableAdapterManager.UE_ENDERECOTableAdapter = null;
            this.tableAdapterManager.UE_GEO_LOCALIZACAOTableAdapter = null;
            this.tableAdapterManager.UE_INTERNETTableAdapter = null;
            this.tableAdapterManager.UE_PROJETORTableAdapter = null;
            this.tableAdapterManager.UE_PROTOCOLOTableAdapter = null;
            this.tableAdapterManager.UE_TELEFONESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sistema.de.Busca.CENSO_2016DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // supervisãoBindingNavigator
            // 
            this.supervisãoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.supervisãoBindingNavigator.BindingSource = this.supervisãoBindingSource;
            this.supervisãoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.supervisãoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.supervisãoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.supervisãoBindingNavigatorSaveItem});
            this.supervisãoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.supervisãoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.supervisãoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.supervisãoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.supervisãoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.supervisãoBindingNavigator.Name = "supervisãoBindingNavigator";
            this.supervisãoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.supervisãoBindingNavigator.Size = new System.Drawing.Size(613, 25);
            this.supervisãoBindingNavigator.TabIndex = 0;
            this.supervisãoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // supervisãoBindingNavigatorSaveItem
            // 
            this.supervisãoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.supervisãoBindingNavigatorSaveItem.Enabled = false;
            this.supervisãoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("supervisãoBindingNavigatorSaveItem.Image")));
            this.supervisãoBindingNavigatorSaveItem.Name = "supervisãoBindingNavigatorSaveItem";
            this.supervisãoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.supervisãoBindingNavigatorSaveItem.Text = "Salvar Dados";
            // 
            // supervisãoDataGridView
            // 
            this.supervisãoDataGridView.AllowUserToOrderColumns = true;
            this.supervisãoDataGridView.AutoGenerateColumns = false;
            this.supervisãoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.supervisãoDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.supervisãoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supervisãoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.supervisãoDataGridView.DataSource = this.supervisãoBindingSource;
            this.supervisãoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supervisãoDataGridView.Location = new System.Drawing.Point(0, 25);
            this.supervisãoDataGridView.Name = "supervisãoDataGridView";
            this.supervisãoDataGridView.Size = new System.Drawing.Size(613, 353);
            this.supervisãoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "N de protocolo";
            this.dataGridViewTextBoxColumn1.HeaderText = "N de protocolo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 102;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NO_ENTIDADE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NO_ENTIDADE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 109;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn3.HeaderText = "endereco";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 77;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "numero";
            this.dataGridViewTextBoxColumn4.HeaderText = "numero";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 67;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "complemento";
            this.dataGridViewTextBoxColumn5.HeaderText = "complemento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 95;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "bairro";
            this.dataGridViewTextBoxColumn6.HeaderText = "bairro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 58;
            // 
            // Frm_enderecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 378);
            this.Controls.Add(this.supervisãoDataGridView);
            this.Controls.Add(this.supervisãoBindingNavigator);
            this.Name = "Frm_enderecos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endereço das escolas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cENSO_2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supervisãoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supervisãoBindingNavigator)).EndInit();
            this.supervisãoBindingNavigator.ResumeLayout(false);
            this.supervisãoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supervisãoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CENSO_2016DataSet cENSO_2016DataSet;
        private System.Windows.Forms.BindingSource supervisãoBindingSource;
        private CENSO_2016DataSetTableAdapters.SupervisãoTableAdapter supervisãoTableAdapter;
        private CENSO_2016DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator supervisãoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton supervisãoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView supervisãoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

