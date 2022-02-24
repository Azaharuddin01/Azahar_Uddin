using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azahar_Uddin.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email_Id { get; set; }
        public long Mobile_No { get; set; }
        public Location Location { get; set; }

    }
}
