using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcEmp.Models
{
    public class Employee
    {

        public int ID { get; set; }
        [Required(ErrorMessage ="Must Input")]
        public string Name { get; set; }
        [Range(18,60)]
        public int Age { get; set; }
        public string Department { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}