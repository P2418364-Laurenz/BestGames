using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGames_Libary
{
    public class clsOrderItemCollection
    {
        List<clsOrderItem> mOrderItemList = new List<clsOrderItem>();

        clsOrderItem mThisOrderItem = new clsOrderItem();

        public List<clsOrderItem> OrderItemList
        {
            get
            {
                return mOrderItemList;
            }
            set
            {
                mOrderItemList = value;
            }
        }

        public int Count
        {
            get
            {
                return mOrderItemList.Count;
            }
            set
            {

            }
        }

        public clsOrderItem ThisOrderItem
        {
            get
            {
                return mThisOrderItem;
            }
            set
            {
                mThisOrderItem = value;
            }
        }


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@o_id", mThisOrderItem.o_id);
            DB.AddParameter("@o_item_quantity", mThisOrderItem.o_item_quantity);
            DB.AddParameter("@p_id", mThisOrderItem.p_id);

            return DB.Execute("");

        }


        public int AddItem()
        {
            clsDataConnection DB = new clsDataConnection();
            //DB.AddParameter("@cus_id", mThisCart.cus_id);
            DB.AddParameter("@c_quantity", mThisOrderItem.o_item_quantity);
            DB.AddParameter("@o_id", mThisOrderItem.o_id);
            DB.AddParameter("@p_id", mThisOrderItem.p_id);
            

            return DB.Execute("sproc_tblOrderItem_InsertFromCart");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@o_item_id", mThisOrderItem.o_item_id);
            DB.Execute("sproc_tblOrderItem_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@o_item_id", mThisOrderItem.o_item_id);
            DB.AddParameter("@o_id", mThisOrderItem.o_id);
            DB.AddParameter("@o_item_quantity", mThisOrderItem.o_item_quantity);
            DB.AddParameter("@p_id", mThisOrderItem.p_id);
            DB.Execute("");
        }


        public void UpdateOrderItemQuantity()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@o_item_id", mThisOrderItem.o_item_id);
            DB.AddParameter("@o_item_quantity", mThisOrderItem.o_item_quantity);
            DB.Execute("sproc_tblOrderItem_Update_Quantity");
        }

        public void ReportByOrderItemInformation(int o_id)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@o_id", o_id);
            DB.Execute("sproc_tblOrderItem_FindByOrderNo");
            PopulateArray(DB);
        }

        

        public void ReportByOrderItemGameName(int o_id)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@o_id", o_id);
            DB.Execute("sproc_tblOrderItem_FilterByGameName");
            PopulateArray(DB);
        }


        public void ReportByOrderItemGamePrice(int o_id)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@o_id", o_id);
            DB.Execute("sproc_tblOrderItem_FilterByGamePrice");
            PopulateArray(DB);
        }

        public void ReportByOrderItemPrice(int o_id)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@o_id", o_id);
            DB.Execute("sproc_tblOrderItem_FilterByOrderItemPrice");
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderItemList = new List<clsOrderItem>();

            while (Index < RecordCount)
            {
                clsOrderItem AnOrderItem = new clsOrderItem();


                AnOrderItem.o_item_id = Convert.ToInt32(DB.DataTable.Rows[Index]["o_item_id"]);
                AnOrderItem.o_id = Convert.ToInt32(DB.DataTable.Rows[Index]["o_id"]);
                AnOrderItem.o_item_quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["o_item_quantity"]);
                AnOrderItem.p_id = Convert.ToInt32(DB.DataTable.Rows[Index]["p_id"]);
                AnOrderItem.o_full_info = Convert.ToString(DB.DataTable.Rows[Index]["o_full_info"]);

                mOrderItemList.Add(AnOrderItem);

                Index++;
            }

        }

        public clsOrderItemCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblOrderItem_SelectAll");
            PopulateArray(DB);
        }

    }
}
