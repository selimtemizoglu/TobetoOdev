using System;
namespace Interfaces
{
	public interface ICustomerDal
	{
		void Add();
		void Update();
		void Delete();
	}

    class SqlServerCustomerDal : ICustomerDal
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("Sql added");
        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("Sqp updated");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("Oracle added");
        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}

