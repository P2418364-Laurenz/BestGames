<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffOrderItemEdit.aspx.cs" Inherits="StaffOrderItemEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 48px; top: 203px; position: absolute; height: 21px; width: 88px" Text="Product Key"></asp:Label>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 45px; top: 132px; position: absolute" Text="Order Item ID"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 48px; top: 96px; position: absolute" Text="Order ID"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 46px; top: 242px; position: absolute" Text="Order Quantity"></asp:Label>
        </div>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 48px; top: 167px; position: absolute" Text="Game Name"></asp:Label>
        <asp:TextBox ID="txtGame" runat="server" style="z-index: 1; left: 162px; top: 167px; position: absolute" ReadOnly="True"></asp:TextBox>
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 163px; top: 96px; position: absolute" ReadOnly="True"></asp:TextBox>
        <asp:TextBox ID="txtProductKey" runat="server" style="z-index: 1; left: 162px; top: 204px; position: absolute" ReadOnly="True"></asp:TextBox>
        <asp:TextBox ID="txtOrderItemID" runat="server" style="z-index: 1; left: 163px; top: 130px; position: absolute" ReadOnly="True"></asp:TextBox>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 161px; top: 241px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 167px; top: 292px; position: absolute; width: 118px;" Text="Update" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 30px; top: 291px; position: absolute; width: 116px" Text="Back" />
    </form>
</body>
</html>
