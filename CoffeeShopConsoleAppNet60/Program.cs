// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;

Console.WriteLine("Hello, World!");

List<Coffee> kaffeListe = new List<Coffee>();
kaffeListe.Add(new Latte(3));
kaffeListe.Add(new Cortado(6));
kaffeListe.Add(new BlackCoffee(5));

Console.WriteLine("Prices for (Latte/Cortado/Black)");
foreach (Coffee c in kaffeListe)
{
    Console.WriteLine(c.GetPrice());
}
Console.WriteLine("Strength for (Latte/Cortado/Black)");
foreach (Coffee c in kaffeListe)
{
    Console.WriteLine(c.Strength());
}