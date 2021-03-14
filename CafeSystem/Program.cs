using InterfaceAbstract.Abstract;
using InterfaceAbstract.adapters;
using InterfaceAbstract.Concrete;
using InterfaceAbstract.Entities;
using System;

namespace InterfaceAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StorbucksCustomerManager(new MernisServiceAdapter());

            customerManager.Save(new Customer{DateOfBirth=new DateTime(1996,07,18),FirstName="Kenan",LastName="Çiçek",NationalityId=11010078750 }  );
            Console.ReadLine();
        }
    }
}
