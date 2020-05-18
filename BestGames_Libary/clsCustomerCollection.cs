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
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("tblCustomerReturnAll");
            //populate the array list with the data table
            PopulateArray(DB);
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
            DB.AddParameter("@uName", mThisCustomer.cusName);
            DB.AddParameter("@uEmail", mThisCustomer.cusEmail);
            DB.AddParameter("@uPassword", mThisCustomer.cusPassword);
            //execute query and return the result (u_id/cusId)
            return DB.Execute("tblCustomerAdd");
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
            //filters the records based on a full or partial email address
            //create new connection
            clsDataConnection db = new clsDataConnection();
            //add parameter for procedure
            db.AddParameter("@uEmail", email);
            //execute procedure
            db.Execute("tblCustomerFilterEmail");
            //populate array list with the data table
            PopulateArray(db);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the paramter DB
            //var for index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of the record
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer customer = new clsCustomer();
                //read the fields from current record
                customer.cusAccountStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["u_status"]);
                customer.cusDateRegister = Convert.ToDateTime(DB.DataTable.Rows[Index]["u_creation_date"]);
                customer.cusEmail = Convert.ToString(DB.DataTable.Rows[Index]["u_email"]);
                customer.cusId = Convert.ToInt32(DB.DataTable.Rows[Index]["u_id"]);
                customer.cusName = Convert.ToString(DB.DataTable.Rows[Index]["u_name"]);
                customer.cusPassword = Convert.ToString(DB.DataTable.Rows[Index]["u_password"]);
                //add the record to the private data member
                mCustomerList.Add(customer);
                //point at the next record
                Index++;
            }
        }
    }
}