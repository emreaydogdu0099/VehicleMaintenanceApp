using VehicleMaintenanceApp.Data;

namespace VehicleMaintenanceApp;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            context.Database.EnsureCreated();
        }

        ApplicationConfiguration.Initialize();
        Application.Run(new VehicleMaintenanceForm());
    }
}