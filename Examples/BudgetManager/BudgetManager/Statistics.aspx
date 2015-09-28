<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Statistics.aspx.cs" Inherits="BudgetManager.Statistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h1>Статистика:</h1>

        За седмица: 
        <asp:Label Text="" runat="server" id="weeklySum" />
        <br />
        <br />
        
        За месец: 
        <asp:Label Text="" runat="server" id="monthlySum" />
        <br />
        <br />

        
        За година: 
        <asp:Label Text="" runat="server" id="annualSum" />
        <br />
        <br />

        <asp:Button Text="Изчисли" runat="server" ID="calculateBtn" OnClick="calculateBtn_Click" />
    
    </div>
    </form>
</body>
</html>
