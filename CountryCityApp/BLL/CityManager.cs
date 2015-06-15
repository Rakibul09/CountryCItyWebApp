using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using CountryCityApp.DAL;
using CountryCityApp.DAL.DAO;

namespace CountryCityApp.BLL
{
    public class CityManager
    {
        CityGateway cityGateway=new CityGateway();

        public string Save(City city)
        {
            if (city.Name == string.Empty)
            {
                return "City name is missing";
            }
            else if (city.About == string.Empty)
            {
                return "About City is missing";
            }
            else if (city.Population.ToString() == "")
            {
                return "No of Dewellers is missing";
            }

            else if (city.Location == string.Empty)
            {
                return "City Location is missing";
            }
            else if (city.Weather == string.Empty)
            {
                return "ciry weather is miising";
            }

            else
            {
                int value = cityGateway.Save(city);

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

        public DataSet GetCityDetailsByCountry(string name)
        {
            return cityGateway.GetCityDetailsByCountryNameSearch(name);
        }
        public DataSet GetCityDetails(string name)
        {
            return cityGateway.GetCityDetailsBySearch(name);
        }

        public List<PartialClass> GetCityForGridView()
        {
            return cityGateway.GetCityForGridView();
        }

        public List<PartialCity> GetCityDetails()
        {
            return cityGateway.GetCityDetails();
        }

        public List<PartialCity> GetCityDetailsByCityName(string name)
        {
            return cityGateway.GetCityDetailsByCityName(name);
        }
        public List<PartialCity> GetCityDetailsByCountryName(string name)
        {
            return cityGateway.GetCityDetailsByCountryName(name);
        } 
      
    }
}