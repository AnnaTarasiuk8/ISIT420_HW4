using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISIT420_HW4_Tarasiuk_Gurskaia.Models
{
    public class Store
    {
        public int ID  { get; set; }
   
        public string City { get; set; }
        public string State { get; set; }
        public int NumberEmployees { get; set; }

        public Store ( int id, string city, string state, int numberemployees)
        {
            ID = id;
            City = city;
            State = state;
            NumberEmployees = numberemployees;

        }

       

}
}