<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server"  style="z-index: 1; left: 95px; top: 100px; position: absolute; width: 598px; height: 215px" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged"></asp:ListBox>
        
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 750px; top: 176px; position: absolute; height: 36px; right: 95px; width: 107px;" Text="Edit" Font-Bold="True" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 748px; top: 111px; position: absolute; height: 36px; width: 107px;" Text="Add" Font-Bold="True" Width="107px" Height="36px" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 751px; top: 240px; position: absolute; width: 107px; height: 36px;" Text="Delete" Font-Bold="True" />
       
            <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 98px; top: 318px; position: absolute; height: 19px;" ForeColor="Red"></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 100px; top: 377px; position: absolute; " Text="Filter the Order Information"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 98px; top: 414px; position: absolute; width: 259px;"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 97px; top: 454px; position: absolute; height: 36px; width: 107px; right: 748px; margin-right: 0px;" Text="Apply" Font-Bold="True" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 233px; top: 455px; position: absolute; width: 107px; height: 36px;" Text="Clear" Font-Bold="True" />


            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 99px; top: 75px; position: absolute" Text="Order List"></asp:Label>


        </div>
    </form>
</body>
</html>
