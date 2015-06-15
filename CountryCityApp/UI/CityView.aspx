<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityView.aspx.cs" Inherits="CountryCityApp.UI.CityView" %>

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
                    <li><a href="Country.aspx">Add Country</a> </li>

                    <li><a href="City1.aspx">Add City</a> </li>

                    <li><a href="CountryView.aspx">Country View</a> </li>

                    <li><a href="CityView.aspx">City View</a> </li>

                    <li><a href="About.aspx">Help</a></li>

                </ul>
            </nav>

            <div class="container">

                <h1>Search Criteria:</h1>
                <table>
                    <tr>
                        <td>
                            <asp:RadioButton ID="cityRadioButton" runat="server" Text="City:" GroupName="SearchRadioButton" /></td>
                        <td>
                            <asp:TextBox ID="cityTextBox" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButton ID="countryRadioButton" runat="server" Text="Country" GroupName="SearchRadioButton" /></td>
                        <td>
                            <asp:DropDownList ID="countryDropDownList" runat="server" OnSelectedIndexChanged="countryDropDownList_SelectedIndexChanged"></asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" /></td>
                    </tr>
                </table>

                <br />
                <div>
                    <asp:GridView ID="CityDetailsGridView" runat="server" Width="788px" AllowPaging="True"></asp:GridView>
                </div>
            </div>
            <div class="footer">
                <h1>Design & Developed by Backbenchers Group............</h1>


            </div>


        </div>
    </form>
</body>
</html>
