using BestGames_Libary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer customer = new clsCustomer();
        //get data from session
        customer = (clsCustomer)Session["customer"];
        //dispaly response
        Response.Write(customer.cusId);
    }
}