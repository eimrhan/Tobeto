using _2_OOP3;

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNo = 1111;
customer1.TcNo = "11111111111";
customer1.Name = "Emirhan";
customer1.Surname = "Çelebi";

CorporateCustomer customer2 = new CorporateCustomer();
customer2.Id = 2;
customer2.CustomerNo = 1112;
customer2.VergiNo = "22222222222";
customer2.CompanyName = "celebi.dev";


Customer customer3 = new IndividualCustomer();
Customer customer4 = new CorporateCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);
customerManager.Add(customer3);
customerManager.Add(customer4);

// Inheritance'ların bir diğer artısı ise, iş classlarına (Manager) 
// parenttan türetilmiş (customer3, customer4) nesneleri gönderebiliriz.
// bunun için CustomerManager içinde tüm child classlar için metot oluşturmaya gerek yok.

// Hatırlatma: burada (17,18.satırlar) base class (Customer) referans tutucudur,
// new ile türetilenler (childlar) referansın (adresin) kendisidir.