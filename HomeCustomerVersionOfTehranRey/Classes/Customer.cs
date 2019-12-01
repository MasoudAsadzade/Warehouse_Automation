using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCustomerVersionOfTehranRey.Classes
{
    public enum CustomerType
    {
        BazarCustomer,
        HomeCustomer,
        None
    }

    public class Customer
    {
        public string name;
        public string family;
        private string morrefName;
        private string phoneNumber;
        private string address;
        private DateTime startBussinessDate;
        public long customerCode;
        public CustomerType customertype;
        private CarpetList carpetList;
       

        public Customer(string Name, string Family, string MorrefName, string PhoneNumber, 
            string Address, DateTime StartBussinessDate, long CustomerCode, 
            CustomerType CustomerType, CarpetList CarpetList)
        {
            name = Name;
            family = Family;
            morrefName = MorrefName;
            phoneNumber = PhoneNumber;
            address = Address;
            startBussinessDate = StartBussinessDate;
            customerCode = CustomerCode;
            customertype = CustomerType;
            carpetList = CarpetList;
        }
    }
}
