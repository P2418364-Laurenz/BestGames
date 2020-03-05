<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addUser.aspx.cs" Inherits="addUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BestGames - Add User</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="pageTitle" runat="server" Font-Bold="False" Font-Size="Large" Text="Sign-Up for an Account"></asp:Label>
        <br />
        <asp:Label ID="formTextName" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="inputName" runat="server"></asp:TextBox><br />
        <asp:Label ID="formTextEmail" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="inputEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="formTextPassword" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="inputPassword" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="inputSubmit" runat="server" Text="Submit" OnClick="inputSubmit_Click" />
    </form>
</body>
</html>