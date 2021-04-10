using System;
using System.Collections.Generic;
using System.Text;

namespace Ruotine.Domain.Entitys
{
    public class Company
    {

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Introduction { get; set; }

        public ICollection<Employee> Employees { get; set; }

    }

    
}
