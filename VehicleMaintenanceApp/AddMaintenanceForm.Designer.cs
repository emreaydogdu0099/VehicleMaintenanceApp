namespace VehicleMaintenanceApp;

partial class AddMaintenanceForm
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
        components = new System.ComponentModel.Container();
        groupBox1 = new GroupBox();
        txtQuantity = new TextBox();
        btnAddMaintanence = new Button();
        cmbTaxRate = new ComboBox();
        label6 = new Label();
        txtLaborCost = new TextBox();
        label5 = new Label();
        txtMaterialUnitPrice = new TextBox();
        label4 = new Label();
        label3 = new Label();
        cmbUnit = new ComboBox();
        label2 = new Label();
        txtMaintenanceType = new TextBox();
        label1 = new Label();
        maintenanceBindingSource = new BindingSource(components);
        dgwNewRecords = new DataGridView();
        idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        createdDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        maintenanceTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        materialUnitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        taxRateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        laborCostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        groupBox2 = new GroupBox();
        txtUpdatedQuantity = new TextBox();
        btnUpdate = new Button();
        cmbUpdatedTaxRate = new ComboBox();
        label7 = new Label();
        txtUpdatedLaborCost = new TextBox();
        label8 = new Label();
        txtUpdatedMaterialUnitPrice = new TextBox();
        label9 = new Label();
        label10 = new Label();
        cmbUpdatedUnit = new ComboBox();
        label11 = new Label();
        txtUpdatedMaintenanceType = new TextBox();
        label12 = new Label();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)maintenanceBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgwNewRecords).BeginInit();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(txtQuantity);
        groupBox1.Controls.Add(btnAddMaintanence);
        groupBox1.Controls.Add(cmbTaxRate);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(txtLaborCost);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(txtMaterialUnitPrice);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(cmbUnit);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(txtMaintenanceType);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(56, 525);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(457, 258);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "Yeni Kayıt Ekle";
        // 
        // txtQuantity
        // 
        txtQuantity.Location = new Point(174, 99);
        txtQuantity.Name = "txtQuantity";
        txtQuantity.Size = new Size(132, 23);
        txtQuantity.TabIndex = 13;
        // 
        // btnAddMaintanence
        // 
        btnAddMaintanence.Location = new Point(345, 217);
        btnAddMaintanence.Name = "btnAddMaintanence";
        btnAddMaintanence.Size = new Size(88, 23);
        btnAddMaintanence.TabIndex = 12;
        btnAddMaintanence.Text = "Kaydet";
        btnAddMaintanence.UseVisualStyleBackColor = true;
        btnAddMaintanence.Click += btnAddMaintanence_Click;
        // 
        // cmbTaxRate
        // 
        cmbTaxRate.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTaxRate.FormattingEnabled = true;
        cmbTaxRate.Location = new Point(174, 218);
        cmbTaxRate.Name = "cmbTaxRate";
        cmbTaxRate.Size = new Size(132, 23);
        cmbTaxRate.TabIndex = 11;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(6, 221);
        label6.Name = "label6";
        label6.Size = new Size(61, 15);
        label6.TabIndex = 10;
        label6.Text = "KDV Oranı";
        // 
        // txtLaborCost
        // 
        txtLaborCost.Location = new Point(174, 178);
        txtLaborCost.Name = "txtLaborCost";
        txtLaborCost.Size = new Size(132, 23);
        txtLaborCost.TabIndex = 9;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(6, 181);
        label5.Name = "label5";
        label5.Size = new Size(70, 15);
        label5.TabIndex = 8;
        label5.Text = "İşçilik Ücreti";
        // 
        // txtMaterialUnitPrice
        // 
        txtMaterialUnitPrice.Location = new Point(174, 137);
        txtMaterialUnitPrice.Name = "txtMaterialUnitPrice";
        txtMaterialUnitPrice.Size = new Size(132, 23);
        txtMaterialUnitPrice.TabIndex = 7;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(6, 140);
        label4.Name = "label4";
        label4.Size = new Size(66, 15);
        label4.TabIndex = 6;
        label4.Text = "Birim Fiyatı";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(6, 102);
        label3.Name = "label3";
        label3.Size = new Size(128, 15);
        label3.TabIndex = 4;
        label3.Text = "Miktar(Adet/Lite/Kutu)";
        // 
        // cmbUnit
        // 
        cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbUnit.FormattingEnabled = true;
        cmbUnit.Location = new Point(174, 60);
        cmbUnit.Name = "cmbUnit";
        cmbUnit.Size = new Size(132, 23);
        cmbUnit.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(6, 63);
        label2.Name = "label2";
        label2.Size = new Size(35, 15);
        label2.TabIndex = 2;
        label2.Text = "Birim";
        // 
        // txtMaintenanceType
        // 
        txtMaintenanceType.Location = new Point(174, 21);
        txtMaintenanceType.Name = "txtMaintenanceType";
        txtMaintenanceType.Size = new Size(259, 23);
        txtMaintenanceType.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(6, 24);
        label1.Name = "label1";
        label1.Size = new Size(150, 15);
        label1.TabIndex = 0;
        label1.Text = "Yapılan İşlem/Malzeme Adı";
        // 
        // maintenanceBindingSource
        // 
        maintenanceBindingSource.DataSource = typeof(Models.Entities.Maintenance);
        // 
        // dgwNewRecords
        // 
        dgwNewRecords.AllowUserToAddRows = false;
        dgwNewRecords.AllowUserToDeleteRows = false;
        dgwNewRecords.AutoGenerateColumns = false;
        dgwNewRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgwNewRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgwNewRecords.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, createdDateDataGridViewTextBoxColumn, maintenanceTypeDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, materialUnitPriceDataGridViewTextBoxColumn, taxRateDataGridViewTextBoxColumn, laborCostDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1 });
        dgwNewRecords.DataSource = maintenanceBindingSource;
        dgwNewRecords.Location = new Point(56, 24);
        dgwNewRecords.Name = "dgwNewRecords";
        dgwNewRecords.ReadOnly = true;
        dgwNewRecords.Size = new Size(1281, 446);
        dgwNewRecords.TabIndex = 8;
        dgwNewRecords.CellClick += dgwNewRecords_CellClick;
        // 
        // idDataGridViewTextBoxColumn
        // 
        idDataGridViewTextBoxColumn.DataPropertyName = "Id";
        idDataGridViewTextBoxColumn.HeaderText = "Id";
        idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
        idDataGridViewTextBoxColumn.ReadOnly = true;
        idDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
        idDataGridViewTextBoxColumn.Visible = false;
        // 
        // createdDateDataGridViewTextBoxColumn
        // 
        createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
        createdDateDataGridViewTextBoxColumn.HeaderText = "Tarih";
        createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
        createdDateDataGridViewTextBoxColumn.ReadOnly = true;
        createdDateDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
        // 
        // maintenanceTypeDataGridViewTextBoxColumn
        // 
        maintenanceTypeDataGridViewTextBoxColumn.DataPropertyName = "MaintenanceType";
        maintenanceTypeDataGridViewTextBoxColumn.HeaderText = "İşlem Türü/Malzeme Adı";
        maintenanceTypeDataGridViewTextBoxColumn.Name = "maintenanceTypeDataGridViewTextBoxColumn";
        maintenanceTypeDataGridViewTextBoxColumn.ReadOnly = true;
        maintenanceTypeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
        // 
        // unitDataGridViewTextBoxColumn
        // 
        unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
        unitDataGridViewTextBoxColumn.HeaderText = "Birim";
        unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
        unitDataGridViewTextBoxColumn.ReadOnly = true;
        unitDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
        // 
        // quantityDataGridViewTextBoxColumn
        // 
        quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
        quantityDataGridViewTextBoxColumn.HeaderText = "Miktar(Adet/Litre/Kutu)";
        quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
        quantityDataGridViewTextBoxColumn.ReadOnly = true;
        quantityDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
        // 
        // materialUnitPriceDataGridViewTextBoxColumn
        // 
        materialUnitPriceDataGridViewTextBoxColumn.DataPropertyName = "MaterialUnitPrice";
        materialUnitPriceDataGridViewTextBoxColumn.HeaderText = "Birim Fiyatı(Adet,Litre,Kutu)";
        materialUnitPriceDataGridViewTextBoxColumn.Name = "materialUnitPriceDataGridViewTextBoxColumn";
        materialUnitPriceDataGridViewTextBoxColumn.ReadOnly = true;
        materialUnitPriceDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
        // 
        // taxRateDataGridViewTextBoxColumn
        // 
        taxRateDataGridViewTextBoxColumn.DataPropertyName = "TaxRate";
        taxRateDataGridViewTextBoxColumn.HeaderText = "KDV Oranı";
        taxRateDataGridViewTextBoxColumn.Name = "taxRateDataGridViewTextBoxColumn";
        taxRateDataGridViewTextBoxColumn.ReadOnly = true;
        taxRateDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
        // 
        // laborCostDataGridViewTextBoxColumn
        // 
        laborCostDataGridViewTextBoxColumn.DataPropertyName = "LaborCost";
        laborCostDataGridViewTextBoxColumn.HeaderText = "Extra Ücret(İşçilik)";
        laborCostDataGridViewTextBoxColumn.Name = "laborCostDataGridViewTextBoxColumn";
        laborCostDataGridViewTextBoxColumn.ReadOnly = true;
        laborCostDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.DataPropertyName = "TotalAmount";
        dataGridViewTextBoxColumn1.HeaderText = "Toplam Fiyat";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(txtUpdatedQuantity);
        groupBox2.Controls.Add(btnUpdate);
        groupBox2.Controls.Add(cmbUpdatedTaxRate);
        groupBox2.Controls.Add(label7);
        groupBox2.Controls.Add(txtUpdatedLaborCost);
        groupBox2.Controls.Add(label8);
        groupBox2.Controls.Add(txtUpdatedMaterialUnitPrice);
        groupBox2.Controls.Add(label9);
        groupBox2.Controls.Add(label10);
        groupBox2.Controls.Add(cmbUpdatedUnit);
        groupBox2.Controls.Add(label11);
        groupBox2.Controls.Add(txtUpdatedMaintenanceType);
        groupBox2.Controls.Add(label12);
        groupBox2.Location = new Point(638, 525);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(457, 258);
        groupBox2.TabIndex = 9;
        groupBox2.TabStop = false;
        groupBox2.Text = "Kaydı Güncelle";
        // 
        // txtUpdatedQuantity
        // 
        txtUpdatedQuantity.Location = new Point(174, 99);
        txtUpdatedQuantity.Name = "txtUpdatedQuantity";
        txtUpdatedQuantity.Size = new Size(132, 23);
        txtUpdatedQuantity.TabIndex = 13;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(345, 217);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(88, 23);
        btnUpdate.TabIndex = 12;
        btnUpdate.Text = "Güncelle";
        btnUpdate.UseVisualStyleBackColor = true;
        // 
        // cmbUpdatedTaxRate
        // 
        cmbUpdatedTaxRate.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbUpdatedTaxRate.FormattingEnabled = true;
        cmbUpdatedTaxRate.Location = new Point(174, 218);
        cmbUpdatedTaxRate.Name = "cmbUpdatedTaxRate";
        cmbUpdatedTaxRate.Size = new Size(132, 23);
        cmbUpdatedTaxRate.TabIndex = 11;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(6, 221);
        label7.Name = "label7";
        label7.Size = new Size(61, 15);
        label7.TabIndex = 10;
        label7.Text = "KDV Oranı";
        // 
        // txtUpdatedLaborCost
        // 
        txtUpdatedLaborCost.Location = new Point(174, 178);
        txtUpdatedLaborCost.Name = "txtUpdatedLaborCost";
        txtUpdatedLaborCost.Size = new Size(132, 23);
        txtUpdatedLaborCost.TabIndex = 9;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(6, 181);
        label8.Name = "label8";
        label8.Size = new Size(70, 15);
        label8.TabIndex = 8;
        label8.Text = "İşçilik Ücreti";
        // 
        // txtUpdatedMaterialUnitPrice
        // 
        txtUpdatedMaterialUnitPrice.Location = new Point(174, 137);
        txtUpdatedMaterialUnitPrice.Name = "txtUpdatedMaterialUnitPrice";
        txtUpdatedMaterialUnitPrice.Size = new Size(132, 23);
        txtUpdatedMaterialUnitPrice.TabIndex = 7;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(6, 140);
        label9.Name = "label9";
        label9.Size = new Size(66, 15);
        label9.TabIndex = 6;
        label9.Text = "Birim Fiyatı";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(6, 102);
        label10.Name = "label10";
        label10.Size = new Size(128, 15);
        label10.TabIndex = 4;
        label10.Text = "Miktar(Adet/Lite/Kutu)";
        // 
        // cmbUpdatedUnit
        // 
        cmbUpdatedUnit.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbUpdatedUnit.FormattingEnabled = true;
        cmbUpdatedUnit.Location = new Point(174, 60);
        cmbUpdatedUnit.Name = "cmbUpdatedUnit";
        cmbUpdatedUnit.Size = new Size(132, 23);
        cmbUpdatedUnit.TabIndex = 3;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(6, 63);
        label11.Name = "label11";
        label11.Size = new Size(35, 15);
        label11.TabIndex = 2;
        label11.Text = "Birim";
        // 
        // txtUpdatedMaintenanceType
        // 
        txtUpdatedMaintenanceType.Location = new Point(174, 21);
        txtUpdatedMaintenanceType.Name = "txtUpdatedMaintenanceType";
        txtUpdatedMaintenanceType.Size = new Size(259, 23);
        txtUpdatedMaintenanceType.TabIndex = 1;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(6, 24);
        label12.Name = "label12";
        label12.Size = new Size(150, 15);
        label12.TabIndex = 0;
        label12.Text = "Yapılan İşlem/Malzeme Adı";
        // 
        // AddMaintenanceForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1402, 829);
        Controls.Add(groupBox2);
        Controls.Add(dgwNewRecords);
        Controls.Add(groupBox1);
        Name = "AddMaintenanceForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Araç Bakım Uygulaması";
        Load += AddMaintenanceForm_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)maintenanceBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgwNewRecords).EndInit();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private GroupBox groupBox1;
    private Label label1;
    private TextBox txtMaintenanceType;
    private ComboBox cmbUnit;
    private Label label2;
    private Label label3;
    private TextBox txtMaterialUnitPrice;
    private Label label4;
    private ComboBox cmbTaxRate;
    private Label label6;
    private TextBox txtLaborCost;
    private Label label5;
    private Button btnAddMaintanence;
    private BindingSource maintenanceBindingSource;
    private TextBox txtQuantity;
    private DataGridView dgwNewRecords;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn maintenanceTypeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn materialUnitPriceDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn taxRateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn laborCostDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private GroupBox groupBox2;
    private TextBox txtUpdatedQuantity;
    private Button btnUpdate;
    private ComboBox cmbUpdatedTaxRate;
    private Label label7;
    private TextBox txtUpdatedLaborCost;
    private Label label8;
    private TextBox txtUpdatedMaterialUnitPrice;
    private Label label9;
    private Label label10;
    private ComboBox cmbUpdatedUnit;
    private Label label11;
    private TextBox txtUpdatedMaintenanceType;
    private Label label12;
}