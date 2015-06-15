<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryView.aspx.cs" Inherits="CountryCityApp.UI.CountryView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../reset.css" rel="stylesheet"/>
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
             
             <table>
                 <caption>Search Countries <br/> <br/>

                 </caption>
                
                <tr>
                    <td><asp:Label runat="server" ID="Label1">Name:</asp:Label></td>
                    <td><asp:TextBox runat="server" ID="SearchCountryTextBox" Width="159px"></asp:TextBox> </td> 
                    <td><asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" /></td>
                </tr>
                
               

            </table>
             <br/>
             <br/>
             <div>
                 <asp:GridView ID="countryDetailsGridView" runat="server" Width="575px" AllowPaging="True"></asp:GridView>
             </div>
    </div>
        
         <div class="footer">
            <h1>Design & Developed by Backbenchers Group............</h1>
            

        </div>
        </div>

    </form>
   
</body>
</html>
