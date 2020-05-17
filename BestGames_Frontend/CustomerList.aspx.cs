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
        clsCustomerCollection collection = new clsCustomerCollection();
        //set the listbox to the database list
        CustomerListBox.DataSource = collection.CustomerList;
        //set the name of the primary key
        CustomerListBox.DataValueField = "cusId";
        //set the data field to display
        CustomerListBox.DataTextField = "cusName";
        //bind data to list
        CustomerListBox.DataBind();
    }

    protected void btnAdd_click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["cusId"] = -1;
        //redirect to the data entry page
        Response.Redirect("aCustomer.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //store primary key
        Int32 cusId;
        //if a record has been selected from the listview
        if (CustomerListBox.SelectedIndex!=-1)
        {
            //get primary key of record to delete
            cusId = Convert.ToInt32(CustomerListBox.SelectedValue);
            //store data in the session object
            Session["cusId"] = cusId;
            //redirect to deletion page
            Response.Redirect("DeleteCustomer.aspx");
        }
        else
        {
            //display error if user not found for some reason
            lblError.Text = "Please select a customer from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 cusId;
        //if the record has been selected from the list
        if (CustomerListBox.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            cusId = Convert.ToInt32(CustomerListBox.SelectedValue);
            //store the data in the session object
            Session["cusId"] = cusId;
            //redirect to the edit page
            Response.Redirect("aCustomer.aspx");
        }
        else
        {
            //display error because nothing was selected from the list
            lblError.Text = "Please select a record from the list";
        }
    }
}