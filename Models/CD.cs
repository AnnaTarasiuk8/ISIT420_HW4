using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISIT420_HW4_Tarasiuk_Gurskaia.Models
{
    public class CD
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string RecordCompany { get; set; }
        public int YearReleased { get; set; }
        public double Price { get; set; }

        public CD(int id, string name, string artist, string recordCompany, int yearReleased, double price)
        {
            ID = id;
            Name = name;
            Artist = artist;
            RecordCompany = recordCompany;
            YearReleased = yearReleased;
            Price = price;
        }
    }


}