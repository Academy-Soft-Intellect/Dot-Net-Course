<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LibraryCollection.aspx.cs" Inherits="LibrarySystem.LibraryCollection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="menu">
                <a class="menu-item" href="Index.aspx">Home</a>
                <a class="menu-item" href="AddBook.aspx">Add new book</a>
                <a class="menu-item" href="Search.aspx">Search for a book</a>
                <a class="menu-item" href="LibraryCollection.aspx">See all books</a>
            </div>

            <div class="container">
                <asp:Repeater runat="server" ID="resultsRepeater">
                    <ItemTemplate>
                        <div class="repeater-item">
                            <span class="item-row">Title: <%# Eval("Title") %></span>
                            <span class="item-row">Author: <%# Eval("Author") %></span>
                            <span class="item-row">Price: <%# Eval("Price") %></span>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </form>
</body>
</html>
