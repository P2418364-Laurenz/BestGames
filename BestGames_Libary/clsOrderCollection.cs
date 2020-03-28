using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGames_Libary
{
    public class clsOrderCollection
    {

        List<clsOrder> mOrderList = new List<clsOrder>();

        clsOrder mThisOrder = new clsOrder();

        public clsOrderCollection()
        {


            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);


           
        }


        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();

            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();


                AnOrder.o_id = Convert.ToInt32(DB.DataTable.Rows[0]["o_id"]);
                AnOrder.o_date = Convert.ToDateTime(DB.DataTable.Rows[Index]["o_date"]);
                AnOrder.o_status = Convert.ToBoolean(DB.DataTable.Rows[Index]["o_status"]);
                AnOrder.o_information = Convert.ToString(DB.DataTable.Rows[Index]["o_information"]);



                mOrderList.Add(AnOrder);

                Index++;
            }

        }


        public List<clsOrder> OrderList
        {

            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }


        }
        public int Count
        {

            get
            {
                return mOrderList.Count;
            }
            set
            {
                
            }


        }


        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }

        }


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            
            DB.AddParameter("@o_date", mThisOrder.o_date);
            DB.AddParameter("@o_status", mThisOrder.o_status);
            DB.AddParameter("@o_information", mThisOrder.o_information);

            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@o_id", mThisOrder.o_id);
            DB.Execute("sproc_tblOrder_Delete");
        }



        public void ReportByOrderInformation(string o_information)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@o_information", o_information);
            DB.Execute("sproc_tblOrder_FilterByOrderInformation");
            PopulateArray(DB);
        }

        

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@o_id", mThisOrder.o_id);
            DB.AddParameter("@o_date", mThisOrder.o_date);
            DB.AddParameter("@o_status", mThisOrder.o_status);
            DB.AddParameter("@o_information", mThisOrder.o_information);
            DB.Execute("sproc_tblOrder_Update");
        }

    }
}
