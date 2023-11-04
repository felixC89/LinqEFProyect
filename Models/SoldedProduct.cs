namespace LinqEFProyect.Models;

public partial class SoldedProduct
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int SoldCount { get; set; }
}
