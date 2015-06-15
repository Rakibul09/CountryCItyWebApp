using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using CountryCityApp.DAL.DAO;

namespace CountryCityApp.DAL
{
    public class CountryGateway
    {
        public string connectionString = WebConfigurationManager.ConnectionStrings["CountryCityConString"].ConnectionString;

        public int Save(Country country)
        {
            SqlConnection connection=new SqlConnection(connectionString);

            
            connection.Open();
            string query = "INSERT INTO Country VALUES('"+country.Name+"','"+country.About+"')";

            SqlCommand command=new SqlCommand(query,connection);

            int rowsAffected=command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }

        public List<Country> GetAllCountry()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Country ORDER BY c_Name";
            SqlCommand command = new SqlCommand(query, connection);
            List<Country> countryList = new List<Country>();
            int serial = 1;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Country aCountry = new Country();

                aCountry.Id = Convert.ToInt16(reader["c_Id".ToString()]);
                aCountry.Name = reader["c_Name"].ToString();
                aCountry.About = reader["c_About"].ToString();
                countryList.Add(aCountry);

                serial++;
            }
            reader.Close();
            connection.Close();

            return countryList;
        }

        public List<Country> GetAllCountryForGridView()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Country ORDER BY c_Name";
            SqlCommand command = new SqlCommand(query, connection);
            List<Country> countryList = new List<Country>();
            int serial = 1;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Country aCountry = new Country();

                aCountry.Id = serial;
                aCountry.Name = reader["c_Name"].ToString();
                aCountry.About = reader["c_About"].ToString();
                countryList.Add(aCountry);

                serial++;
            }
            reader.Close();
            connection.Close();

            return countryList;
        }
        public List<PartialCountry> GetCountryDetails()
        {
            int cityId=0;
            
            SqlConnection connection = new SqlConnection(connectionString);
            
            string query = "SELECT Country.c_Name,Country.c_About,COUNT(City.ci_Name) AS Number_of_cities,SUM(City.ci_NoofDwellers) AS population FROM Country INNER JOIN City ON Country.c_Id=City.c_Id GROUP BY Country.c_Name,Country.c_About";
            // = "SELECT COUNT(ci_Name) FROM City WHERE c_Id = "+cityId+"";
            
            SqlCommand command = new SqlCommand(query, connection);
            
            List<PartialCountry> countryList = new List<PartialCountry>();
            int serial = 1;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PartialCountry aCountry = new PartialCountry();

                aCountry.Serial = serial;
                aCountry.Name = reader[0].ToString();
                aCountry.About = reader[1].ToString();
                aCountry.NoOfCities = Convert.ToInt32(reader[2].ToString());
                aCountry.NoOfDwellers = Convert.ToInt32(reader[3].ToString());
                countryList.Add(aCountry);

                serial++;
            }
            reader.Close();
            connection.Close();

            return countryList;
        }
        public List<PartialCountry> GetCountryDetailsByName(string name)
        {
            int cityId = 0;

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT Country.c_Name,Country.c_About,COUNT(City.ci_Name) AS Number_of_cities,SUM(City.ci_NoofDwellers) AS population FROM Country INNER JOIN City ON Country.c_Id=City.c_Id WHERE Country.c_Name like '" + name + "%' GROUP BY Country.c_Name,Country.c_About ";
            

            SqlCommand command = new SqlCommand(query, connection);

            List<PartialCountry> countryList = new List<PartialCountry>();
            int serial = 1;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PartialCountry aCountry = new PartialCountry();

                aCountry.Serial = serial;
                aCountry.Name = reader[0].ToString();
                aCountry.About = reader[1].ToString();
                aCountry.NoOfCities = Convert.ToInt32(reader[2].ToString());
                aCountry.NoOfDwellers = Convert.ToInt32(reader[3].ToString());
                countryList.Add(aCountry);

                serial++;
            }
            reader.Close();
            connection.Close();

            return countryList;
        }
       

         public bool HasThisCountryExists(string countryname)
         {
             bool countryexists = false;

             SqlConnection connection = new SqlConnection(connectionString);

             string query = "SELECT c_Name FROM Country WHERE c_Name='" + countryname + "'";

             connection.Open();
             SqlCommand command = new SqlCommand(query,connection);

             SqlDataReader reader = command.ExecuteReader();

             while (reader.Read())
             {
                 countryexists = true;
                 break;
             }
             reader.Close();
             connection.Close();
             return countryexists;
         }

    }
}