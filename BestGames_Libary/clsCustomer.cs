using System;
using System.Text;

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
        
        /// <summary>
        /// Makes a new customer with args name, email and password (password will be encrypted)
        /// </summary>
        /// <param name="name">name string</param>
        /// <param name="email">email string</param>
        /// <param name="password">password string</param>
        /// <returns>returns the clsCustomer class with argument attributes</returns>
        public void setUser()
        {
            clsDataConnection tempDb = new clsDataConnection();
            tempDb.AddParameter("@uName", this.cusName);
            tempDb.AddParameter("@uEmail", this.cusEmail);
            tempDb.AddParameter("@uPassword", this.cusPassword);
            tempDb.Execute("tblCustomerAdd");
        }

        /// <summary>
        /// TODO!!! Returns all class attributes from the SQL database in clsCustomer class from id argument
        /// </summary>
        /// <param name="id">integer id</param>
        /// <returns>a clsCustomer class with all the attributes of the class id</returns>
        public clsCustomer getCustomer(int id)
        {
            clsCustomer aCustomer = new clsCustomer();
            this.cusId = id;
            return aCustomer;
        }

        /// <summary>Will delete the associated account from the SQL Database</summary>
        public void deleteAccount()
        {
            clsDataConnection tempDb = new clsDataConnection();
            tempDb.AddParameter("@customerId", this.cusId);
            tempDb.Execute("tblCustomerDelete");
        }

        /// <summary>Convert all attributes/variables to string return format</summary>
        /// <returns>example: {id:"5", name:"Tester", email:"test@test.net", dateRegistered:"05/03/2020 8:13:20 PM", status:"True"}</returns>
        public String toString()
        {
            return "{id:\"" + this.cusId + "\", name:\"" + this.cusName +
                "\", email:\"" + this.cusEmail + "\", password:\"" +
                this.cusPassword + "\", dateRegistered:\"" + this.cusDateRegister +
                "\", status:\"" + this.cusAccountStatus + "\"}";
        }

        /// <summary>Encrypts the cusPassword var, so class cusPassword must be set</summary>
        public void encryptPass()
        {
            // Check if password has already been converted to md5, if true DO NOT hash again!
            if (this.cusPassword.Length < 32)
            {
                using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
                {
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(this.cusPassword);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("X2"));
                    }
                    this.cusPassword = sb.ToString();
                }
            }
        }

    }
}