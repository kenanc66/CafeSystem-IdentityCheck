using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstract.Entities
{

    public class Customer:IEntity
    {
        public int Id { get; set; }
        
        public string FirstName { get; internal set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationalityId { get; set; }

    }
}

