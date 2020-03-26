using BestGames_Libary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }

    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    void DisplayOrders()
    {
        BestGames_Libary.clsOrderCollection Orders = new BestGames_Libary.clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "o_id";
        lstOrderList.DataTextField = "o_information";
        //lstOrderList.DataTextField = "o_date";

        lstOrderList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["o_id"] = -1;

        Response.Redirect("Default.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 o_id;

        if(lstOrderList.SelectedIndex != -1)
        {
            o_id = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["o_id"] = o_id;
            Response.Redirect("OrderDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 o_id;

        if (lstOrderList.SelectedIndex != -1)
        {
            o_id = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["o_id"] = o_id;
            Response.Redirect("Default.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();

        Orders.ReportByOrderInformation(txtFilter.Text);

        lstOrderList.DataSource = Orders.OrderList;

        lstOrderList.DataValueField = "o_id";
        lstOrderList.DataTextField = "o_information";
        lstOrderList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();

    
        Orders.ReportByOrderInformation("");
        txtFilter.Text = "";

        lstOrderList.DataSource = Orders.OrderList;

        lstOrderList.DataValueField = "o_id";
        lstOrderList.DataTextField = "o_information";
        lstOrderList.DataBind();
    }
}