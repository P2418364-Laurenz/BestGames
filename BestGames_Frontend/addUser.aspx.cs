using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BestGames_Libary;

public partial class addUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void inputSubmit_Click(object sender, EventArgs e)
    {
        clsCustomer aCustomer = new clsCustomer();
        aCustomer.cusName = inputName.Text;
        aCustomer.cusEmail = inputEmail.Text;
        aCustomer.cusPassword = inputPassword.Text;
        Session["aCustomer"] = aCustomer;
        Response.Redirect("userViewer.aspx");
    }
}
