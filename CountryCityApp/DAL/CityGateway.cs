using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Configuration;
using CountryCityApp.DAL.DAO;

namespace CountryCityApp.DAL
{
    public class CityGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["CountryCityConString"].ConnectionString;



        public int Save(City city)
        {
            SqlConnection connection = new SqlConnection(connectionString);

           

            string query = "INSERT INTO City VALUES('" + city.Name + "','" + city.About + "','" + city.Population + "','"+city.Location+"','"+city.Weather+"','"+city.CountryId+"')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;

        }



        public List<City> GetAllCity()
        {
            List<City>cities=new List<City>();

            SqlConnection connection = new SqlConnection(connectionString);



            string query = "SELECT * FROM City ORDER BY ci_Name ASC";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                City city=new City();

                city.Id = int.Parse(reader["ci_id"].ToString());
                city.Name = reader["ci_Name"].ToString();
                city.About = reader["ci_About"].ToString();
                city.Population = int.Parse(reader["ci_NoofDwellers"].ToString());
                city.Location = reader["ci_Location"].ToString();
                city.Weather = reader["ci_Weather"].ToString();
                city.CountryId = int.Parse(reader["c_id"].ToString());

                cities.Add(city);
            }
            reader.Close();
            connection.Close();
            return cities;
        }
        public List<PartialClass> GetCityForGridView()
        {
            List<PartialClass> cities = new List<PartialClass>();

            SqlConnection connection = new SqlConnection(connectionString);


            int serial = 1;
            string query = "SELECT City.ci_Name,City.ci_NoofDwellers,Country.c_Name FROM City LEFT JOIN Country ON City.c_id=Country.c_id ORDER BY City.ci_Name ASC";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                PartialClass partialCity = new PartialClass();

                partialCity.Serial = serial;
                partialCity.Name = reader[0].ToString();
                partialCity.Dwellers = int.Parse(reader[1].ToString());
                partialCity.CountryName = reader[2].ToString();
                
                cities.Add(partialCity);
                serial++;
            }
            reader.Close();
            connection.Close();
            return cities;
        }
        public bool HasThisCityExists(string cityname)
        {
            bool cityexists = false;

            SqlConnection connection=new SqlConnection(connectionString);

            string query = "SELECT ci_Name FROM City WHERE ci_Name='"+cityname+"'";

            SqlCommand command=new SqlCommand(query,connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                cityexists = true;
                break;
            }
            reader.Close();
            connection.Close();
            return cityexists;
        }



        public DataSet GetCityDetailsBySearch(string name)
        {
            SqlConnection connection = new SqlConnection(connectionString);



            string query = "SELECT ci.ci_Name,ci.ci_About,ci.ci_NoofDewellers,ci.ci_Location,ci.ci_Weather,c.c_Name,c.c_About FROM City as ci join Country as c on ci.c_Id=c.c_Id";

            if (name != "WHERE ci.c_Name='" + name + "%'")
            {
                query +="";
            }
            query += "ORDER BY ci.c_Name ASC";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            DataSet ds = new DataSet();



            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(ds);
            adapter.Dispose();
            command.Dispose();
            connection.Close();



            return ds;
        }

        public DataSet GetCityDetailsByCountryNameSearch(string name)
        {
            SqlConnection connection = new SqlConnection(connectionString);



            string query = "SELECT ci.ci_Name,ci.ci_About,ci.ci_NoofDewellers,ci.ci_Location,ci.ci_Weather,c.c_Name,c.c_About FROM City as ci join Country as c on ci.c_Id=c.c_Id";

            if (name != "WHERE ci.c_Name='" + name + "%'")
            {
                query += "";
            }
            query += "ORDER BY ci.c_Name ASC";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);



            DataSet ds = new DataSet();



            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(ds);
            adapter.Dispose();
            command.Dispose();
            connection.Close();



            return ds;   
        }
        public List<PartialCity> GetCityDetails()
        {
            int cityId = 0;

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT City.ci_Name,City.ci_About,City.ci_NoofDwellers,CIty.ci_Location,City.ci_Weather,Country.c_Name,Country.c_About FROM Country INNER JOIN City ON Country.c_Id=City.c_Id ";
            // = "SELECT COUNT(ci_Name) FROM City WHERE c_Id = "+cityId+"";

            SqlCommand command = new SqlCommand(query, connection);

            List<PartialCity> cityList = new List<PartialCity>();
            int serial = 1;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PartialCity aCity = new PartialCity();

                aCity.Serial = serial;
                aCity.Name = reader[0].ToString();
                aCity.About = reader[1].ToString();
                aCity.NoofDwellers = Convert.ToInt32(reader[2].ToString());
                aCity.Location = reader[3].ToString();
                aCity.Weather = reader[4].ToString();
                aCity.CountryName = reader[5].ToString();
                aCity.CountryAbout = reader[6].ToString();
                cityList.Add(aCity);

                serial++;
            }
            reader.Close();
            connection.Close();

            return cityList;
        }
        public List<PartialCity> GetCityDetailsByCityName(string name)
        {
            int cityId = 0;

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT City.ci_Name,City.ci_About,City.ci_NoofDwellers,City.ci_Location,City.ci_Weather,Country.c_Name,Country.c_About FROM Country INNER JOIN City ON Country.c_Id=City.c_Id WHERE City.ci_Name Like'"+name+"%'";
            

            SqlCommand command = new SqlCommand(query, connection);

            List<PartialCity> cityList = new List<PartialCity>();
            int serial = 1;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PartialCity aCity = new PartialCity();

                aCity.Serial = serial;
                aCity.Name = reader[0].ToString();
                aCity.About = reader[1].ToString();
                aCity.NoofDwellers = Convert.ToInt32(reader[2].ToString());
                aCity.Location = reader[3].ToString();
                aCity.Weather = reader[4].ToString();
                aCity.CountryName = reader[5].ToString();
                aCity.CountryAbout = reader[6].ToString();
                cityList.Add(aCity);

                serial++;
            }
            reader.Close();
            connection.Close();

            return cityList;
        }
        public List<PartialCity> GetCityDetailsByCountryName(string name)
        {
            int cityId = 0;

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT City.ci_Name,City.ci_About,City.ci_NoofDwellers,City.ci_Location,City.ci_Weather,Country.c_Name,Country.c_About FROM Country INNER JOIN City ON Country.c_Id=City.c_Id WHERE Country.c_Name Like'" + name + "%'";
            // = "SELECT COUNT(ci_Name) FROM City WHERE c_Id = "+cityId+"";

            SqlCommand command = new SqlCommand(query, connection);

            List<PartialCity> cityList = new List<PartialCity>();
            int serial = 1;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PartialCity aCity = new PartialCity();

                aCity.Serial = serial;
                aCity.Name = reader[0].ToString();
                aCity.About = reader[1].ToString();
                aCity.NoofDwellers = Convert.ToInt32(reader[2].ToString());
                aCity.Location = reader[3].ToString();
                aCity.Weather = reader[4].ToString();
                aCity.CountryName = reader[5].ToString();
                aCity.CountryAbout = reader[6].ToString();
                cityList.Add(aCity);

                serial++;
            }
            reader.Close();
            connection.Close();

            return cityList;
        }
    }
}