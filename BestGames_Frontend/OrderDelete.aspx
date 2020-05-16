<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDelete.aspx.cs" Inherits="OrderDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?</div>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 20px; top: 51px; position: absolute; height: 32px; width: 89px; right: 664px;" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 138px; top: 52px; position: absolute; height: 32px; width: 89px;" Text="No" OnClick="btnNo_Click" />
        </p>
    </form>
</body>
</html>
