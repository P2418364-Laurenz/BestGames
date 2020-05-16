<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerOrderAdd.aspx.cs" Inherits="CustomerOrderAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Label" Visible="False"></asp:Label>
            <asp:ListBox ID="lstCartList" runat="server" style="z-index: 1; left: 65px; top: 80px; position: absolute; height: 177px; width: 689px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 205px; top: 286px; position: absolute; width: 117px;" Text="Add Order" OnClick="btnAdd_Click" />
            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" style="z-index: 1; left: 82px; top: 285px; position: absolute; width: 106px; right: 848px;" Text="Back" />
        </div>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 370px; top: 291px; position: absolute"></asp:Label>
    </form>
</body>
</html>
