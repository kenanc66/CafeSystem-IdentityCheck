using InterfaceAbstract.Entities;
using MernisReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstract.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

        
    }
}
