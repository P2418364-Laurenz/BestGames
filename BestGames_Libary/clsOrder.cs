using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BestGames_Libary;


namespace BestGames_Libary
{
    public class clsOrder
    {

        private Int32 mOrder_ID;
        private DateTime mDateAdded;
        private Boolean mStatus;
        private string mInformation;
        private string mFull_info;
        private Int32 mCus_id;
        private Int32 mS_id;


        public bool o_status
        {
            get
            {
                return mStatus;
            }

            set
            {
                mStatus = value;
            }
        }


        public DateTime o_date
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }


        public int o_id
        {
            get
            {
                return mOrder_ID;
            }
            set
            {
                mOrder_ID = value;
            }
        }


        public string o_information
        {
            get
            {
                return mInformation;
            }

            set
            {
                mInformation = value;
            }
        }

        public string o_full_info
        {
            get
            {
                return mFull_info;
            }
            set
            {
                mFull_info = value;
            }
        }


        public int cus_id
        {
            get
            {
                return mCus_id;
            }
            set
            {
                mCus_id = value;
            }
        }


        public int s_id
        {
            get
            {
                return mS_id;
            }
            set
            {
                mS_id = value;
            }
        }


        public bool Find(int o_id)
        {

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@o_id", o_id);

            DB.Execute("sproc_tblOrder_FindByOrderNo");

            if (DB.Count == 1)
            {
                mOrder_ID = Convert.ToInt32(DB.DataTable.Rows[0]["o_id"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["o_date"]);
                mStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["o_status"]);
                mInformation = Convert.ToString(DB.DataTable.Rows[0]["o_information"]);
                mFull_info = Convert.ToString(DB.DataTable.Rows[0]["o_full_info"]);
                mCus_id = Convert.ToInt32(DB.DataTable.Rows[0]["cus_id"]);
                //mS_id = Convert.ToInt32(DB.DataTable.Rows[0]["s_id"]);

                return true;
            }

            else
            {
                return false;
            }

        }


        public bool FindTop1()
        {

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblOrder_SelectTop1");

            if (DB.Count == 1)
            {
                mOrder_ID = Convert.ToInt32(DB.DataTable.Rows[0]["o_id"]);

                return true;
            }

            else
            {
                return false;
            }

        }



        //public void Delete(Int32 o_id)
        //{
        //    clsDataConnection DB = new clsDataConnection();

        //    DB.AddParameter("@o_id", o_id);
        //    DB.Execute("sproc_tblOrder_Delete");
        //}


        public string Valid(string o_information, DateTime o_date)
        {
            return "";
        }

        public string Valid(string o_information)
        {
            String Error = "";

            if(o_information.Length == 0)
            {
                Error = Error + "The Order Information may not be black: ";
            }

            if(o_information.Length > 50)
            {
                Error = Error + "The Order Information must be less than 50 characters: ";
            }

            return Error;
        }

        public string Valid(string o_information, string o_date)
        {
            String Error = "";
            DateTime DateTemp;
            if (o_information.Length == 0)
            {
                Error = Error + "The Order Information may not be black: ";
            }

            if (o_information.Length > 50)
            {
                Error = Error + "The Order Information must be less than 50 characters: ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(o_date);

                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past: ";
                }



                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future: ";
                }

            }
            catch
            {
                Error = Error + "The date was not a valid date: ";
            }

            return Error;

        }


    }
}
