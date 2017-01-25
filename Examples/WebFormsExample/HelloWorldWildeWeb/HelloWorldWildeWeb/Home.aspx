<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HelloWorldWildeWeb.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WWW</title>
</head>
<body style="background-image:url('')">
    <form runat="server">
        <br />
        <asp:HyperLink NavigateUrl="http://google.bg" runat="server" Text="Click me" ID="goToGooleLink" />
        <br />
        <asp:TextBox runat="server" ID="userNameTxtBox" Text="sdasda" TextMode="Number"/>
        <br />
        <asp:Button Text="text" runat="server" ID="submitButton" OnClick="submitButton_Click"></asp:Button>
        <br />
        <asp:LinkButton Text="text" runat="server" />
        <br />
        <asp:RadioButtonList runat="server" ID="selectRadioBtn">
            <asp:ListItem Text="text1" Value="FirstRadioBtn" Enabled="false" />
            <asp:ListItem Text="text2" Value="SecondRadioBtn" />
        </asp:RadioButtonList>
        <br />
        <asp:LinkButton Text="Link Button" OnClick="submitButton_Click" runat="server" />
        <br />
        <asp:Label Text="Label" ID="testLabel" ForeColor="YellowGreen" runat="server" />
    </form>
</body>
</html>
