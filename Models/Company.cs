using System;
using System.Collections.Generic;

namespace EleraSoftwareProject.Models
{
    public partial class Company
    {
        public Company()
        {
            Person = new HashSet<Person>();
        }

        public int CompanyId { get; set; }
        public string? CompanyName { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
