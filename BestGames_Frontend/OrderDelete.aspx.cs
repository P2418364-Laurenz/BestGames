using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BestGames_Libary;

public partial class OrderDelete : System.Web.UI.Page
{
    Int32 o_id;

    protected void Page_Load(object sender, EventArgs e)
    {
        o_id = Convert.ToInt32(Session["o_id"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(o_id);
        OrderBook.Delete();
        Response.Redirect("OrderList.aspx");



    }
}