<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecondPage.aspx.cs" Inherits="OtherEventsAndControls.SecondPage" %>

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
        <asp:ListBox runat="server" ID="dataListBox" >
        </asp:ListBox>
    </div>
    </form>
</body>
</html>
