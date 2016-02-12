<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchBook.aspx.cs" Inherits="LIbrarySystem.SearchBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search</title>
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
            <h3>Type a word to search in the library</h3>

            <asp:Label Text="Keyword: " runat="server" />
            <asp:TextBox runat="server" ID="keyWordTxtBox" />
            <br />
            <br />
            <asp:Button Text="Search" runat="server" ID="searchBtn" OnClick="searchBtn_Click" />
            <br />
            <br />
            <asp:Label Text="" runat="server" ID="messageLabel" />

            <asp:Repeater runat="server" ID="booksRepeater">
                <ItemTemplate>
                    <div class="book-container">
                        Title:
                    <asp:Label Text='<%# Eval("Title") %>' runat="server" />
                        <br />
                        Author:
                    <asp:Label Text='<%# Eval("Author") %>' runat="server" />
                        <br />
                        Price:
                    <asp:Label Text='<%# Eval("Price") %>' runat="server" />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
