namespace PandaMapTur.Domain.MunicipalitiesItems;

public class Municipalities
{
    public Guid Uuid { get; set; } = Guid.CreateVersion7(DateTime.UtcNow);
    public string? Name { get; set; }
    public string? ManagerName { get; set; }
    public string? Contact { get; set; }
    public string? CNPJ { get; set; }
    public string? InstitucionalEmail { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
