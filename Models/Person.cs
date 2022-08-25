using System;
using System.Collections.Generic;

namespace EleraSoftwareProject.Models
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string? PersonName { get; set; }
        public string? PersonSurname { get; set; }
        public int? CompanyId { get; set; }
        public string? Phone { get; set; }
        public string? MobilePhone { get; set; }
        public string? Email { get; set; }

        public virtual Company? Company { get; set; }
    }
}
