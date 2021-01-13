using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFramework.Demo
{
    [Table("Employee")]
    internal class Employee
    {
       
        public int Id { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        [Column("home_phone")]
        public string Homephone { get; set; }
        [Column("cell_phone")]
        public string Cellphone { get; set; }

    }
}
