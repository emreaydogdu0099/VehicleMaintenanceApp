using VehicleMaintenanceApp.Models.Entities.Common;
using VehicleMaintenanceApp.Models.Enums;

namespace VehicleMaintenanceApp.Models.Entities;
public class Maintenance : BaseEntity
{
    public Guid VehicleId { get; set; }
    public string MaintenanceType { get; set; }
    public UnitType Unit { get; set; }
    public decimal Quantity { get; set; }
    public decimal MaterialUnitPrice { get; set; }
    public decimal LaborCost { get; set; }
    public TaxRate TaxRate { get; set; }
    public decimal TotalAmount { get; private set; }

    public virtual Vehicle Vehicle { get; set; }
    public void CalculateTotalAmount()
    {
        decimal materialCost = Quantity * MaterialUnitPrice;
        decimal laborCost = LaborCost;
        decimal taxRate = TaxRate switch
        {
            TaxRate.KDV8 => 0.08m,
            TaxRate.KDV18 => 0.18m,
            TaxRate.KDV20 => 0.20m,
            _ => 0.0m
        };
        decimal totalCostWithoutTax = materialCost + laborCost;
        TotalAmount = totalCostWithoutTax + (totalCostWithoutTax * taxRate);
    }
}
