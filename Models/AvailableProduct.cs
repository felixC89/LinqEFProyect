namespace LinqEFProyect.Models;

public partial class AvailableProduct
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Count { get; set; }

    public decimal? UnitP { get; set; }
}
