
using Interfaces;
//InterfacesIntro();

///Demo();
///

ICustomerDal[] customerDals = new ICustomerDal[2]
{
    new SqlServerCustomerDal(),
    new OracleCustomerDal()
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}
Console.ReadLine();

static void InterfacesIntro()
{
    PersonManager manager = new PersonManager();
    Customer customer = new Customer
    {
        Id = 1,
        FirstName = "Yavuz Selim",
        LastName = "Temizoğlu",
        Adress = "İstanbul"
    };

    Student student = new Student
    {
        Id = 1,
        FirstName = "Nazlı Gül",
        LastName = "Temizoğlu",
        Departmant = "Student"
    };

    manager.Add(customer);
    manager.Add(student);
}

static void Demo()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new OracleCustomerDal());
}

interface IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

internal class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Adress { get; set; }

}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}
