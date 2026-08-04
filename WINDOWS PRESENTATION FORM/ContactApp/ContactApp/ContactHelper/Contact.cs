using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.ContactHelper
{
    public class Contact
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        [NotNull,MaxLength(50)]
        public string Email { get; set; }

        [NotNull,MaxLength(50)]
        public string First_Name { get; set; }
        [MaxLength(50)]
        public string Last_Name { get ; set; }

        [NotNull]
        public string PhoneNumber { get; set; }

        //public override string ToString()
        //{
        //    return $"{Id}-{First_Name}-{Email}-{PhoneNumber}";
        //}


    }
}
