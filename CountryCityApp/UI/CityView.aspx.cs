using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityApp.BLL;

namespace CountryCityApp.UI
{
    public partial class CityView : System.Web.UI.Page
    {

        CountryManager countryManager=new CountryManager();

        CityManager cityManager=new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCityDetailsGridView();
                LoadCountryDropDownList();
                cityRadioButton.Checked = true;
            }
        }


       
        public void LoadCityDetailsGridView()
        {
            CityDetailsGridView.DataSource = cityManager.GetCityDetails();
            CityDetailsGridView.DataBind();
        }

        public void LoadCountryDropDownList()
        {
            countryDropDownList.DataSource = countryManager.CountryList();
            countryDropDownList.DataTextField = "Name";
            countryDropDownList.DataValueField = "Id";
            countryDropDownList.DataBind();
        }
        protected void countryDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string cityName = cityTextBox.Text;
            string countryName = countryDropDownList.SelectedItem.Text;
            if (cityRadioButton.Checked)
            {

                CityDetailsGridView.DataSource = cityManager.GetCityDetailsByCityName(cityName);
                CityDetailsGridView.DataBind();
            }
            else
            {


                CityDetailsGridView.DataSource = cityManager.GetCityDetailsByCountryName(countryName);
                CityDetailsGridView.DataBind();
            }
        }
    }
}