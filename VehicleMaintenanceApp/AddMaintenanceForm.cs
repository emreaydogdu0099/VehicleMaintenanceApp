using System.ComponentModel;
using System.Data;
using VehicleMaintenanceApp.Data;
using VehicleMaintenanceApp.Models.Entities;
using VehicleMaintenanceApp.Models.Enums;

namespace VehicleMaintenanceApp;
public partial class AddMaintenanceForm : Form
{
    private string _plateNumber;
    private BindingList<Maintenance> maintenanceList;
    private BindingSource bindingSource;
    public AddMaintenanceForm(string plateNumber)
    {
        InitializeComponent();
        _plateNumber = plateNumber;

        maintenanceList = new BindingList<Maintenance>();
        bindingSource = new BindingSource(maintenanceList, null);
        dgwNewRecords.DataSource = bindingSource;
    }

    private void AddMaintenanceForm_Load(object sender, EventArgs e)
    {
        FillUnitComboBox();
        FillTaxRateComboBox();
        btnUpdate.Enabled = false;
        btnDeleteMaintanence.Enabled = false;
    }
    private async void btnAddMaintanence_Click(object sender, EventArgs e)
    {
        if (!ValidateInput(txtMaintenanceType, txtQuantity, txtMaterialUnitPrice, txtLaborCost))
        {
            return;
        }

        using AppDbContext context = new AppDbContext();
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

        RefreshDataGridView(maintenance);

        ResetFormFields();
        MessageBox.Show("Bakım kaydı eklendi.");
        UpdateTotalAmountLabel();
    }
    private async void btnUpdate_Click(object sender, EventArgs e)
    {
        if (!ValidateInput(txtUpdatedMaintenanceType, txtUpdatedQuantity, txtUpdatedMaterialUnitPrice, txtUpdatedLaborCost))
        {
            return;
        }
        var row = dgwNewRecords.CurrentRow;
        if (row != null)
        {
            Guid maintenanceId = Guid.Parse(row.Cells[0].Value.ToString());
            using AppDbContext context = new AppDbContext();
            var maintenanceToUpdate = await context.Maintenances.FindAsync(maintenanceId);

            maintenanceToUpdate.MaintenanceType = txtUpdatedMaintenanceType.Text;
            maintenanceToUpdate.Unit = (UnitType)cmbUpdatedUnit.SelectedItem;
            maintenanceToUpdate.Quantity = Convert.ToDecimal(txtUpdatedQuantity.Text);
            maintenanceToUpdate.MaterialUnitPrice = Convert.ToDecimal(txtUpdatedMaterialUnitPrice.Text);
            maintenanceToUpdate.LaborCost = Convert.ToDecimal(txtUpdatedLaborCost.Text);
            maintenanceToUpdate.TaxRate = (TaxRate)cmbUpdatedTaxRate.SelectedItem;
            maintenanceToUpdate.CalculateTotalAmount();

            await context.SaveChangesAsync();
            RefreshDataGridView(maintenanceToUpdate);
            ResetFormFields();
            MessageBox.Show("Bakım kaydı güncellendi.");
            UpdateTotalAmountLabel();
        }
    }
    private void btnDeleteMaintanence_Click(object sender, EventArgs e)
    {
        if (dgwNewRecords.SelectedRows.Count > 0)
        {
            int selectedIndex = dgwNewRecords.SelectedRows[0].Index;
            Maintenance selectedMaintenance = maintenanceList[selectedIndex];

            DialogResult result = MessageBox.Show("Seçili kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (var context = new AppDbContext())
                {
                    context.Maintenances.Remove(selectedMaintenance);
                    context.SaveChanges();
                }

                maintenanceList.RemoveAt(selectedIndex);
                MessageBox.Show("Kayıt başarıyla silindi.");
                UpdateTotalAmountLabel();
            }
        }
        else
        {
            MessageBox.Show("Lütfen silmek istediğiniz bir kayıt seçin.");
        }
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
            cmbUpdatedTaxRate.SelectedItem = row.Cells[6].Value;
            txtUpdatedLaborCost.Text = row.Cells[7].Value.ToString();
        }
    }

    private bool ValidateInput(TextBox maintainanceType, TextBox quantity, TextBox materialUnitPrice, TextBox laborCost)
    {
        if (string.IsNullOrWhiteSpace(maintainanceType.Text))
        {
            MessageBox.Show("Lütfen yapılan işlemi girin.");
            return false;
        }

        if (string.IsNullOrWhiteSpace(quantity.Text) || !decimal.TryParse(quantity.Text, out decimal quantityValue) || quantityValue < 0)
        {
            MessageBox.Show("Lütfen geçerli bir miktar girin.");
            return false;
        }

        if (string.IsNullOrWhiteSpace(materialUnitPrice.Text) || !decimal.TryParse(materialUnitPrice.Text, out decimal materialUnitPriceValue) || materialUnitPriceValue < 0)
        {
            MessageBox.Show("Lütfen geçerli bir birim fiyatı girin.");
            return false;
        }

        if (string.IsNullOrWhiteSpace(laborCost.Text) || !decimal.TryParse(laborCost.Text, out decimal laborCostValue) || laborCostValue < 0)
        {
            MessageBox.Show("Lütfen geçerli bir işçilik ücreti girin. 0 (sıfır) girilebilir.");
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

        var updatedUnitTypes = new List<UnitType>(unitTypes);
        cmbUpdatedUnit.DataSource = updatedUnitTypes;
    }

    private void FillTaxRateComboBox()
    {
        var taxRateTypes = Enum.GetValues(typeof(TaxRate)).Cast<TaxRate>().ToList();
        cmbTaxRate.DataSource = taxRateTypes;
        cmbTaxRate.SelectedIndex = 0;

        var updatedTaxRateTypes = new List<TaxRate>(taxRateTypes);
        cmbUpdatedTaxRate.DataSource = updatedTaxRateTypes;
    }

    private void RefreshDataGridView(Maintenance updatedMaintenance)
    {
        if (bindingSource.DataSource == null)
        {
            bindingSource.DataSource = new BindingList<Maintenance>();
        }

        var existingRecords = (BindingList<Maintenance>)bindingSource.DataSource;

        // Eşsiz kimlik (Id) ile kaydın mevcudiyetini kontrol et
        Maintenance existingRecord = existingRecords.FirstOrDefault(m => m.Id == updatedMaintenance.Id);

        if (existingRecord != null)
        {
            // Eğer kayıt bulunduysa güncelle
            int indexOfUpdatedRecord = existingRecords.IndexOf(existingRecord);
            existingRecords[indexOfUpdatedRecord] = updatedMaintenance;
            bindingSource.ResetBindings(false);
        }
        else
        {
            // Eğer kayıt bulunamadıysa ekle
            existingRecords.Add(updatedMaintenance);
            bindingSource.ResetBindings(false);
        }
    }
    private void UpdateTotalAmountLabel()
    {
        decimal totalAmount = CalculateTotalAmountFromDataGridView();
        lblTotalPrice.Text = $"Toplam Tutar: {totalAmount:N2}";
    }
    private decimal CalculateTotalAmountFromDataGridView()
    {
        decimal totalAmount = 0;
        foreach (DataGridViewRow row in dgwNewRecords.Rows)
        {
            decimal rowTotalAmount = Convert.ToDecimal(row.Cells[8].Value);
            totalAmount += rowTotalAmount;
        }
        return totalAmount;
    }
    private void dgwNewRecords_SelectionChanged(object sender, EventArgs e)
    {
        btnUpdate.Enabled = dgwNewRecords.SelectedRows.Count > 0;
        btnDeleteMaintanence.Enabled = dgwNewRecords.SelectedRows.Count > 0;
    }
}
