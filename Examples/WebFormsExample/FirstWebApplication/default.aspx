<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FirstWebApplication._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test</title>
    <link href="styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:DropDownList ID="carModelDDL" runat="server" OnSelectedIndexChanged="carModelDDL_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="Please choose.." Value="test"/>
                <asp:ListItem Text="Mercedes" Value="Mercedes"/>
                <asp:ListItem Text="Other cars" Value="Other" />
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="sdasda" runat="server" ControlToValidate="carModelDDL" ErrorMessage="sss"></asp:RequiredFieldValidator>
        </div>
        <asp:TextBox ID="sdas" runat="server" TextMode="Password"></asp:TextBox>

        <asp:CheckBox runat="server" ID="fuelType" Text="IS a car" OnCheckedChanged="fuelType_CheckedChanged" AutoPostBack="true" />

        <asp:Button Text="Submit" CssClass="my-button" runat="server" Enabled="false" ID="submitBtn" OnClick="submitBtn_Click" />

    </form>
</body>
</html>
