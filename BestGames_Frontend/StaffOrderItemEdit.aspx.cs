using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BestGames_Libary;

public partial class StaffOrderItemEdit : System.Web.UI.Page
{
    Int32 o_item_id;


    protected void Page_Load(object sender, EventArgs e)
    {


        o_item_id = Convert.ToInt32(Session["o_item_id"]);
        if (IsPostBack == false)
        {
            if (o_item_id != -1)
            {
                DisplayOrder();
            }
        }

    }




    void DisplayOrder()
    {
        clsOrderItemCollection OrderItemBook = new clsOrderItemCollection();
        OrderItemBook.ThisOrderItem.Find(o_item_id);

        txtOrderId.Text = OrderItemBook.ThisOrderItem.o_id.ToString();
        txtOrderItemID.Text = OrderItemBook.ThisOrderItem.o_item_id.ToString();
        txtGame.Text = OrderItemBook.ThisOrderItem.i_name;
        txtProductKey.Text = OrderItemBook.ThisOrderItem.p_key;
        txtQuantity.Text = OrderItemBook.ThisOrderItem.o_item_quantity.ToString();


    }




    protected void Button1_Click(object sender, EventArgs e)
    {
       

        clsOrderItem AnOrderItem = new clsOrderItem();

        int o_quantity = Convert.ToInt32(txtQuantity.Text);

        AnOrderItem.o_item_id = o_item_id;
        AnOrderItem.o_item_quantity = o_quantity;

        
        clsOrderItemCollection OrderList = new clsOrderItemCollection();


        OrderList.ThisOrderItem.Find(o_item_id);
        OrderList.ThisOrderItem = AnOrderItem;
        OrderList.UpdateOrderItemQuantity();
            

        Response.Redirect("StaffOrderSearch.aspx");

    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffOrderSearch.aspx");
    }
}