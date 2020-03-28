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





        <p>
            &nbsp;</p>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 574px; top: 212px; position: absolute" Text="Edit" Font-Bold="True" Height="26px" Width="76px" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 575px; top: 142px; position: absolute" Text="Add" Font-Bold="True" Height="26px" Width="76px" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 574px; top: 276px; position: absolute" Text="Delete" Font-Bold="True" Height="26px" Width="76px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 108px; top: 547px; position: absolute; height: 19px;"></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 101px; top: 389px; position: absolute; right: 468px;" Text="Filter the Order Information"></asp:Label>
        <asp:ListBox ID="lstOrderList" runat="server" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged" style="z-index: 1; left: 105px; top: 197px; position: absolute; width: 268px; height: 131px"></asp:ListBox>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 324px; top: 391px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 99px; top: 443px; position: absolute; height: 26px; width: 76px; " Text="Apply" Font-Bold="True" Height="26px" Width="76px" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 200px; top: 444px; position: absolute; width: 75px;" Text="Clear" Font-Bold="True" Height="26px" Width="76px" />





    </form>
</body>
</html>
