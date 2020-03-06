using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BestGames_Libary;

public partial class userViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer aCustomer = new clsCustomer();
        aCustomer = (clsCustomer)Session["aCustomer"];
        aCustomer.encryptPass();
        Response.Write(aCustomer.toString());
    }
}