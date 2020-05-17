<%@ Page Language="C#" AutoEventWireup="true" CodeFile="aCustomer.aspx.cs" Inherits="aCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="txtTitle" runat="server" Text="For new users only inputs name, password and email."></asp:Label>
            <br />
            <br />
            <asp:Label ID="txtDesc" runat="server" Text="ID and Date created are read-only and cannot be edited. Any input to those fields will be lost"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblCusId" runat="server" Text="ID : "></asp:Label>
            <asp:TextBox ID="txtCusId" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Text="Find" Height="21px" OnClick="btnFind_Click" />
            <br />
            <asp:Label ID="lblCusName" runat="server" Text="Name* : "></asp:Label>
            <asp:TextBox ID="txtCusName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCusPassword" runat="server" Text="Password* : "></asp:Label>
            <asp:TextBox ID="txtCusPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCusCreationDate" runat="server" Text="Date Created : "></asp:Label>
            <asp:TextBox ID="txtCusCreationDate" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCusEmail" runat="server" Text="Email* : "></asp:Label>
            <asp:TextBox ID="txtCusEmail" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="txtCusStatus" runat="server" Text="Active"/>
            <br />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnOK" runat="server" Text="Edit / Create" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="cancel" OnClick="btnCancel_Click" />
            <br />
        </div>
    </form>
</body>
</html>
