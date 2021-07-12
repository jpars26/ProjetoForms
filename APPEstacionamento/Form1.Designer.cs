namespace APPEstacionamento
{
    partial class Form1
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
            System.Windows.Forms.Label veiculoLabel;
            System.Windows.Forms.Label ladoLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label idCarroLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bD_ProjetoDataSet = new APPEstacionamento.BD_ProjetoDataSet();
            this.estacionamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estacionamentoTableAdapter = new APPEstacionamento.BD_ProjetoDataSetTableAdapters.EstacionamentoTableAdapter();
            this.tableAdapterManager = new APPEstacionamento.BD_ProjetoDataSetTableAdapters.TableAdapterManager();
            this.estacionamentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.BtnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TxtVeiculo = new System.Windows.Forms.TextBox();
            this.TxtLado = new System.Windows.Forms.ComboBox();
            this.TxtData = new System.Windows.Forms.DateTimePicker();
            this.DataGridBanco = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtHora = new System.Windows.Forms.ComboBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.TxtIdCarro = new System.Windows.Forms.TextBox();
            veiculoLabel = new System.Windows.Forms.Label();
            ladoLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            idCarroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ProjetoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingNavigator)).BeginInit();
            this.estacionamentoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // veiculoLabel
            // 
            veiculoLabel.AutoSize = true;
            veiculoLabel.Location = new System.Drawing.Point(17, 63);
            veiculoLabel.Name = "veiculoLabel";
            veiculoLabel.Size = new System.Drawing.Size(45, 13);
            veiculoLabel.TabIndex = 2;
            veiculoLabel.Text = "Veiculo:";
            // 
            // ladoLabel
            // 
            ladoLabel.AutoSize = true;
            ladoLabel.Location = new System.Drawing.Point(352, 58);
            ladoLabel.Name = "ladoLabel";
            ladoLabel.Size = new System.Drawing.Size(34, 13);
            ladoLabel.TabIndex = 6;
            ladoLabel.Text = "Lado:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(188, 60);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 7;
            dataLabel.Text = "Data:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(17, 117);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(33, 13);
            horaLabel.TabIndex = 8;
            horaLabel.Text = "Hora:";
            // 
            // idCarroLabel
            // 
            idCarroLabel.AutoSize = true;
            idCarroLabel.Location = new System.Drawing.Point(391, 97);
            idCarroLabel.Name = "idCarroLabel";
            idCarroLabel.Size = new System.Drawing.Size(47, 13);
            idCarroLabel.TabIndex = 11;
            idCarroLabel.Text = "Id Carro:";
            // 
            // bD_ProjetoDataSet
            // 
            this.bD_ProjetoDataSet.DataSetName = "BD_ProjetoDataSet";
            this.bD_ProjetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estacionamentoBindingSource
            // 
            this.estacionamentoBindingSource.DataMember = "Estacionamento";
            this.estacionamentoBindingSource.DataSource = this.bD_ProjetoDataSet;
            // 
            // estacionamentoTableAdapter
            // 
            this.estacionamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EstacionamentoTableAdapter = this.estacionamentoTableAdapter;
            this.tableAdapterManager.UpdateOrder = APPEstacionamento.BD_ProjetoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // estacionamentoBindingNavigator
            // 
            this.estacionamentoBindingNavigator.AddNewItem = this.BtnAdicionar;
            this.estacionamentoBindingNavigator.BindingSource = this.estacionamentoBindingSource;
            this.estacionamentoBindingNavigator.CountItem = null;
            this.estacionamentoBindingNavigator.DeleteItem = null;
            this.estacionamentoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.BtnAdicionar,
            this.bindingNavigatorSeparator1,
            this.BtnSalvar,
            this.bindingNavigatorSeparator2});
            this.estacionamentoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estacionamentoBindingNavigator.MoveFirstItem = null;
            this.estacionamentoBindingNavigator.MoveLastItem = null;
            this.estacionamentoBindingNavigator.MoveNextItem = null;
            this.estacionamentoBindingNavigator.MovePreviousItem = null;
            this.estacionamentoBindingNavigator.Name = "estacionamentoBindingNavigator";
            this.estacionamentoBindingNavigator.PositionItem = null;
            this.estacionamentoBindingNavigator.Size = new System.Drawing.Size(689, 25);
            this.estacionamentoBindingNavigator.TabIndex = 0;
            this.estacionamentoBindingNavigator.Text = "bindingNavigator1";
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdicionar.Image")));
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.RightToLeftAutoMirrorImage = true;
            this.BtnAdicionar.Size = new System.Drawing.Size(23, 22);
            this.BtnAdicionar.Text = "Add new";
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.Image")));
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(23, 22);
            this.BtnSalvar.Text = "Save Data";
            this.BtnSalvar.Click += new System.EventHandler(this.estacionamentoBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TxtVeiculo
            // 
            this.TxtVeiculo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionamentoBindingSource, "Veiculo", true));
            this.TxtVeiculo.Location = new System.Drawing.Point(68, 60);
            this.TxtVeiculo.Name = "TxtVeiculo";
            this.TxtVeiculo.Size = new System.Drawing.Size(100, 20);
            this.TxtVeiculo.TabIndex = 3;
            // 
            // TxtLado
            // 
            this.TxtLado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionamentoBindingSource, "Lado", true));
            this.TxtLado.FormattingEnabled = true;
            this.TxtLado.Items.AddRange(new object[] {
            "Direito",
            "Esquerdo"});
            this.TxtLado.Location = new System.Drawing.Point(392, 55);
            this.TxtLado.Name = "TxtLado";
            this.TxtLado.Size = new System.Drawing.Size(121, 21);
            this.TxtLado.TabIndex = 7;
            // 
            // TxtData
            // 
            this.TxtData.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.estacionamentoBindingSource, "Data", true));
            this.TxtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtData.Location = new System.Drawing.Point(227, 56);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(119, 20);
            this.TxtData.TabIndex = 8;
            this.TxtData.Value = new System.DateTime(2021, 7, 2, 17, 55, 37, 0);
            // 
            // DataGridBanco
            // 
            this.DataGridBanco.AutoGenerateColumns = false;
            this.DataGridBanco.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridBanco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.DataGridBanco.DataSource = this.estacionamentoBindingSource;
            this.DataGridBanco.Location = new System.Drawing.Point(12, 218);
            this.DataGridBanco.Name = "DataGridBanco";
            this.DataGridBanco.Size = new System.Drawing.Size(646, 220);
            this.DataGridBanco.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCarro";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCarro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Veiculo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Veiculo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Lado";
            this.dataGridViewTextBoxColumn4.HeaderText = "Lado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Situacao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Situacao";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn6.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // TxtHora
            // 
            this.TxtHora.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionamentoBindingSource, "Hora", true));
            this.TxtHora.FormattingEnabled = true;
            this.TxtHora.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "00"});
            this.TxtHora.Location = new System.Drawing.Point(56, 114);
            this.TxtHora.Name = "TxtHora";
            this.TxtHora.Size = new System.Drawing.Size(121, 21);
            this.TxtHora.TabIndex = 9;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(296, 144);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 10;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click_1);
            // 
            // TxtIdCarro
            // 
            this.TxtIdCarro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estacionamentoBindingSource, "IdCarro", true));
            this.TxtIdCarro.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.estacionamentoBindingSource, "IdCarro", true));
            this.TxtIdCarro.Location = new System.Drawing.Point(444, 94);
            this.TxtIdCarro.Name = "TxtIdCarro";
            this.TxtIdCarro.Size = new System.Drawing.Size(100, 20);
            this.TxtIdCarro.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 466);
            this.Controls.Add(idCarroLabel);
            this.Controls.Add(this.TxtIdCarro);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.TxtHora);
            this.Controls.Add(this.DataGridBanco);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(ladoLabel);
            this.Controls.Add(this.TxtLado);
            this.Controls.Add(veiculoLabel);
            this.Controls.Add(this.TxtVeiculo);
            this.Controls.Add(this.estacionamentoBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_ProjetoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingNavigator)).EndInit();
            this.estacionamentoBindingNavigator.ResumeLayout(false);
            this.estacionamentoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBanco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_ProjetoDataSet bD_ProjetoDataSet;
        private System.Windows.Forms.BindingSource estacionamentoBindingSource;
        private BD_ProjetoDataSetTableAdapters.EstacionamentoTableAdapter estacionamentoTableAdapter;
        private BD_ProjetoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator estacionamentoBindingNavigator;
        private System.Windows.Forms.ToolStripButton BtnAdicionar;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton BtnSalvar;
        private System.Windows.Forms.TextBox TxtVeiculo;
        private System.Windows.Forms.ComboBox TxtLado;
        private System.Windows.Forms.DateTimePicker TxtData;
        private System.Windows.Forms.DataGridView DataGridBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ComboBox TxtHora;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.TextBox TxtIdCarro;
    }
}

