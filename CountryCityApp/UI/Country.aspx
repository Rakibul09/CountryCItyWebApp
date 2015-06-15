<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Country.aspx.cs" Inherits="CountryCityApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="../reset.css" rel="stylesheet" />
     <link href="../style.css" rel="stylesheet" />
     <script src="../Scripts/jquery-2.1.4.min.js"></script>

</head>
<body>
    
  <form id="countryForm" runat="server">
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
        <caption>Country Entry  <br/><br/> </caption>
        <tr>
            <td>Name:</td>
            <td><asp:TextBox runat="server" ID="CountryNameTextBox" Width="200"></asp:TextBox>  <br/></td>
        </tr>
       
        <tr>
            <td>About:</td>
            <td><asp:TextBox runat="server" ID="CountryAboutTextBox"  Width="200"  Height="20" TextMode="MultiLine" ></asp:TextBox> <br/>  <br/></td>
        </tr>
       
    </table>
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        
        <asp:Button runat="server" ID="SaveCountrybutton"  OnClick="SaveCountrybutton_OnClick" Text="Save"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button runat="server" ID="ClearButton" OnClick="ClearButton_OnClick" Text="Cancel"/>
        <br/>
        <asp:Label runat="server" ID="Label1"></asp:Label>
        <br/>
        <br/>
        

       <asp:GridView ID="countryGridView" runat="server" Width="450px">
       </asp:GridView>
        
        
    </div>
   
   
      <div class="footer">
            <p>Design & Developed by Backbenchers Group............</p>
        </div>
       </div>
    </form>
    
    <script src="../Scripts/ckeditor/ckeditor.js"></script>
    <script src="../Scripts/jquery-2.1.4.js"></script>
</body>
</html>
