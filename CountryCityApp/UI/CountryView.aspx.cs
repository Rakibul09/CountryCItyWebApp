using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityApp.BLL;

namespace CountryCityApp.UI
{
    public partial class CountryView : System.Web.UI.Page
    {
        CountryManager countryManager=new CountryManager();

        private string name = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            countryDetailsGridView.DataSource = countryManager.GetCoutryDetails();
            countryDetailsGridView.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            name = SearchCountryTextBox.Text;
            countryDetailsGridView.DataSource = countryManager.GetCountryDetailsByName(name);
            countryDetailsGridView.DataBind();
        }

       
    }
}