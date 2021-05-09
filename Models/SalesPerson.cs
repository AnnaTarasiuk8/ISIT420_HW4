using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISIT420_HW4_Tarasiuk_Gurskaia.Models
{
    public class SalesPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int StoreID { get; set; }


        public SalesPerson(int id, string firstname, string lastname, int age, int storeid)
        {
            ID = id;
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            StoreID = storeid;
        }
    }
}