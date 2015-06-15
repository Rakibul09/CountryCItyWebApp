using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityApp.BLL;
using CountryCityApp.DAL;
using CountryCityApp.DAL.DAO;

namespace CountryCityApp
{
    public partial class Index : System.Web.UI.Page
    {
        CountryManager countryManager = new CountryManager();

        protected void Page_Load(object sender, EventArgs e)
        {

           
                countryGridView.DataSource = countryManager.CountryListForGridView();
                countryGridView.DataBind();
            



        }


        protected void ClearButton_OnClick(object sender, EventArgs e)
        {
           GetCountryTextBoxesClear();
        }

        protected void SaveCountrybutton_OnClick(object sender, EventArgs e)
        {
           Country country=new Country();

            country.Name = CountryNameTextBox.Text;
            country.About = CountryAboutTextBox.Text;

            string message = countryManager.Save(country);
            GetCountryTextBoxesClear();

            Label1.Text = message;


            //CountryGridView.DataSource = null;

            //CountryGridView.DataBind();
            
            countryGridView.DataSource = countryManager.CountryList();

            countryGridView.DataBind();


        }

        public void GetCountryTextBoxesClear()
        {
            CountryNameTextBox.Text = "";
            CountryAboutTextBox.Text = "";   
        }



      
    } 
    
}