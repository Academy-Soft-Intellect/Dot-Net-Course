<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Our first web application</title>
    <link href="Styles/styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <a href="Default.aspx" class="nav-menu-button col-md-6">Home</a>
            <a href="About.aspx" class="nav-menu-button col-md-6">About</a>
        </div>
        <div class="container">
            <asp:Label ID="nameLabel" runat="server" Text="Username" ToolTip="Test"></asp:Label>
            <br />
            <asp:TextBox runat="server" Enabled="false" ID="nameTextBox" />
            <br />
            <asp:Button Text="Click" runat="server" ID="testButton" OnClick="testButton_Click" />
            <br />
            <asp:LinkButton Text="Link Button" runat="server" ID="linkBtn" OnClick="linkBtn_Click" />
            <br />
            <asp:TextBox runat="server" ID="pwdTextBox" TextMode="Password" />

            <asp:DropDownList runat="server" ID="ddlNew" OnSelectedIndexChanged="ddlNew_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="List Item 1" Value="11" />
                <asp:ListItem Text="Lsit Item 2" Value="12" />
            </asp:DropDownList>

            <asp:CheckBox Text="text" runat="server" />
        </div>
    </form>
</body>
</html>
