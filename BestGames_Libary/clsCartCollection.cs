using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGames_Libary
{
    public class clsCartCollection
    {
        List<clsCart> mCartList = new List<clsCart>();

        clsCart mThisCart = new clsCart();

        public List<clsCart> CartList
        {
            get
            {
                return mCartList;
            }
            set
            {
                mCartList = value;
            }
        }


        public int Count
        {
            get
            {
                return mCartList.Count;
            }
            set
            {

            }
        }

        public clsCart ThisCart
        {
            get
            {
                return mThisCart;
            }
            set
            {
                mThisCart = value;
            }
        }


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            //DB.AddParameter("@cus_id", mThisCart.cus_id);
            DB.AddParameter("@c_quantity", mThisCart.c_quantity);
            
           

            return DB.Execute("sproc_tblOrderItem_InsertFromCart");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@c_id", mThisCart.c_id);
            DB.Execute("sproc_tblCart_Delete");
        }

        public void ReportByCartID(int cus_id)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@cus_id", cus_id);
            DB.Execute("sproc_tblCart_FilterByCustomerID");
            PopulateArray(DB);

        }

        public void ReportByCartid(int c_id)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@c_id", c_id);
            DB.Execute("sproc_tblCart_FilterByCartID");
            PopulateArray(DB);

        }




        void PopulateArray(clsDataConnection DB)
        {

            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCartList = new List<clsCart>();

            while (Index < RecordCount)
            {
                clsCart ACart = new clsCart();


                ACart.c_id = Convert.ToInt32(DB.DataTable.Rows[Index]["c_id"]);
                ACart.i_id = Convert.ToInt32(DB.DataTable.Rows[Index]["i_id"]);
                ACart.cus_id = Convert.ToInt32(DB.DataTable.Rows[Index]["cus_id"]);
                ACart.c_quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["c_quantity"]);
                ACart.cart_info = Convert.ToString(DB.DataTable.Rows[Index]["cart_info"]);


                mCartList.Add(ACart);

                Index++;
            }

        }


        public clsCartCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblCart_SelectAll");
            PopulateArray(DB);
        }



    }
}
