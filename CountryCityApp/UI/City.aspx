<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="City.aspx.cs" Inherits="CountryCityApp.UI.City1" %>

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

                    <li><a href="City.aspx">Add City</a> </li>

                    <li><a href="CountryView.aspx">Country View</a> </li>

                    <li><a href="CityView.aspx">City View</a> </li>

                    <li><a href="About.aspx">Help</a></li>

                </ul>
            </nav>

            <div class="container">
                <table>
                    <tr>
                        <td>Name:</td>
                        <td>
                            <asp:TextBox runat="server" ID="cityNameTextBox" Width="200"></asp:TextBox>
                            <br />
                            <br />
                        </td>
                    </tr>

                    <tr>
                        <td>About:</td>
                        <td>
                            <asp:TextBox runat="server" ID="cityAboutTextBox" Width="200" Height="20" TextMode="MultiLine"></asp:TextBox>
                            <br />
                            <br />
                        </td>
                    </tr>

                    <tr>
                        <td>No of Dewellers:</td>
                        <td>
                            <asp:TextBox runat="server" ID="NoofDewellersTextBox" Width="200" Height="20" TextMode="MultiLine"></asp:TextBox>
                            <br />
                            <br />
                        </td>
                    </tr>

                    <tr>
                        <td>Location:</td>
                        <td>
                            <asp:TextBox runat="server" ID="locationTextBox" Width="200" Height="20" TextMode="MultiLine"></asp:TextBox>
                            <br />
                            <br />
                        </td>
                    </tr>

                    <tr>
                        <td>Weather:</td>
                        <td>
                            <asp:TextBox runat="server" ID="weatherTextBox" Width="200" Height="20" TextMode="MultiLine"></asp:TextBox>
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>Country</td>
                        <td>
                            <asp:DropDownList ID="countryDropdownList" runat="server"></asp:DropDownList>
                        </td>
                    </tr>
                    
                    <tr>
                        <td></td>
                        <td>
                            
                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" Font-Size="Medium" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="clearButton" runat="server" Text="Clear" OnClick="clearButton_Click" Font-Size="Medium" />
                        </td>
                    </tr>
                </table>
                <div class="CityList">
                    <asp:GridView ID="cityGridView" runat="server" OnSelectedIndexChanged="cityGridView_SelectedIndexChanged" Width="357px"></asp:GridView>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
