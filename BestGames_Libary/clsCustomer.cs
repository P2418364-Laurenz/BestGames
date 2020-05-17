using System;
using System.Text;

namespace BestGames_Libary
{
    public class clsCustomer
    {
        public Int32 cusId { get; set; }
        public String cusName { get; set; }
        public String cusEmail { get; set; }
        public String cusPassword  { get; set; }
        public DateTime cusDateRegister = DateTime.Now;
        public bool cusAccountStatus = true;

        /// <summary>
        /// Makes a new customer with class attributes. All attributes MUST BE present (so pre-execution checking must be in place).
        /// </summary>
        public void setUser()
        {
            clsDataConnection tempDb = new clsDataConnection();
            tempDb.AddParameter("@uName", this.cusName);
            tempDb.AddParameter("@uEmail", this.cusEmail);
            tempDb.AddParameter("@uPassword", this.cusPassword);
            tempDb.Execute("tblCustomerAdd");
        }

        public String getAllRecords()
        {
            clsDataConnection tempDb = new clsDataConnection();
            tempDb.Execute("tblCustomerReturnAll");
            return tempDb.ToString();
        }

        public void Delete(int cusId)
        {
            //create data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameters
            DB.AddParameter("@customerId", cusId);
            //execute deletion
            DB.Execute("tblCustomerDelete");
        }

        public bool Find(int cusId)
        {
            //create new connection
            clsDataConnection DB = new clsDataConnection();
            //add parameters
            DB.AddParameter("@uId", cusId);
            //execute the stored procedure
            DB.Execute("tblCustomerFilterId");
            //check if record is found
            if (DB.Count == 1)
            {
                //copy data from database to private data member
                cusId = Convert.ToInt32(DB.DataTable.Rows[0]["u_id"]);
                cusName = Convert.ToString(DB.DataTable.Rows[0]["u_name"]);
                cusPassword = Convert.ToString(DB.DataTable.Rows[0]["u_password"]);
                cusDateRegister = Convert.ToDateTime(DB.DataTable.Rows[0]["u_creation_date"]);
                cusEmail = Convert.ToString(DB.DataTable.Rows[0]["u_email"]);
                cusAccountStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["u_status"]);
                //return boolean to show it worked
                return true;
            }
            else
            {
                //no record found, doesn't exist return false
                return false;
            }
        }

