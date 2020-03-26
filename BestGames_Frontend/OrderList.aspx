<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 245px; top: 380px; position: absolute" Text="Edit" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 99px; top: 380px; position: absolute" Text="Add" />
        </div>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 159px; top: 380px; position: absolute" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 108px; top: 547px; position: absolute; height: 19px;" Text="Label"></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 103px; top: 442px; position: absolute" Text="Enter a Order Information"></asp:Label>
        <asp:ListBox ID="lstOrderList" runat="server" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged" style="z-index: 1; left: 96px; top: 134px; position: absolute; height: 193px; width: 274px"></asp:ListBox>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 291px; top: 442px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 104px; top: 488px; position: absolute; height: 26px; width: 56px" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 178px; top: 486px; position: absolute" Text="Clear" />
    </form>
</body>
</html>
