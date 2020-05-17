using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BestGames_Libary;

public partial class aCustomer : System.Web.UI.Page
{
    //store variable for cus ID from session (depending on the event handler!)
    Int32 cusId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer id to be processed
        cusId = Convert.ToInt32(Session["cusId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (cusId != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create instance
        clsCustomer customer = new clsCustomer();
        //capture the details
        string mCusId = txtCusId.Text;
        string cusName = txtCusName.Text;
        string cusPassword = txtCusPassword.Text;
        string cusEmail = txtCusEmail.Text;
        bool cusAccountStatus = txtCusStatus.Checked;
        //store errors here
        string errors = "";
        //validate the data
        errors = customer.Valid(cusName, cusEmail, cusPassword);
        if (errors=="")
        {
            //capture the details in the customer class
            if (mCusId != "")
            {
                customer.cusId = Convert.ToInt32(mCusId);
            }
            customer.cusName = Convert.ToString(cusName);
            customer.cusEmail = Convert.ToString(cusEmail);
            customer.cusPassword = Convert.ToString(cusPassword);
            customer.cusAccountStatus = cusAccountStatus;
            //date created NEVER CHANGES!
            //create new collection
            clsCustomerCollection collection = new clsCustomerCollection();

            //if this is a new record i.e. cusId = -1 then add the data
            if (cusId == -1)
            {
                //set the ThisCustomer property
                collection.ThisCustomer = customer;
                //add the record
                collection.Add();
                //redirect to list
            }
            else //editing/updating the customer
            {
                //find the record
                collection.ThisCustomer.Find(cusId);
                //set the ThisCustomer property
                collection.ThisCustomer = customer;
                //update the record
                collection.Update();
            }
            //redirect
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display error
            lblError.Text = errors;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        if (txtCusId.Text != "")
        {
            //create an instance of the customer class
            clsCustomer customer = new clsCustomer();
            //variable to store the primary key
            Int32 customerId;
            //variable to store the result of the find operation
            Boolean found = false;
            //get the primary key entered by the user
            customerId = Convert.ToInt32(txtCusId.Text);
            //find the record
            found = customer.Find(customerId);
            //if found
            if (found == true)
            {
                //display the valies of the properties in the form
                txtCusId.Text = Convert.ToString(customer.cusId);
                txtCusName.Text = Convert.ToString(customer.cusName);
                txtCusPassword.Text = Convert.ToString(customer.cusPassword);
                txtCusCreationDate.Text = Convert.ToString(customer.cusDateRegister);
                txtCusEmail.Text = Convert.ToString(customer.cusEmail);
                txtCusStatus.Checked = Convert.ToBoolean(customer.cusAccountStatus);
            }
        }
    }

    void DisplayCustomer()
    {
        //creat instance of collection
        clsCustomerCollection collection = new clsCustomerCollection();
        //find the record to update
        collection.ThisCustomer.Find(cusId);
        //display the data for this record
        txtCusId.Text = Convert.ToString(cusId);
        txtCusName.Text = collection.ThisCustomer.cusName;
        txtCusPassword.Text = collection.ThisCustomer.cusPassword;
        txtCusCreationDate.Text = collection.ThisCustomer.cusDateRegister.ToString();
        txtCusEmail.Text = collection.ThisCustomer.cusEmail;
        txtCusStatus.Checked = collection.ThisCustomer.cusAccountStatus;
    }

}