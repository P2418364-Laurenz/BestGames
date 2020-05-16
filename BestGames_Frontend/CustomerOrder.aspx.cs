using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BestGames_Libary;

public partial class CustomerOrder : System.Web.UI.Page
{
    Int32 cus_id;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        cus_id = Convert.ToInt32(Session["cus_id"]);
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {

        BestGames_Libary.clsOrderCollection Orders = new BestGames_Libary.clsOrderCollection();


        Orders.ReportByOrderCustomerID(cus_id);

        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "o_id";
        lstOrderList.DataTextField = "o_full_info";
        lstOrderList.DataBind();

       /* BestGames_Libary.clsOrderItemCollection OrderItems = new BestGames_Libary.clsOrderItemCollection();
        lstOrderItemList.DataSource = OrderItems.OrderItemList;
        lstOrderItemList.DataValueField = "o_item_id";
        lstOrderItemList.DataTextField = "o_full_info";
        lstOrderItemList.DataBind();
        */
    }




    protected void btnView_Click1(object sender, EventArgs e)
    {

        if (lstOrderList.SelectedIndex != -1)
        {
            Int32 o_id;
            o_id = Convert.ToInt32(lstOrderList.SelectedValue);



            clsOrderItemCollection OrderItems = new clsOrderItemCollection();

            OrderItems.ReportByOrderItemInformation(o_id);



            // BestGames_Libary.clsOrderItemCollection OrderItemss = new BestGames_Libary.clsOrderItemCollection();
            lstOrderItemList.DataSource = OrderItems.OrderItemList;
            lstOrderItemList.DataValueField = "o_item_id";
            lstOrderItemList.DataTextField = "o_full_info";
            lstOrderItemList.DataBind();
            Label5.Text = o_id.ToString();

            lblError.Text = "";
            btnFilterPrice.Enabled = true;

        }
        else
        {
            lblError.Text = "Please select item from the Order List to view";
        }


       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        lblError.Text = "";

        clsOrderCollection Orders = new clsOrderCollection();

        Orders.ReportByOrderDate(cus_id);

        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "o_id";
        lstOrderList.DataTextField = "o_full_info";
        lstOrderList.DataBind();
    }







    protected void btnFilterPrice_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        Int32 o_id = Convert.ToInt32(Label5.Text);

        clsOrderItemCollection OrderItems = new clsOrderItemCollection();


        OrderItems.ReportByOrderItemPrice(o_id);

        lstOrderItemList.DataSource = OrderItems.OrderItemList;

        lstOrderItemList.DataValueField = "o_item_id";
        lstOrderItemList.DataTextField = "o_full_info";
        lstOrderItemList.DataBind();




      

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("MainPage.aspx");
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {


        //o_id = Convert.ToInt32(lstOrderList.SelectedValue);
        Session["o_id"] = cus_id;
        Response.Redirect("CustomerOrderAdd.aspx");

    }
}