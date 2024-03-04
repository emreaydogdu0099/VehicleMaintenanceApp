using Microsoft.EntityFrameworkCore;
using VehicleMaintenanceApp.Data;
using VehicleMaintenanceApp.Models.Entities;

namespace VehicleMaintenanceApp;

public partial class VehicleMaintenanceForm : Form
{
    public VehicleMaintenanceForm()
    {
        InitializeComponent();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            string plateNumber = txtPlateNumber.Text;

            // Plakanın veritabanında var olup olmadığını kontrol et
            bool isPlateExists = context.Vehicles.Any(v => v.PlateNumber == plateNumber);

            if (isPlateExists)
            {
                var maintenanceRecords = context.Maintenances
                    .Include(m => m.Vehicle)
                    .Where(m => m.Vehicle.PlateNumber == plateNumber)
                    .ToList();

                foreach (var maintenance in maintenanceRecords)
                {
                    maintenance.CalculateTotalAmount();
                }

                dgwOldRecords.DataSource = maintenanceRecords;
            }
            else
                MessageBox.Show("Araç veritabanında bulunamadı. Lütfen öncelikle Kaydet butonuna tıklayın.");
        }
    }

    private void txtPlateNumber_TextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtPlateNumber.Text))
            ButtonsEnabled();
    }
    private void VehicleMaintenanceForm_Load(object sender, EventArgs e)
    {
        ButtonsDisabled();
    }



    private void ButtonsDisabled()
    {
        btnAddVehicle.Enabled = false;
        btnSearch.Enabled = false;
        btnAddMaintenance.Enabled = false;
    }
    private void ButtonsEnabled()
    {
        btnAddVehicle.Enabled = true;
        btnSearch.Enabled = true;
        btnAddMaintenance.Enabled = true;
    }

    private async void btnAddVehicle_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            string plateNumber = txtPlateNumber.Text;

            // Plakanın veritabanında var olup olmadığını kontrol et
            bool isPlateExists = context.Vehicles.Any(v => v.PlateNumber == plateNumber);

            if (isPlateExists)
            {
                MessageBox.Show("Araç zaten veritabanında kayıtlıdır.");
                btnSearch_Click(sender, e);
            }
            else
            {
                await context.Vehicles.AddAsync(new() { PlateNumber = plateNumber });
                await context.SaveChangesAsync();
                MessageBox.Show("Araç veritabanına eklendi.");
            }
        }
    }

    private void btnAddMaintenance_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            string plateNumber = txtPlateNumber.Text;

            // Plakanın veritabanında var olup olmadığını kontrol et
            bool isPlateExists = context.Vehicles.Any(v => v.PlateNumber == plateNumber);

            if (isPlateExists)
            {
                AddMaintenanceForm form = new AddMaintenanceForm(plateNumber);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen öncelikle Kaydet butonu ile aracı veritabanına ekleyin.");
            }
        }

    }

    private void btnDeleteOldRecord_Click(object sender, EventArgs e)
    {
        if (dgwOldRecords.SelectedRows.Count > 0)
        {
            int selectedIndex = dgwOldRecords.SelectedRows[0].Index;
            var dataSource = (List<Maintenance>)dgwOldRecords.DataSource;
            Maintenance selectedMaintenance = dataSource[selectedIndex];

            DialogResult result = MessageBox.Show("Seçili kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (var context = new AppDbContext())
                {
                    context.Maintenances.Remove(selectedMaintenance);
                    context.SaveChanges();
                }
                dataSource.RemoveAt(selectedIndex);
                dgwOldRecords.DataSource = null;  
                dgwOldRecords.DataSource = dataSource;  
                MessageBox.Show("Kayıt başarıyla silindi.");
            }
        }
        else
        {
            MessageBox.Show("Lütfen silmek istediğiniz bir kayıt seçin.");
        }
    }
}
