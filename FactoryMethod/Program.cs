
using FactoryMethod;

Console.WriteLine("Factory Method ");

Console.Title = "Factory Method";

var factories = new List<DiscountFactory>
{
    new CountryDiscountFactory("BE"),
    new CodeDiscountFactory(Guid.NewGuid())
};

foreach (var fact in factories)
{
    var factory = fact.CreateDiscountServie();
    Console.WriteLine($"The percentage - {factory.DiscountPercentage} coming from - {factory}");
    Console.ReadKey();
}


