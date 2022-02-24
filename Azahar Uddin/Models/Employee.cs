using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Azahar_Uddin.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name ="Employee Name")]
        public string Name { get; set; }

        [Display(Name = "Employee Email Address")]
        public string Email { get; set; }

        [Display(Name = "Employee Mobile Number")]
        public long Mobile { get; set; }

        [Display(Name = "Employee Address")]
        public string Address { get; set; }

    }
}
