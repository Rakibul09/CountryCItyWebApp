using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Web;

namespace CountryCityApp.DAL.DAO
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string About { get; set; }

        public int Population { get; set; }

        public string Weather { get; set; }

        public string Location { get; set; }

        public int CountryId { get; set; }
    }
}