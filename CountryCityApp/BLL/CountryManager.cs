using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using CountryCityApp.DAL;
using CountryCityApp.DAL.DAO;

namespace CountryCityApp.BLL
{
    public class CountryManager
    {
       CountryGateway countryGateway=new CountryGateway();
          
    
        public string Save(Country country)
        {
            if (country.Name == string.Empty)
            {
                return "Name is missing";
            }

            else if (country.About == string.Empty)
            {
                return "About is missing";
            }

            else if (countryGateway.HasThisCountryExists(country.Name))
            {
                return "U are not allowed to use same country name twice";
            }
               
            else
            {
                int value = countryGateway.Save(country);

                if (value > 0)
                {
                    return "Save Successfully";
                }
                else
                {
                    return "Operation Failed";
                }
            }
        }

        public List<Country> CountryList()
        {
            return countryGateway.GetAllCountry();
        }
        public List<Country> CountryListForGridView()
        {
            return countryGateway.GetAllCountryForGridView();
        }
        //public DataSet GetAllDetails(string name)
        //{
        //    countryGateway.GetCountryDetailsBySearch(name);
        //}

        //public DataSet GetAllDataSearchByName()
        //{
        //    return countryManager.GetAllDetails();
        //}

        public List<PartialCountry> GetCoutryDetails()
        {
            return countryGateway.GetCountryDetails();
        }

        public List<PartialCountry> GetCountryDetailsByName(string name)
        {
            return countryGateway.GetCountryDetailsByName(name);
        }
    }
}