<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OtherEventsAndControls.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="top-menu">
            <asp:HyperLink Text="Home" runat="server" NavigateUrl="~/Home.aspx"></asp:HyperLink>
            <asp:HyperLink Text="Second page" runat="server" NavigateUrl="~/SecondPage.aspx"></asp:HyperLink>
        </div>
    <div>
        <asp:DropDownList runat="server" ID="toggleActiveTxtBox" OnSelectedIndexChanged="toggleActiveTxtBox_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem Text="" Value=""/>
            <asp:ListItem Text="Active" Value="Active"/>
            <asp:ListItem Text="Inactive" Value="Inactive"/>
        </asp:DropDownList>
        <br />
        <br />
        <asp:TextBox runat="server" ID="plainTxtBox" Enabled="false"/>
        <br />
        <br />
        <asp:Button Text="Submit" runat="server" id="submitButton" OnClick="submitButton_Click"/>
        <br />
        <br />
        <asp:Label Text="" ID="indicateLabel" runat="server" />
    </div>
    </form>
</body>
</html>
