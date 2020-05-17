using System;
using System.Collections.Generic;
namespace BestGames_Libary
{
    public class clsCustomerCollection
    {
        //private data member for the list and thisCustomer
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

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

        public clsCustomer ThisCustomer {
            get
            {
                //get private field
                return mThisCustomer;
            }
            set
            {
                //set private field
                mThisCustomer = value;
            }
        }
        
        /// <summary>
        /// A local add method for adding a customer class to the list (for offline)
        /// </summary>
        /// <param name="customer">clsCustomer class</param>
        public void add(clsCustomer customer)
        {
            mCustomerList.Add(customer);
        }

        /// <summary>
        /// Delete ThisCustomer's row from database
        /// </summary>
        /// <param name="id">ID to delete from the database (necessary)</param>
        public void Delete(int idToDelete)
        {
            //deletes the record pointed to by ThisCustomer
            //connect
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stores procedure
            DB.AddParameter("@customerId", idToDelete);
            //execute the stored procedure
            DB.Execute("tblCustomerDelete");
        }

        public clsCustomer customerAtIndex(int i)
        {
            return mCustomerList[i];
        }

        public void clear()
        {
            mCustomerList.Clear();
        }

        /// <summary>
        /// Add to the SQL database after validation only
        /// </summary>
        /// <returns>Returns cusId</returns>
        public int Add()
        {
            //add record to db - connect first
            clsDataConnection DB = new clsDataConnection();
            //set parameters for stored procedure
            DB.AddParameter("@cusName", mThisCustomer.cusName);
            DB.AddParameter("@cusEmail", mThisCustomer.cusEmail);
            DB.AddParameter("@cusPassword", mThisCustomer.cusPassword);
            //execute query and return the result (u_id/cusId)
            return DB.Execute("tblCustomerInsert");
        }

        /// <summary>
        /// Update ThisCustomer record to the input values. Cannot change read-only field date_created
        /// </summary>
        public void Update()
        {
            //update an exiting record based on the valies of ThisCustomer
            //connect to db
            clsDataConnection db = new clsDataConnection();
            //set the paramteres for the stores procedure
            db.AddParameter("@uId", ThisCustomer.cusId);
            db.AddParameter("@uName", ThisCustomer.cusName);
            db.AddParameter("@uEmail", ThisCustomer.cusEmail);
            db.AddParameter("@uPassword", ThisCustomer.cusPassword);
            db.AddParameter("@uStatus", ThisCustomer.cusAccountStatus);
            //execute
            db.Execute("tblCustomerUpdate");
        }

        public void ReportByEmail(string email)
        {
            //filters the records based on a full or partial email
        }
    }
}