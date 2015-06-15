using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityApp.BLL;
using CountryCityApp.DAL.DAO;

namespace CountryCityApp.UI
{
    public partial class City1 : System.Web.UI.Page
    {
        CountryManager countryManager=new CountryManager();
        CityManager cityManager = new CityManager();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                countryDropdownList.DataSource = countryManager.CountryList();
                countryDropdownList.DataTextField = "Name";
                countryDropdownList.DataValueField = "Id";
                countryDropdownList.DataBind();

            }
            LoadCityGridView();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            City aCity = new City();

            aCity.Name = cityNameTextBox.Text;
            aCity.About = cityAboutTextBox.Text;
            aCity.Population = Convert.ToInt32(NoofDewellersTextBox.Text);
            aCity.Location = locationTextBox.Text;
            aCity.Weather = weatherTextBox.Text;
        
            aCity.CountryId = Convert.ToInt32(countryDropdownList.SelectedValue);
            cityManager.Save(aCity);
            LoadCityGridView();
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            cityNameTextBox.Text = null;
            cityAboutTextBox.Text = null;
            NoofDewellersTextBox.Text = null;
            locationTextBox.Text = null;
            weatherTextBox.Text = null;
        }

        protected void cityGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void LoadCityGridView()
        {
            cityGridView.DataSource = cityManager.GetCityForGridView();
            cityGridView.DataBind();
        }
    }
}