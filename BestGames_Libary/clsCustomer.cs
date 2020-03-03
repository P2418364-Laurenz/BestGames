using System;

namespace BestGames_Libary
{
    public class clsCustomer
    {
        public void customerDelete(int id)
        {
            clsDataConnection tempDb = new clsDataConnection();
            tempDb.AddParameter("@customerId", id);
            tempDb.Execute("test_tblCustomer_delete");
        }
    }
}