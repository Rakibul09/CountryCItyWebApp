using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityApp.DAL.DAO
{
    public class PartialCountry
    {
        public int Serial { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public int NoOfCities { get; set; }
        public int NoOfDwellers { get; set; }

    }
}