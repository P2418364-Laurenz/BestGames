using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BestGames_Libary;

public partial class _Default : System.Web.UI.Page
{

    Int32 o_id;

    protected void Page_Load(object sender, EventArgs e)
    {

        o_id = Convert.ToInt32(Session["o_id"]);
        if(IsPostBack == false)
        {
            if(o_id != -1)
            {
                DisplayOrder();
            }
        }
    }




    void DisplayOrder()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(o_id);

        txtID.Text = OrderBook.ThisOrder.o_id.ToString();
        txtInfo.Text = OrderBook.ThisOrder.o_information;
        txtDate.Text = OrderBook.ThisOrder.o_date.ToString();
        chkActive.Checked = OrderBook.ThisOrder.o_status;


    }





    protected void btnEnter_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        string o_date = txtDate.Text;
        string o_info = txtInfo.Text;




        string Error = "";
        Error = AnOrder.Valid(o_info, o_date);
        if (Error == "")
        {
            AnOrder.o_information = o_info;
            AnOrder.o_date = Convert.ToDateTime(txtDate.Text);
            //store the order in the session object
            Session["Order"] = AnOrder;
            //redirect to the viewer page
            Response.Redirect("OrderView.aspx");
        }
        else
        {
            lbl.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        Int32 o_id;

        Boolean Found = false;

        o_id = Convert.ToInt32(txtID.Text);

        Found = AnOrder.Find(o_id);

        if (Found == true)
        {
            txtInfo.Text = AnOrder.o_information;
            txtDate.Text = AnOrder.o_date.ToString();
        }
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {

        clsOrder AnOrder = new clsOrder();

        string o_date = txtDate.Text;
        string o_info = txtInfo.Text;

        string Error = "";
        Error = AnOrder.Valid(o_info, o_date);
        if (Error == "")
        {
            AnOrder.o_information = o_info;
            AnOrder.o_date = Convert.ToDateTime(txtDate.Text);
            AnOrder.o_status = chkActive.Checked;
            
            clsOrderCollection OrderList = new clsOrderCollection();

            if(o_id == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(o_id);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }


            Response.Redirect("OrderList.aspx");
        }
        else
        {
            lbl.Text = Error;
        }
    }
}