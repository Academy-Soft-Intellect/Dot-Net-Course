<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="LibrarySystem.AddBook" %>

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
                <label>Please enter book properties</label>
                <div class="add-book-line">
                    <label>Title: </label>
                    <asp:TextBox runat="server" ID="titleTextBox" />  
                </div>

                <div class="add-book-line">
                    <label>Author: </label>
                    <asp:TextBox runat="server" ID="authorTextBox" />  
                </div>

                <div class="add-book-line">
                    <label>Genre: </label>
                    <asp:TextBox runat="server" ID="genreTextBox" />  
                </div>

                <div class="add-book-line">
                    <label>Price: </label>
                    <asp:TextBox runat="server" ID="priceTextBox" TextMode="Number" step="0.01"/>  
                </div>

                <asp:Button Text="Add new book" runat="server" ID="addBookButton" OnClick="addBookButton_Click" />
            </div>

        </div>
    </form>
</body>
</html>
