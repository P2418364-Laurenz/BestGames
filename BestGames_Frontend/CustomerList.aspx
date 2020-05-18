<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <br />
        <asp:Label ID="lblFilter" runat="server" Text="Enter an Email Address: "></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" Width="157px"></asp:TextBox>
            <br />
            <asp:Button ID="btnApplyFilter" runat="server" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
            <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" OnClick="btnClearFilter_Click" />
            <br />
            <br />
            
        </div><asp:ListBox ID="CustomerListBox" runat="server" Height="116px" Width="318px"></asp:ListBox>
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
