<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CountryCityApp.UI.About" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="../reset.css" rel="stylesheet" />
     <link href="../style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
   
        <div class="wrapper">
    
        <header>
            <div class="banner">
                
            </div>
              <div class="logo">
                  
              </div>

        </header>
        <nav>
            <ul>
                <li> <a href="Country.aspx">Add Country</a> </li>
            
                <li> <a href="City.aspx">Add City</a> </li> 
                
                <li> <a href="CountryView.aspx">Country View</a> </li>
                
                <li><a href="CityView.aspx">City View</a> </li>
                
                <li><a href="About.aspx">Help</a></li>
           
                 </ul>
        </nav>
        <div class="container">
            
           <h1>About the Country City Web Apllication </h1>
            <p>This system is designed to store information about the country including total numbers of cities in</p>
            <p>it and the numbers of people there staying,about city weather ,where it is situated etc.</p>

        </div>
        <div class="footer">
            <h1>Design & Developed by Backbenchers Group............</h1>
            

        </div>
            </div>
    </form>
</body>
</html>
