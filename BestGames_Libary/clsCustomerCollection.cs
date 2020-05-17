using System;
using System.Collections.Generic;

namespace BestGames_Libary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        public clsCustomerCollection()
        {
            //vars for index and record counter
            Int32 Index = 0, RecordCount = 0;
            //create new collection object
            clsDataConnection DB = new clsDataConnection();
            //execute select all from database
            DB.Execute("tblCustomerReturnAll");
            //get the count of the returned query result and store it in RecordCount
            RecordCount = DB.Count;
            //while looping through records to process
            while (Index < RecordCount)
            {
                //create blank address
                clsCustomer address = new clsCustomer();
                //read in the fields from the current record
                address.cusAccountStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["u_status"]);
                address.cusDateRegister = Convert.ToDateTime(DB.DataTable.Rows[Index]["u_creation_date"]);
                address.cusEmail = Convert.ToString(DB.DataTable.Rows[Index]["u_email"]);
                address.cusId = Convert.ToInt32(DB.DataTable.Rows[Index]["u_id"]);
                address.cusName = Convert.ToString(DB.DataTable.Rows[Index]["u_name"]);
                address.cusPassword = Convert.ToString(DB.DataTable.Rows[Index]["u_password"]);
                //add the result to customer list
                mCustomerList.Add(address);
                Index++;
            }
        }

        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //leave for later
            }
        }
        public clsCustomer ThisCustomer { get; set; }
    }
}