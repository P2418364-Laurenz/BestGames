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
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 114px; top: 159px; position: absolute" Text="Order Information"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 116px; top: 201px; position: absolute" Text="Order Date"></asp:Label>
        <asp:TextBox ID="txtID" runat="server" style="z-index: 1; left: 251px; top: 114px; position: absolute; width: 215px;"></asp:TextBox>
        <asp:TextBox ID="txtInfo" runat="server" style="z-index: 1; left: 250px; top: 160px; position: absolute; width: 215px;"></asp:TextBox>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 249px; top: 202px; position: absolute; width: 215px;"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 511px; top: 112px; position: absolute; width: 87px;" Text="Find" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 274px; top: 317px; position: absolute; width: 121px;" Text="Cancel" Height="26px" />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 127px; top: 315px; position: absolute; height: 26px; width: 121px;" Text="OK" Height="26px" />
        <asp:Label ID="lbl" runat="server" style="z-index: 1; left: 117px; top: 378px; position: absolute; bottom: 114px; width: 328px;"></asp:Label>





        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 247px; top: 246px; position: absolute" Text="Active" />





        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
