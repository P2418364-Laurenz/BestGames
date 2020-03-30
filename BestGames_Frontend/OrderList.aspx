<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server"  style="z-index: 1; left: 95px; top: 100px; position: absolute; width: 578px; height: 392px"></asp:ListBox>
        
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 228px; top: 519px; position: absolute; height: 41px;" Text="Edit" Font-Bold="True" Width="76px" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 111px; top: 512px; position: absolute; height: 48px;" Text="Add" Font-Bold="True" Width="76px" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 346px; top: 522px; position: absolute; width: 109px; height: 45px;" Text="Delete" Font-Bold="True" />
       
            <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 102px; top: 865px; position: absolute; height: 19px;"></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 94px; top: 664px; position: absolute; " Text="Filter the Order Information"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 97px; top: 720px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 102px; top: 786px; position: absolute; height: 49px; width: 102px; right: 1148px;" Text="Apply" Font-Bold="True" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 227px; top: 790px; position: absolute; width: 99px; height: 43px;" Text="Clear" Font-Bold="True" />


        </div>
    </form>
</body>
</html>
