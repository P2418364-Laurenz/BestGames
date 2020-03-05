using System;

namespace BestGames_Libary
{
    public class clsCustomer
    {
        public int cusId = 0;
        public String cusName = "";
        public String cusEmail = "";
        public String cusPassword = "";
        public DateTime cusDateRegister = DateTime.Now;
        public bool cusAccountStatus = true;

        // Makes a new customer with args name, email and password
        public void setCustomer(String name, String email, String password)
        {
            clsCustomer aCustomer = new clsCustomer();
            aCustomer.cusName = name;
            aCustomer.cusEmail = email;
            aCustomer.cusPassword = password;
        }

        // Returns the customer class information
        public clsCustomer getCustomer(int id)
        {
            clsCustomer aCustomer = new clsCustomer();
            this.cusId = id;
            return aCustomer;
        }

        public void deleteAccount()
        {
            clsDataConnection tempDb = new clsDataConnection();
            tempDb.AddParameter("@customerId", this.cusId);
            tempDb.Execute("tblCustomerDelete");
        }

        // returns string with all the customer's information
        public String toString()
        {
            return "{id:\"" + this.cusId + "\", name:\"" + this.cusName +
                "\", email:\"" + this.cusEmail + "\", password:\"" +
                this.cusPassword + "\", dateRegistered:\"" + this.cusDateRegister +
                "\", status:\"" + this.cusAccountStatus + "\"}";
        }

    }
}