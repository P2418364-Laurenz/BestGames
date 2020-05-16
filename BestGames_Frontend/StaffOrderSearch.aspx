<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffOrderSearch.aspx.cs" Inherits="StaffOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnFilter_Game" runat="server" style="z-index: 1; left: 945px; top: 544px; position: absolute; width: 172px;" Text="Filter (Game Name)" OnClick="Button1_Click1" Enabled="False" />
            <asp:Button ID="btnFilterPrice" runat="server" style="z-index: 1; left: 945px; top: 595px; position: absolute" Text="Filter (Game Price)" OnClick="btnFilterPrice_Click" Width="172px" Enabled="False" />
            <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 97px; top: 848px; position: absolute" Text="Label" Visible="False"></asp:Label>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click2" style="z-index: 1; left: 249px; top: 675px; position: absolute; width: 471px; height: 39px;" Text="Back Home Page" />
            <asp:Label ID="lblLabel" runat="server" style="z-index: 1; left: 347px; top: 342px; position: absolute" ForeColor="Red"></asp:Label>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 132px; top: 89px; position: absolute" Text="Enter the Customer Order ID to search"></asp:Label>
        </div>
        <asp:TextBox ID="txtID" runat="server" style="z-index: 1; left: 216px; top: 132px; position: absolute; width: 218px;"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" style="z-index: 1; left: 482px; top: 129px; position: absolute; width: 90px" Text="Search" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 62px; top: 135px; position: absolute" Text="Order ID"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 61px; top: 248px; position: absolute; right: 565px" Text="Order Date"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; top: 284px; position: absolute; left: 61px" Text="Order Status"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 216px; top: 170px; position: absolute; width: 216px;" ReadOnly="True"></asp:TextBox>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 214px; top: 245px; position: absolute; width: 215px;" ReadOnly="True"></asp:TextBox>
        <asp:TextBox ID="txtOrderInfo" runat="server" style="z-index: 1; left: 215px; top: 207px; position: absolute; width: 214px;"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 61px; top: 209px; position: absolute" Text="Order Information"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 62px; top: 172px; position: absolute" Text="Customer ID"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 210px; top: 285px; position: absolute" Text="Active" />
        <asp:ListBox ID="lstOrderItemList" runat="server" style="z-index: 1; left: 60px; top: 439px; position: absolute; height: 205px; width: 830px; bottom: 38px;" OnSelectedIndexChanged="lstOrderItemList_SelectedIndexChanged"></asp:ListBox>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 64px; top: 410px; position: absolute" Text="Order Item List"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 944px; top: 445px; position: absolute; width: 172px" Text="Delete" Enabled="False" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 945px; top: 493px; position: absolute; width: 172px" Text="Edit" OnClick="btnEdit_Click" Enabled="False" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblErrorItem" runat="server" style="z-index: 1; left: 213px; top: 409px; position: absolute" ForeColor="Red"></asp:Label>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 186px; top: 339px; position: absolute; width: 127px" Text="Update" Enabled="False" />
        </p>
    </form>
</body>
</html>
