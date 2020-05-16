<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainPage.aspx.cs" Inherits="MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" style="z-index: 1; left: 211px; top: 155px; position: absolute" Text="Please select the option for the system"></asp:Label>
        </div>
        <asp:Button ID="btnCustomer" runat="server" style="z-index: 1; left: 164px; top: 206px; position: absolute; height: 64px; width: 157px;" Text="Customer" OnClick="btnCustomer_Click" BackColor="Aqua" BorderColor="#0033CC" />
        <asp:Button ID="btnStaff" runat="server" style="z-index: 1; left: 364px; top: 206px; position: absolute; height: 63px; width: 143px;" Text="Staff" OnClick="btnStaff_Click" BackColor="Aqua" BorderColor="#0033CC" />
    </form>
</body>
</html>
