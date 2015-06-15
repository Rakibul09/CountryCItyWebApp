using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityApp.DAL.DAO
{
    public class PartialCity
    {
        public int Serial { set; get; }
        public string Name { get; set; }
        public string About { set; get; }
        public int NoofDwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public string CountryName { get; set; }
        public string CountryAbout { get; set; }
    }
}