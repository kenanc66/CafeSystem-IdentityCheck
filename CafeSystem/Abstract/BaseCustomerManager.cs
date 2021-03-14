using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstract.Abstract
{
    public abstract class BaseCustomerManager : ICustomerCheckService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("added to database "+customer.FirstName);
        }
    }
}
