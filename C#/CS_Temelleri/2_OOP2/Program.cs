using _2_OOP2;

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


ProductManager productManager = new ProductManager();
productManager.Add(product1);
productManager.Add(product2);