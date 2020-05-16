using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGames_Libary
{
    public class clsCart
    {
        private Int32 mC_id;
        private Int32 mI_id;
        private Int32 mCus_id;
        private Int32 mC_quantity;
        private string mCart_Info;
        private Int32 mP_id;


        public int c_id
        {
            get
            {
                return mC_id;
            }
            set
            {
                mC_id = value;
            }
        }

        public int i_id
        {
            get
            {
                return mI_id;
            }
            set
            {
                mI_id = value;
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

        public int c_quantity
        {
            get
            {
                return mC_quantity;
            }
            set
            {
                mC_quantity = value;
            }
        }


        public string cart_info
        {
            get
            {
                return mCart_Info;
            }
            set
            {
                mCart_Info = value;
            }
        }

        public int p_id
        {
            get
            {
                return mP_id;
            }
            set
            {
                mP_id = value;
            }
        }


        public bool Find(int c_id)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@c_id", c_id);

            DB.Execute("sproc_tblCart_filterByCartID");

            if (DB.Count == 1)
            {
                mC_quantity = Convert.ToInt32(DB.DataTable.Rows[0]["c_quantity"]);
                mC_id = Convert.ToInt32(DB.DataTable.Rows[0]["c_id"]);
                mI_id = Convert.ToInt32(DB.DataTable.Rows[0]["i_id"]);
                return true;
            }

            else
            {
                return false;
            }
        }



        public bool Find_i_id(int i_id)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@i_id", i_id);

            DB.Execute("sproc_Outerjoin");

            if (DB.Count == 1)
            {
                mP_id = Convert.ToInt32(DB.DataTable.Rows[0]["Available"]);
                return true;
            }

            else
            {
                return false;
            }
        }



    }
}
