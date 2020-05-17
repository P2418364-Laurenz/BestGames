using BestGames_Libary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteCustomer : System.Web.UI.Page
{
    //var for the cusId record to be deleted from the database
    Int32 cusId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the id to be deleted from the session object
        cusId = Convert.ToInt32(Session["cusId"]);
        //display the 
        getResponse.Text = "User ID to delete: " + cusId;
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create the new isntance of the customer collection
        clsCustomerCollection collection = new clsCustomerCollection();
        //find record to delete
        collection.ThisCustomer.Find(cusId);
        //delete the record
        collection.Delete(cusId);
        //redirect to main page
        Response.Redirect("CustomerList.aspx");
    }
}