using System;
using Classes;


CustomerManager customerManager = new CustomerManager();

customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();

customer.City = "İstanbul";
customer.Id = 1;
customer.FirstName = "Yavuz Selim";
customer.LastName = "Temizoğlu";

Customer customer1 = new Customer
{
    Id = 2, City = "Ankara", FirstName = "Engin", LastName = "Demiroğ"
};

Console.WriteLine(customer1.FirstName);

Console.ReadLine();