        /// <summary>
        /// filters database by the clsCustomer in argument as reference. Uses id, name and email. If you get the wrong output try using fewer arguments (id and email are unique!)
        /// </summary>
        /// <param name="reference">a clsCustomer class with desired search parameters</param>
        /// <returns>A clsCustomer class with the database row's attributes (or id -1 if none found)</returns>
        public clsCustomer filterCustomer(clsCustomer reference)
        {
            // creates new instance of clsCustomer called aCustomer
            clsCustomer aCustomer = new clsCustomer();
            // creates new instance of dataBase connection
            clsDataConnection DB = new clsDataConnection();
            // checks which attributes are set in the reference clsCustomer class (as mentioned in this classes documentation)
            if (reference.cusId > 0 || reference.cusName != "" || reference.cusEmail != "")
            {
                // create a temp counter to check a result is found (0 if not found)
                int tempCounter = 0;
                // check cusId is not empty (-1 is default value so must be set before being used - DB starts at id 10,000)
                if (reference.cusId > 0)
                {
                    // adds parameter and executes stored procedure
                    DB.AddParameter("@uId", reference.cusId);
                    DB.Execute("tblCustomerFilterId");
                    //checks for db output
                    if (DB.Count == 1)
                    {
                        // sets all attributes to retrieved database variables
                        aCustomer.cusId = Convert.ToInt32(DB.DataTable.Rows[0]["u_id"]);
                        aCustomer.cusName = Convert.ToString(DB.DataTable.Rows[0]["u_name"]);
                        aCustomer.cusEmail = Convert.ToString(DB.DataTable.Rows[0]["u_email"]);
                        aCustomer.cusPassword = Convert.ToString(DB.DataTable.Rows[0]["u_password"]);
                        aCustomer.cusDateRegister = Convert.ToDateTime(DB.DataTable.Rows[0]["u_creation_date"]);
                        aCustomer.cusAccountStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["u_status"]);
                        // increment counter if row is found
                        tempCounter++;
                    }
                }
                // check cusName is not empty (default cusName = "")
                if (reference.cusName != "")
                {
                    // adds parameter and executes stored procedure
                    DB.AddParameter("@uName", reference.cusName);
                    DB.Execute("tblCustomerFilterId");
                    // checks for db output
                    if (DB.Count == 1)
                    {
                        // sets all attributes to retrieved database variables
                        aCustomer.cusId = Convert.ToInt32(DB.DataTable.Rows[0]["u_id"]);
                        aCustomer.cusName = Convert.ToString(DB.DataTable.Rows[0]["u_name"]);
                        aCustomer.cusEmail = Convert.ToString(DB.DataTable.Rows[0]["u_email"]);
                        aCustomer.cusPassword = Convert.ToString(DB.DataTable.Rows[0]["u_password"]);
                        aCustomer.cusDateRegister = Convert.ToDateTime(DB.DataTable.Rows[0]["u_creation_date"]);
                        aCustomer.cusAccountStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["u_status"]);
                        // increment counter if row is found
                        tempCounter++;
                    }
                }
                // checks cusEmail is not empty (default cusEmail = "")
                if (reference.cusEmail != "")
                {
                    // adds parameter and executes stored procedure
                    DB.AddParameter("@uEmail", reference.cusEmail);
                    DB.Execute("tblCustomerFilterEmail");
                    // checks for db output
                    if (DB.Count == 1)
                    {
                        // sets all attributes to retrieved database variables
                        aCustomer.cusId = Convert.ToInt32(DB.DataTable.Rows[0]["u_id"]);
                        aCustomer.cusName = Convert.ToString(DB.DataTable.Rows[0]["u_name"]);
                        aCustomer.cusEmail = Convert.ToString(DB.DataTable.Rows[0]["u_email"]);
                        aCustomer.cusPassword = Convert.ToString(DB.DataTable.Rows[0]["u_password"]);
                        aCustomer.cusDateRegister = Convert.ToDateTime(DB.DataTable.Rows[0]["u_creation_date"]);
                        aCustomer.cusAccountStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["u_status"]);
                        // increment counter if row is found
                        tempCounter++;
                    }
                }
                // Check the counter to make sure that at least 1 match was found and returns new populated clsCustomer class
                if (tempCounter > 0)
                {
                    return aCustomer;
                }
                // if tempCounter is empty return a dummy clsCustomer class with cusId = -1
                else
                {
                    clsCustomer noCustomer = new clsCustomer();
                    noCustomer.cusId = -1;
                    return noCustomer;
                }
            }
            // if cusId, cusName and cusEmail are not set then return a dummy clsCustomer class with cusId = -1
            else
            {
                clsCustomer noCustomer = new clsCustomer();
                noCustomer.cusId = -1;
                return noCustomer;
            }
        }

        /// <summary>
        /// Checks if the class attribute information is valid - contains the correct punctuation, correct character count, and doesn't contain malicious code.
        /// </summary>
        /// <returns>Boolean true = information is okay, false = information needs changing, check the information.</returns>
        public string Valid(string cusName, string cusEmail, string cusPassword)
        {
            //create an error string
            String error = "";
            //if cusName is less than min
            if (cusName.Length < 1)
            {
                error += "Customer name too short : "; //error to display
            }
            //if name is more than 256 characters
            if (cusName.Length>256)
            {
                error += "Customer name too long : "; //error to display
            }
            //if cusEmail is less than min
            if (cusEmail.Length < 5)
            {
                error += "Customer email too short : "; //error to display
            }
            //if cusEmail is more than max
            if (cusEmail.Length > 512)
            {
                error += "Customer email too long : ";//error to display
            }
            //if cusEmail doesn't contain @ or .
            if (!cusEmail.Contains("@"))
            {
                error += "Customer email doesn't have an @ symbol (required)";//error
            }
            if (!cusEmail.Contains("."))
            {
                error += "Customer email doesn't have an .com (required)";//error
            }
            //if cusPass is less than min
            if (cusPassword.Length < 6)
            {
                error += "Customer Password too short : "; //error to display
            }
            //if cusPass is more than max
            if (cusPassword.Length > 64)
            {
                error += "Customer Password too long : "; //error to display
            }
            //return all concatenated errors in error String
            return error;
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
            //make connection
            clsDataConnection tempDb = new clsDataConnection();
            //set the value of parameter to delete as this ID
            tempDb.AddParameter("@customerId", this.cusId);
            //execute the stored procedure
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

        /// <summary>
        /// A custom function for finding if the query string contains (or doesn't contain) the accepted characters.
        /// </summary>
        /// <param name="query">The input or query string</param>
        /// <param name="accepted">All the accepted characters</param>
        /// <returns>Returns true if only contains the accepted characters, false if any other characters are detected.</returns>
        public Boolean onlyContains(String query, String accepted)
        {
            int counter = 0;
            for (int i = 0; i < query.Length; i++)
            {
                if (accepted.Contains(query[i].ToString()))
                {
                    counter++;
                }
            }
            if (counter==query.Length)
            {
                return true;
            } else
            {
                return false;
            }
        }

    }
}