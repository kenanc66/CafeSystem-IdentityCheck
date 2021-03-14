using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstract.Abstract
{
    public interface ICustomerCheckService
    {
        void Save(Customer customer);
    }
}
