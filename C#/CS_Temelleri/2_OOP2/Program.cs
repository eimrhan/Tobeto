using _2_OOP2;

// class örneği oluşturma (Instance)
Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 1;
product1.Name = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 10;

Product product2 = new Product
{
    Id = 2,
    CategoryId = 1,
    Name = "Sandalye",
    UnitPrice = 300,
    UnitsInStock = 15,
};

Product[] products = new Product[] { product1, product2 };

foreach (Product product in products)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.UnitPrice);
}


ProductManager productManager = new ProductManager();
productManager.Add(product1);
productManager.Add(product2);
// classdan türetilmiş nesne prop olarak gönderildi. (Encapsulation)