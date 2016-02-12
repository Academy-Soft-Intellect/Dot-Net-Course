<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListAllBooks.aspx.cs" Inherits="LIbrarySystem.ListAllBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>List of books</title>
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
            <h3>List of all the books in the library</h3>

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
