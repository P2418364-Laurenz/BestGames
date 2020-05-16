using BestGames_Libary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffOrder : System.Web.UI.Page
{

    Int32 o_id;

    protected void Page_Load(object sender, EventArgs e)
    {
        

    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {

        txtCustomerID.Text = "";
        txtDate.Text = "";
        txtOrderInfo.Text = "";
        chkActive.Checked = false;
        lstOrderItemList.Items.Clear();

        btnFilterPrice.Enabled = false;
        btnFilter_Game.Enabled = false;
        btnEdit.Enabled = false;
        btnDelete.Enabled = false;
        btnOk.Enabled = false;



        if (txtID.Text == "")
        {
            lblLabel.Text = "Please input the Order ID";
        }
        else
        {

            lblErrorItem.Text = "";
            lblLabel.Text = "";

            clsOrder AnOrder = new clsOrder();

            // Int32 o_id;

            Boolean Found = false;

            o_id = Convert.ToInt32(txtID.Text);

            Found = AnOrder.Find(o_id);

            if (Found == true)
            {

                txtCustomerID.Text = AnOrder.cus_id.ToString();
                txtDate.Text = AnOrder.o_date.ToString();
                txtOrderInfo.Text = AnOrder.o_information.ToString();
                chkActive.Checked = AnOrder.o_status;

            }







            clsOrderItemCollection OrderItems = new clsOrderItemCollection();

            OrderItems.ReportByOrderItemInformation(o_id);



            // BestGames_Libary.clsOrderItemCollection OrderItemss = new BestGames_Libary.clsOrderItemCollection();
            lstOrderItemList.DataSource = OrderItems.OrderItemList;
            lstOrderItemList.DataValueField = "o_item_id";
            lstOrderItemList.DataTextField = "o_full_info";
            lstOrderItemList.DataBind();


            Label8.Text = o_id.ToString();

            btnFilterPrice.Enabled = true;
            btnFilter_Game.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnOk.Enabled = true;



            if (Found == false)
            {
                btnFilterPrice.Enabled = false;
                btnFilter_Game.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            
            }

        }

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {

        lblErrorItem.Text = "";

        clsOrder AnOrder = new clsOrder();
        Int32 o_id;

        string o_information = txtOrderInfo.Text;

        o_id = Convert.ToInt32(txtID.Text);

        string Error = "";

        Error = AnOrder.Valid(o_information);

        if(Error == "")
        {
            AnOrder.o_id = o_id;
            AnOrder.o_information = o_information;
            AnOrder.o_status = chkActive.Checked;

            clsOrderCollection OrderList = new clsOrderCollection();

            OrderList.ThisOrder.Find(o_id);
            OrderList.ThisOrder = AnOrder;
            OrderList.UpdateOrder();

            lblLabel.Text = "Updated Sucessful!";
        }

        else
        {
            lblLabel.Text = Error;
        }




    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        lblLabel.Text = "";

        Int32 o_item_id;

        if(lstOrderItemList.SelectedIndex != -1)
        {
            o_item_id = Convert.ToInt32(lstOrderItemList.SelectedValue);
            Session["o_id"] = o_id;
            Session["o_item_id"] = o_item_id;
            Response.Redirect("StaffOrderItemDelete.aspx");
        }
        else
        {
            lblErrorItem.Text = "Please select a record to Delete from the list";
        }

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {

        lblLabel.Text = "";
        Int32 o_item_id;

        if (lstOrderItemList.SelectedIndex != -1)
        {
            o_item_id = Convert.ToInt32(lstOrderItemList.SelectedValue);
            Session["o_item_id"] = o_item_id;

            Response.Redirect("StaffOrderItemEdit.aspx");
        }
        else
        {
            lblErrorItem.Text = "Please select a record to Edit from the list";
        }



    }




    protected void Button1_Click1(object sender, EventArgs e)
    {
        lblLabel.Text = "";
        Int32 o_id = Convert.ToInt32(Label8.Text);

        clsOrderItemCollection OrderItems = new clsOrderItemCollection();

        OrderItems.ReportByOrderItemGameName(o_id);

        lstOrderItemList.DataSource = OrderItems.OrderItemList;
        lstOrderItemList.DataValueField = "o_item_id";
        lstOrderItemList.DataTextField = "o_full_info";
        lstOrderItemList.DataBind();


    }

    protected void lstOrderItemList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnFilterPrice_Click(object sender, EventArgs e)
    {
        lblLabel.Text = "";
        Int32 o_id = Convert.ToInt32(Label8.Text);

        clsOrderItemCollection OrderItems = new clsOrderItemCollection();

        OrderItems.ReportByOrderItemGamePrice(o_id);

        lstOrderItemList.DataSource = OrderItems.OrderItemList;
        lstOrderItemList.DataValueField = "o_item_id";
        lstOrderItemList.DataTextField = "o_full_info";
        lstOrderItemList.DataBind();
    }

    protected void Button1_Click2(object sender, EventArgs e)
    {
        Response.Redirect("MainPage.aspx");
    }
}