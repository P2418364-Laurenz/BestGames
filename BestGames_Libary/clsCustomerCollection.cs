using System;
using System.Collections.Generic;
namespace BestGames_Libary
{
    public class clsCustomerCollection
    {
        public List<clsCustomer> customerList = new List<clsCustomer>();
        public Int32 Count;
        public clsCustomer thisCustomer;

        public void add(clsCustomer customer)
        {
            this.customerList.Add(customer);
        }

        public void clear()
        {
            this.customerList.Clear();
        }

        public void remove(clsCustomer customer)
        {
            this.customerList.Remove(customer);
        }

        public void removeLastItem()
        {
            this.customerList.RemoveAt(customerList.Count-1);
        }

        public clsCustomer customerAtIndex(Int32 i)
        {
            return this.customerList[i];
        }
    }
}