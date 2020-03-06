<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addUser.aspx.cs" Inherits="addUser" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BestGames - Add User</title>
    <style>
        body {font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;background:#efefef}
        .formText {padding-right:15px}
        #content {margin:auto;width:200px;padding:45px 80px;background:#fff;border:1px solid black;border-radius:3px}
        #inputSubmit {margin-top:10px}
        #errorDiv {font-size:12px}
    </style>
</head>
<body>
    <div id="content">
        <form id="form1" runat="server">
            <asp:Label ID="pageLogo" runat="server" Text="BestGames" Font-Bold="False" Font-Size="37px"></asp:Label><br />
            <asp:Label ID="pageTitle" runat="server" Font-Bold="False" Font-Size="Large" Text="Sign-Up for an Account"></asp:Label>
            <br />
            <div id="errorMsgDiv" runat="server" />
            <asp:Label ID="formTextName" runat="server" Text="Name:" CssClass="formText"></asp:Label><br />
            <asp:TextBox ID="inputName" runat="server"></asp:TextBox><br />
            <asp:Label ID="formTextEmail" runat="server" Text="Email:" CssClass="formText"></asp:Label><br />
            <asp:TextBox ID="inputEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="formTextPassword" runat="server" Text="Password:" CssClass="formText"></asp:Label><br />
            <asp:TextBox ID="inputPassword" TextMode="Password" runat="server"></asp:TextBox><br />
            <asp:Label ID="formTextPasswordRepeat" runat="server" Text="Repeat Password:" CssClass="formText"></asp:Label><br />
            <asp:TextBox ID="inputPasswordRepeat" TextMode="Password" runat="server"></asp:TextBox><br />
            <asp:Button ID="inputSubmit" runat="server" Text="Submit" OnClick="inputSubmit_Click" />
        </form>
    </div>
</body>
</html>