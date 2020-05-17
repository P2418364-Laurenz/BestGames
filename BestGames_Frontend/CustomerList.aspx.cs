using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BestGames_Libary;

public partial class CustomerList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        //create instance of customer collection
        BestGames_Libary.clsCustomerCollection userList = new BestGames_Libary.clsCustomerCollection();
        //set the listbox to the database list
        CustomerListBox.DataSource = userList.CustomerList;
        //set the name of the primary key
        CustomerListBox.DataValueField = "cusId";
        //set the data field to display
        CustomerListBox.DataTextField = "cusEmail";
        //bind data to list
        CustomerListBox.DataBind();
    }
}