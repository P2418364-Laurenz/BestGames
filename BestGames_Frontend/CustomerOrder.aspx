<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerOrder.aspx.cs" Inherits="CustomerOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 1018px; top: 157px; position: absolute" Text="Filter (Date)" OnClick="Button1_Click" />
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 1018px; top: 130px; position: absolute" Text="Filter Feature"></asp:Label>
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 122px; top: 94px; position: absolute; height: 182px; width: 830px"></asp:ListBox>
        </div>
        <asp:Button ID="btnView" runat="server" style="z-index: 1; left: 300px; top: 295px; position: absolute; width: 155px" Text="View Order Item" OnClick="btnView_Click1" />
        <asp:ListBox ID="lstOrderItemList" runat="server" style="z-index: 1; left: 122px; top: 387px; position: absolute; height: 166px; width: 823px; margin-right: 0px;"></asp:ListBox>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 1015px; top: 434px; position: absolute; height: 38px;" Text="Filter Feature"></asp:Label>
        <asp:Button ID="btnFilterPrice" runat="server" style="z-index: 1; left: 1013px; top: 456px; position: absolute" Text="Filter (Price)" OnClick="btnFilterPrice_Click" Enabled="False" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 125px; top: 355px; position: absolute" Text="Order Item Detail"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 145px; top: 1044px; position: absolute" Visible="False">Label5</asp:Label>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 257px; top: 584px; position: absolute; width: 545px; height: 44px;" Text="Back Home Page" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 124px; top: 70px; position: absolute" Text="Order Detail"></asp:Label>
        <p>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 123px; top: 295px; position: absolute; width: 154px;" Text="Add Order From Cart" OnClick="btnAdd_Click" />
            <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 503px; top: 300px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
