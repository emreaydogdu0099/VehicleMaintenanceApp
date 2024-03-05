namespace VehicleMaintenanceApp;

partial class VehicleMaintenanceForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        label1 = new Label();
        txtPlateNumber = new TextBox();
        btnSearch = new Button();
        btnAddVehicle = new Button();
        btnAddMaintenance = new Button();
        btnDeleteOldRecord = new Button();
        dgwOldRecords = new DataGridView();
        idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        createdDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        maintenanceTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        materialUnitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        taxRateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        laborCostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        maintenanceBindingSource = new BindingSource(components);
        ((System.ComponentModel.ISupportInitialize)dgwOldRecords).BeginInit();
        ((System.ComponentModel.ISupportInitialize)maintenanceBindingSource).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(71, 70);
        label1.Name = "label1";
        label1.Size = new Size(86, 15);
        label1.TabIndex = 1;
        label1.Text = "ARAÇ PLAKASI";
        // 
        // txtPlateNumber
        // 
        txtPlateNumber.Location = new Point(203, 66);
        txtPlateNumber.Name = "txtPlateNumber";
        txtPlateNumber.Size = new Size(165, 23);
        txtPlateNumber.TabIndex = 2;
        txtPlateNumber.TextChanged += txtPlateNumber_TextChanged;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(480, 56);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(126, 40);
        btnSearch.TabIndex = 3;
        btnSearch.Text = "SORGULA";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // btnAddVehicle
        // 
        btnAddVehicle.Location = new Point(644, 56);
        btnAddVehicle.Name = "btnAddVehicle";
        btnAddVehicle.Size = new Size(126, 40);
        btnAddVehicle.TabIndex = 4;
        btnAddVehicle.Text = "KAYDET";
        btnAddVehicle.UseVisualStyleBackColor = true;
        btnAddVehicle.Click += btnAddVehicle_Click;
        // 
        // btnAddMaintenance
        // 
        btnAddMaintenance.Location = new Point(985, 56);
        btnAddMaintenance.Name = "btnAddMaintenance";
        btnAddMaintenance.Size = new Size(126, 40);
        btnAddMaintenance.TabIndex = 5;
        btnAddMaintenance.Text = "BAKIM KAYDI EKLE";
        btnAddMaintenance.UseVisualStyleBackColor = true;
        btnAddMaintenance.Click += btnAddMaintenance_Click;
        // 
        // btnDeleteOldRecord
        // 
        btnDeleteOldRecord.Location = new Point(1156, 700);
        btnDeleteOldRecord.Name = "btnDeleteOldRecord";
        btnDeleteOldRecord.Size = new Size(126, 40);
        btnDeleteOldRecord.TabIndex = 6;
        btnDeleteOldRecord.Text = "Seçilen Kaydı Sil";
        btnDeleteOldRecord.UseVisualStyleBackColor = true;
        btnDeleteOldRecord.Click += btnDeleteOldRecord_Click;
        // 
        // dgwOldRecords
        // 
        dgwOldRecords.AllowUserToAddRows = false;
        dgwOldRecords.AllowUserToDeleteRows = false;
        dgwOldRecords.AllowUserToResizeColumns = false;
        dgwOldRecords.AutoGenerateColumns = false;
        dgwOldRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgwOldRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgwOldRecords.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, createdDateDataGridViewTextBoxColumn, maintenanceTypeDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, materialUnitPriceDataGridViewTextBoxColumn, taxRateDataGridViewTextBoxColumn, laborCostDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1 });
        dgwOldRecords.DataSource = maintenanceBindingSource;
        dgwOldRecords.Location = new Point(49, 135);
        dgwOldRecords.MultiSelect = false;
        dgwOldRecords.Name = "dgwOldRecords";
        dgwOldRecords.ReadOnly = true;
        dgwOldRecords.Size = new Size(1281, 464);
        dgwOldRecords.TabIndex = 7;
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
        dataGridViewCellStyle1.Format = "N2";
        dataGridViewCellStyle1.NullValue = null;
        quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
        quantityDataGridViewTextBoxColumn.HeaderText = "Miktar(Adet/Litre/Kutu)";
        quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
        quantityDataGridViewTextBoxColumn.ReadOnly = true;
        quantityDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
        // 
        // materialUnitPriceDataGridViewTextBoxColumn
        // 
        materialUnitPriceDataGridViewTextBoxColumn.DataPropertyName = "MaterialUnitPrice";
        dataGridViewCellStyle2.Format = "N2";
        dataGridViewCellStyle2.NullValue = null;
        materialUnitPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
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
        dataGridViewCellStyle3.Format = "N2";
        dataGridViewCellStyle3.NullValue = null;
        laborCostDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
        laborCostDataGridViewTextBoxColumn.HeaderText = "Extra Ücret(İşçilik)";
        laborCostDataGridViewTextBoxColumn.Name = "laborCostDataGridViewTextBoxColumn";
        laborCostDataGridViewTextBoxColumn.ReadOnly = true;
        laborCostDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.DataPropertyName = "TotalAmount";
        dataGridViewCellStyle4.Format = "N2";
        dataGridViewCellStyle4.NullValue = null;
        dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
        dataGridViewTextBoxColumn1.HeaderText = "Toplam Fiyat";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
        // 
        // maintenanceBindingSource
        // 
        maintenanceBindingSource.DataSource = typeof(Models.Entities.Maintenance);
        // 
        // VehicleMaintenanceForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1387, 812);
        Controls.Add(dgwOldRecords);
        Controls.Add(btnDeleteOldRecord);
        Controls.Add(btnAddMaintenance);
        Controls.Add(btnAddVehicle);
        Controls.Add(btnSearch);
        Controls.Add(txtPlateNumber);
        Controls.Add(label1);
        Name = "VehicleMaintenanceForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Araç Bakım Uygulaması";
        Load += VehicleMaintenanceForm_Load;
        ((System.ComponentModel.ISupportInitialize)dgwOldRecords).EndInit();
        ((System.ComponentModel.ISupportInitialize)maintenanceBindingSource).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label label1;
    private TextBox txtPlateNumber;
    private Button btnSearch;
    private Button btnAddVehicle;
    private Button btnAddMaintenance;
    private Button btnDeleteOldRecord;
    private DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
    private DataGridView dgwOldRecords;
    private BindingSource maintenanceBindingSource;
    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn maintenanceTypeDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn materialUnitPriceDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn taxRateDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn laborCostDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
}
