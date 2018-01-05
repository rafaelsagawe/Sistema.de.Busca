namespace Sistema.de.Busca
{
    partial class Frm_registros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_registros));
            this.cENSO_2016DataSet = new Sistema.de.Busca.CENSO_2016DataSet();
            this.escolas_RegistrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escolas_RegistrosTableAdapter = new Sistema.de.Busca.CENSO_2016DataSetTableAdapters.Escolas_RegistrosTableAdapter();
            this.tableAdapterManager = new Sistema.de.Busca.CENSO_2016DataSetTableAdapters.TableAdapterManager();
            this.escolas_RegistrosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.escolas_RegistrosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.escolas_RegistrosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cENSO_2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolas_RegistrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolas_RegistrosBindingNavigator)).BeginInit();
            this.escolas_RegistrosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escolas_RegistrosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cENSO_2016DataSet
            // 
            this.cENSO_2016DataSet.DataSetName = "CENSO_2016DataSet";
            this.cENSO_2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // escolas_RegistrosBindingSource
            // 
            this.escolas_RegistrosBindingSource.DataMember = "Escolas Registros";
            this.escolas_RegistrosBindingSource.DataSource = this.cENSO_2016DataSet;
            // 
            // escolas_RegistrosTableAdapter
            // 
            this.escolas_RegistrosTableAdapter.ClearBeforeFill = true;
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
            // escolas_RegistrosBindingNavigator
            // 
            this.escolas_RegistrosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.escolas_RegistrosBindingNavigator.BindingSource = this.escolas_RegistrosBindingSource;
            this.escolas_RegistrosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.escolas_RegistrosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.escolas_RegistrosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.escolas_RegistrosBindingNavigatorSaveItem});
            this.escolas_RegistrosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.escolas_RegistrosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.escolas_RegistrosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.escolas_RegistrosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.escolas_RegistrosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.escolas_RegistrosBindingNavigator.Name = "escolas_RegistrosBindingNavigator";
            this.escolas_RegistrosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.escolas_RegistrosBindingNavigator.Size = new System.Drawing.Size(420, 25);
            this.escolas_RegistrosBindingNavigator.TabIndex = 0;
            this.escolas_RegistrosBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // escolas_RegistrosBindingNavigatorSaveItem
            // 
            this.escolas_RegistrosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.escolas_RegistrosBindingNavigatorSaveItem.Enabled = false;
            this.escolas_RegistrosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("escolas_RegistrosBindingNavigatorSaveItem.Image")));
            this.escolas_RegistrosBindingNavigatorSaveItem.Name = "escolas_RegistrosBindingNavigatorSaveItem";
            this.escolas_RegistrosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.escolas_RegistrosBindingNavigatorSaveItem.Text = "Salvar Dados";
            // 
            // escolas_RegistrosDataGridView
            // 
            this.escolas_RegistrosDataGridView.AllowUserToOrderColumns = true;
            this.escolas_RegistrosDataGridView.AutoGenerateColumns = false;
            this.escolas_RegistrosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.escolas_RegistrosDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.escolas_RegistrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.escolas_RegistrosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.escolas_RegistrosDataGridView.DataSource = this.escolas_RegistrosBindingSource;
            this.escolas_RegistrosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.escolas_RegistrosDataGridView.Location = new System.Drawing.Point(0, 25);
            this.escolas_RegistrosDataGridView.Name = "escolas_RegistrosDataGridView";
            this.escolas_RegistrosDataGridView.Size = new System.Drawing.Size(420, 311);
            this.escolas_RegistrosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Unidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Unidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 72;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "INEP";
            this.dataGridViewTextBoxColumn2.HeaderText = "INEP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 57;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CNPJ";
            this.dataGridViewTextBoxColumn3.HeaderText = "CNPJ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 59;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "N de protocolo";
            this.dataGridViewTextBoxColumn4.HeaderText = "N de protocolo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 102;
            // 
            // Frm_registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 336);
            this.Controls.Add(this.escolas_RegistrosDataGridView);
            this.Controls.Add(this.escolas_RegistrosBindingNavigator);
            this.Name = "Frm_registros";
            this.Text = "Frm_registros";
            this.Load += new System.EventHandler(this.Frm_registros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cENSO_2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolas_RegistrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolas_RegistrosBindingNavigator)).EndInit();
            this.escolas_RegistrosBindingNavigator.ResumeLayout(false);
            this.escolas_RegistrosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escolas_RegistrosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CENSO_2016DataSet cENSO_2016DataSet;
        private System.Windows.Forms.BindingSource escolas_RegistrosBindingSource;
        private CENSO_2016DataSetTableAdapters.Escolas_RegistrosTableAdapter escolas_RegistrosTableAdapter;
        private CENSO_2016DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator escolas_RegistrosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton escolas_RegistrosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView escolas_RegistrosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}