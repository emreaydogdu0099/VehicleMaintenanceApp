using VehicleMaintenanceApp.Models.Entities.Common;

namespace VehicleMaintenanceApp.Models.Entities;
public class Vehicle : BaseEntity
{
    public string PlateNumber { get; set; }

    public ICollection<Maintenance> Maintenances { get; set; }
}
