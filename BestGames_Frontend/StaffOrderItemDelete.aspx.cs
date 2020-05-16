using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BestGames_Libary;

public partial class StaffOrderDelete : System.Web.UI.Page
{
    Int32 o_item_id;
    Int32 o_id;


    protected void Page_Load(object sender, EventArgs e)
    {
        o_item_id = Convert.ToInt32(Session["o_item_id"]);
        o_id = Convert.ToInt32(Session["o_id"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderItemCollection OrderItemBook = new clsOrderItemCollection();
        OrderItemBook.ThisOrderItem.Find(o_item_id);
        OrderItemBook.Delete();
        Session["o_id"] = o_id;
        Response.Redirect("StaffOrderSearch.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffOrderSearch.aspx");
    }
}