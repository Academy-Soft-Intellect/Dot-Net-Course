<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Library2.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button runat="server" ID="searchBtn" CssClass="searchBtn" Text="Search for a book" OnClick="searchBtn_Click"/>
        <asp:Button runat="server" ID="addBookBtn" CssClass="searchBtn" Text="Add a book" OnClick="addBookBtn_Click"/>

        <h1>Books in the Library</h1>

        <asp:GridView runat="server" ID="booksGridView" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Title" HeaderText="Title" ItemStyle-Width="200" ItemStyle-HorizontalAlign="Center"/>
                <asp:BoundField DataField="Author" HeaderText="Author" ItemStyle-Width="200" ItemStyle-HorizontalAlign="Center"/>
                <asp:BoundField DataField="Genre" HeaderText="Genre" ItemStyle-Width="200" ItemStyle-HorizontalAlign="Center"/>
                <asp:BoundField DataField="Price" HeaderText="Price" ItemStyle-Width="200" ItemStyle-HorizontalAlign="Center"/>
                <asp:TemplateField HeaderText="Delete" ItemStyle-Width="200" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="btnDelete" Text="Delete this book" OnClick="btnDelete_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

    </div>
    </form>
</body>
</html>
