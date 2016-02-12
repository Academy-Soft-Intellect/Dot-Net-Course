<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="LIbrarySystem.AddBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add new book</title>
    <link href="styles.css" rel="stylesheet" />
</head>
<body>
    <div class="navigation">
        <asp:HyperLink NavigateUrl="~/AddBook.aspx" runat="server" Text="Add new book" ToolTip="Adds new book to the collection of books" />
        <asp:HyperLink NavigateUrl="~/SearchBook.aspx" runat="server" Text="Search for a book" ToolTip="Searchs for a book in the collection of books" />
        <asp:HyperLink NavigateUrl="~/ListAllBooks.aspx" runat="server" Text="View all books" ToolTip="Displays all the books in the collection of books" />
    </div>
    <form id="form1" runat="server">
        <div>
            <h3>Enter the info for the book</h3>
            <div class="container">
                <div class="row">
                    <div class="col">
                        <asp:Label Text="Title:" runat="server" />
                    </div>
                    <div class="col">
                        <asp:TextBox runat="server" ID="titleTxtBox" />
                    </div>
                </div>

                <div class="row">
                    <div class="col">
                        <asp:Label Text="Author:" runat="server" />
                    </div>
                    <div class="col">
                        <asp:TextBox runat="server" ID="authorTxtBox" />
                    </div>
                </div>

                <div class="row">
                    <div class="col">
                        <asp:Label Text="Price:" runat="server" />
                    </div>
                    <div class="col">
                        <asp:TextBox runat="server" ID="priceTxtBox" TextMode="Number" />
                    </div>
                </div>
            </div>
            <br />
            <br />
            <asp:Label Text="" runat="server" ID="messageLabel" />
            <br />
            <br />
            <asp:Button Text="Add" runat="server" ID="addBtn" OnClick="addBtn_Click" />
        </div>
    </form>
</body>
</html>
