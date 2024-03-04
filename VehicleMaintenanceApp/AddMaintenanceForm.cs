using System.Data;
using VehicleMaintenanceApp.Data;
using VehicleMaintenanceApp.Models.Entities;
using VehicleMaintenanceApp.Models.Enums;

namespace VehicleMaintenanceApp;
public partial class AddMaintenanceForm : Form
{
    private string _plateNumber;
    private BindingSource bindingSource;
    public AddMaintenanceForm(string plateNumber)
    {
        InitializeComponent();
        _plateNumber = plateNumber;
        bindingSource = new BindingSource();
        dgwNewRecords.DataSource = bindingSource;
    }
    private void AddMaintenanceForm_Load(object sender, EventArgs e)
    {
        FillUnitComboBox();
        FillTaxRateComboBox();
    }
    private async void btnAddMaintanence_Click(object sender, EventArgs e)
    {
        using AppDbContext context = new AppDbContext();

        if (!ValidateInput())
        {
            return;
        }

        UnitType selectedUnit = (UnitType)cmbUnit.SelectedItem;

        var maintenance = new Maintenance
        {
            VehicleId = context.Vehicles.First(v => v.PlateNumber == _plateNumber).Id,
            MaintenanceType = txtMaintenanceType.Text,
            Unit = selectedUnit,
            Quantity = Convert.ToDecimal(txtQuantity.Text),
            MaterialUnitPrice = Convert.ToDecimal(txtMaterialUnitPrice.Text),
            LaborCost = Convert.ToDecimal(txtLaborCost.Text),
            TaxRate = (TaxRate)cmbTaxRate.SelectedItem,
        };
        maintenance.CalculateTotalAmount();

        await context.Maintenances.AddAsync(maintenance);
        await context.SaveChangesAsync();

        if (bindingSource.DataSource == null)
        {
            bindingSource.DataSource = new List<Maintenance>();
        }

        var existingRecords = (List<Maintenance>)bindingSource.DataSource;
        existingRecords.Add(maintenance);
        bindingSource.DataSource = existingRecords;
        bindingSource.ResetBindings(false);


        ResetFormFields();
        MessageBox.Show("Bakım kaydı eklendi.");
    }
    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(txtMaintenanceType.Text))
        {
            MessageBox.Show("Lütfen yapılan işlemi girin.");
            return false;
        }
        if (string.IsNullOrWhiteSpace(txtQuantity.Text))
        {
            MessageBox.Show("Lütfen miktar bilgisi girin.");
            return false;
        }
        if (Convert.ToDecimal(txtQuantity.Text) < 0)
        {
            MessageBox.Show("Lütfen geçerli bir miktar girin.");
            return false;
        }
        if (string.IsNullOrWhiteSpace(txtMaterialUnitPrice.Text))
        {
            MessageBox.Show("Lütfen birim fiyatı girin.");
            return false;
        }
        if (!decimal.TryParse(txtMaterialUnitPrice.Text, out _))
        {
            MessageBox.Show("Malzeme birim fiyatı geçerli bir sayı değil.");
            return false;
        }
        if (Convert.ToDecimal(txtMaterialUnitPrice.Text) < 0)
        {
            MessageBox.Show("Lütfen geçerli bir fiyat girin.");
            return false;
        }
        if (string.IsNullOrWhiteSpace(txtLaborCost.Text))
        {
            MessageBox.Show("Lütfen işçilik ücreti girin. 0 (sıfır) girilebilir.");
            return false;
        }
        if (!decimal.TryParse(txtLaborCost.Text, out _))
        {
            MessageBox.Show("İşçilik ücreti geçerli bir sayı değil.");
            return false;
        }
        if (Convert.ToDecimal(txtLaborCost.Text) < 0)
        {
            MessageBox.Show("Lütfen geçerli bir işçilik ücreti girin.");
            return false;
        }
        return true;
    }
    private void ResetFormFields()
    {
        txtMaintenanceType.Text = "";
        cmbUnit.SelectedIndex = 0;
        txtQuantity.Text = "";
        txtMaterialUnitPrice.Text = "";
        txtLaborCost.Text = "";
        cmbTaxRate.SelectedIndex = 0;
    }
    private void FillUnitComboBox()
    {
        var unitTypes = Enum.GetValues(typeof(UnitType)).Cast<UnitType>().ToList();
        cmbUnit.DataSource = unitTypes;
        cmbUnit.SelectedIndex = 0;
        cmbUpdatedUnit.DataSource = unitTypes;
    }
    private void FillTaxRateComboBox()
    {
        var taxRateTypes = Enum.GetValues(typeof(TaxRate)).Cast<TaxRate>().ToList();
        cmbTaxRate.DataSource = taxRateTypes;
        cmbTaxRate.SelectedIndex = 0;
        cmbUpdatedTaxRate.DataSource = taxRateTypes;
    }

    private void dgwNewRecords_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        var row = dgwNewRecords.CurrentRow;
        if (row != null)
        {
            txtUpdatedMaintenanceType.Text = row.Cells[2].Value.ToString(); 
            cmbUpdatedUnit.SelectedItem = row.Cells[3].Value;
            txtUpdatedQuantity.Text = row.Cells[4].Value.ToString();
            txtUpdatedMaterialUnitPrice.Text = row.Cells[5].Value.ToString();
            txtUpdatedLaborCost.Text = row.Cells[6].Value.ToString();
            cmbUpdatedTaxRate.SelectedItem = row.Cells[7].Value;
        }
    }
}
