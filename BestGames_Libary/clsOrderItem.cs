using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGames_Libary
{
    public class clsOrderItem
    {
        private Int32 mO_item_id;
        private Int32 mO_id;
        private Int32 mO_item_quantity;
        private Int32 mP_id;
        private string mFull_info;
        private string mGame;
        private string mProduct_key;


        public int o_item_id
        {
            get
            {
                return mO_item_id;
            }
            set
            {
                mO_item_id = value;
            }
        }

        public int o_id
        {
            get
            {
                return mO_id;
            }
            set
            {
                mO_id = value;
            }
        }
        public int o_item_quantity
        {
            get
            {
                return mO_item_quantity;
            }
            set
            {
                mO_item_quantity = value;
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

        public string i_name
        {
            get
            {
                return mGame;
            }
            set
            {
                mGame = value;
            }
        }

        public string p_key
        {
            get
            {
                return mProduct_key;
            }
            set
            {
                mProduct_key = value;
            }
        }


        public bool Find(int o_item_id)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@o_item_id", o_item_id);

            DB.Execute("sproc_tblOrderItem_FindByOrderItemNo");

            if(DB.Count == 1)
            {
                mO_item_id = Convert.ToInt32(DB.DataTable.Rows[0]["o_item_id"]);
                mO_id = Convert.ToInt32(DB.DataTable.Rows[0]["o_id"]);
                mO_item_quantity = Convert.ToInt32(DB.DataTable.Rows[0]["o_item_quantity"]);
                mP_id = Convert.ToInt32(DB.DataTable.Rows[0]["p_id"]);
                mFull_info = Convert.ToString(DB.DataTable.Rows[0]["o_full_info"]);
                mGame = Convert.ToString(DB.DataTable.Rows[0]["i_name"]);
                mProduct_key = Convert.ToString(DB.DataTable.Rows[0]["p_key"]);


                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
