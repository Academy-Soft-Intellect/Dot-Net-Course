<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchPage.aspx.cs" Inherits="Library2.SearchPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search</title>
    <link href="Styles/styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat="server" ID="homeBtn" CssClass="searchBtn" Text="Home" OnClick="homeBtn_Click" />
            <asp:Button runat="server" ID="addBookBtn" CssClass="searchBtn" Text="Add a book" OnClick="addBookBtn_Click" />

            <h3>Search by title</h3>


            <asp:Label ID="titleSearchLabel" runat="server" Text="Title:" />
            <asp:TextBox ID="titleTxtBox" runat="server" />
            <asp:Button runat="server" ID="searchBtn" CssClass="searchBtn" Text="Search" OnClick="searchBtn_Click" />
            <br />
            <asp:Label ID="noResults" runat="server" Visible="false" Text="No Results" ForeColor="Red" />

            <asp:Repeater runat="server" ID="resultsRepeater">
                <ItemTemplate>
                    <table style="margin-top:20px; border: 1px dashed black;">
                        <tr>
                            <td class="resultsTd left">
                                <asp:Label ID="titleLabel" runat="server" Text="Title: " /></td>
                            <td class="resultsTd right">
                                <asp:Label ID="resultTitleLabel" runat="server" Text='<%# Eval("Title") %>'/></td>
                        </tr>
                        <tr>
                            <td class="resultsTd left">
                                <asp:Label ID="authorLabel" runat="server" Text="Author: " /></td>
                            <td class="resultsTd right">
                                <asp:Label ID="authorResultLabel" runat="server" Text='<%# Eval("Author") %>'/></td>
                        </tr>
                        <tr>
                            <td class="resultsTd left">
                                <asp:Label ID="genreLabel" runat="server" Text="Genre: " /></td>
                            <td class="resultsTd right">
                                <asp:Label ID="genreResultLabel" runat="server" Text='<%# Eval("Genre") %>'/></td>
                        </tr>
                        <tr>
                            <td class="resultsTd left">
                                <asp:Label ID="priceLabel" runat="server" Text="Price: " /></td>
                            <td class="resultsTd right">
                                <asp:Label ID="priceResultLabel" runat="server" Text='<%# Eval("Price") %>' /></td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
