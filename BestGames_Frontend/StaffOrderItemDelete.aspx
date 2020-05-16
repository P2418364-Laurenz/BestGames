<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffOrderItemDelete.aspx.cs" Inherits="StaffOrderDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 64px; top: 104px; position: absolute" Text="Are you sure you want to delete this order item? "></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 81px; top: 141px; position: absolute; width: 99px; height: 28px;" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 219px; top: 141px; position: absolute; width: 99px; height: 28px;" Text="No" OnClick="btnNo_Click" />
    </form>
</body>
</html>
