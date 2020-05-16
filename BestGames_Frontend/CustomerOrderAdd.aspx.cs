using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BestGames_Libary;

public partial class CustomerOrderAdd : System.Web.UI.Page
{
    Int32 cus_id;

    protected void Page_Load(object sender, EventArgs e)
    {
        cus_id = Convert.ToInt32(Session["cus_id"]);

        if (IsPostBack == false)
        {
            DisplayOrders();
        }


       

    }


    void DisplayOrders()
    {


        BestGames_Libary.clsCartCollection Carts = new BestGames_Libary.clsCartCollection();


        Carts.ReportByCartID(cus_id);

        lstCartList.DataSource = Carts.CartList;
        lstCartList.DataValueField = "c_id";
        lstCartList.DataTextField = "cart_info";
        lstCartList.DataBind();


        if (lstCartList.Items.Count == 0)
        {

            btnAdd.Enabled = false;
            lblError.Text = "There is no item in your Cart";

        }



    }




    protected void btnAdd_Click(object sender, EventArgs e)
    {

        Int32 c_id;
        Int32 o_id = 0;
        
       
        Boolean Found = false;
        Boolean Found2 = false;
        Boolean FoundCart = false;

        clsCart ACart = new clsCart();
        clsCartCollection CartList = new clsCartCollection();

        clsOrder AnOrder = new clsOrder();
        clsOrderCollection OrderList = new clsOrderCollection();

        clsOrderItem AnOrderItem = new clsOrderItem();
        clsOrderItemCollection OrderItemList = new clsOrderItemCollection();


        AnOrder.cus_id = cus_id;
        OrderList.ThisOrder = AnOrder;
        OrderList.AddOrder();


        Found = AnOrder.FindTop1();

        if(Found == true)
        {
            Label1.Text = AnOrder.o_id.ToString();
            o_id = Convert.ToInt32(Label1.Text);
            AnOrder.o_id = o_id;
        }


        int i;
        for (i = 0; i<lstCartList.Items.Count; i++)
        {
            lstCartList.Items[i].Selected = true;

            c_id = Convert.ToInt32(lstCartList.SelectedValue);

            Found = ACart.Find(c_id);
            Found2 = ACart.Find_i_id(ACart.i_id);
            

            if(Found == true)
                if (Found == true && Found2 == true)
            {
                Label1.Text = ACart.c_quantity.ToString();
                Int32 quantity = Convert.ToInt32(Label1.Text);

                AnOrderItem.o_item_quantity = quantity;
                AnOrderItem.p_id = ACart.p_id;
                AnOrderItem.o_id = o_id;

            }

            OrderItemList.ThisOrderItem = AnOrderItem;
            OrderItemList.AddItem();


            lstCartList.Items[i].Selected = false;

            
            FoundCart = ACart.Find(c_id);
            if(FoundCart == true)
            {
                ACart.c_id = ACart.c_id;
            }
            CartList.ThisCart = ACart;
            Label1.Text = ACart.c_id.ToString();

            CartList.Delete();

        }

        Response.Redirect("CustomerOrder.aspx");

    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerOrder.aspx");
    }
}