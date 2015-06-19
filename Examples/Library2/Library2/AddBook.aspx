<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="Library2.AddBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat="server" ID="homeBtn" CssClass="searchBtn" Text="Home" OnClick="homeBtn_Click" />
            <asp:Button runat="server" ID="searchBtn" CssClass="searchBtn" Text="Search for a book" OnClick="searchBtn_Click" />
            <br />
            <br />
            <br />
            <br />

            <table>
                <tr>
                    <td>
                        <asp:Label ID="titleLabel" runat="server" Text="Title:" /></td>
                    <td>
                        <asp:TextBox ID="titleTxtBox" runat="server" /></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="authorLabel" runat="server" Text="Author:" /></td>
                    <td>
                        <asp:TextBox ID="authorTxtBox" runat="server" /></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="genreLabel" runat="server" Text="Genre:" /></td>
                    <td>
                        <asp:TextBox ID="genreTxtBox" runat="server" /></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="priceLabel" runat="server" Text="Price:" /></td>
                    <td>
                        <asp:TextBox ID="priceTxtBox" runat="server" /></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="priceErrorLabel" runat="server" Visible="false" ForeColor="Red"></asp:Label>

                    </td>
                </tr>
            </table>

            <asp:Button runat="server" ID="submitBtn" Text="Submit" OnClick="submitBtn_Click" />
        </div>
    </form>
</body>
</html>
