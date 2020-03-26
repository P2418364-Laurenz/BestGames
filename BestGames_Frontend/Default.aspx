<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 500px; top: 148px; position: absolute" Text="Find" />
            <asp:Button ID="btnEnter" runat="server" OnClick="btnEnter_Click" style="z-index: 1; left: 189px; top: 383px; position: absolute" Text="Enter" />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 115px; top: 383px; position: absolute; height: 26px" Text="OK" />
        </p>
        <asp:Label ID="lbl" runat="server" style="z-index: 1; left: 119px; top: 335px; position: absolute" Text="Label"></asp:Label>





        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 113px; top: 287px; position: absolute" Text="Active" />





    </form>
</body>
</html>
