// See https://aka.ms/new-console-template for more information
using LinqEFProyect.Models;

Console.WriteLine("Hello, World!");
using (var contex = new ProductsContext()) 
{
    IQueryable<AvailableProduct?> Prod = (
        from item in contex.AvailableProducts
        where item.Count < 500
        orderby item.Name
        select item).Distinct();

    Console.WriteLine("Los productos menores de 500 unidades");

    foreach (var producto in Prod)
    {
        Console.WriteLine("{0} -> {1} unidades",producto?.Name, producto?.Count);
    }
   
}
Console.ReadKey();
