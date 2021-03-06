﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteCustomer.aspx.cs" Inherits="DeleteCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="deleteLabelWarning" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
            <br />
            <asp:Label ID="getResponse" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" Text="No" />
            <br />
        </div>
    </form>
</body>
</html>
