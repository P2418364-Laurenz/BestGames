<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>





        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 113px; top: 116px; position: absolute" Text="Order ID"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 111px; top: 176px; position: absolute" Text="Order Information"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 114px; top: 230px; position: absolute" Text="Order Date"></asp:Label>
        <asp:TextBox ID="txtID" runat="server" style="z-index: 1; left: 296px; top: 113px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtInfo" runat="server" style="z-index: 1; left: 296px; top: 174px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 297px; top: 230px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 471px; top: 109px; position: absolute" Text="Find" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 343px; top: 336px; position: absolute" Text="Cancel" Height="26px" Width="76px" />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 251px; top: 336px; position: absolute; height: 26px" Text="OK" Height="26px" Width="76px" />
        <asp:Label ID="lbl" runat="server" style="z-index: 1; left: 504px; top: 349px; position: absolute; bottom: 94px;"></asp:Label>





        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 358px; top: 285px; position: absolute" Text="Active" />





        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
