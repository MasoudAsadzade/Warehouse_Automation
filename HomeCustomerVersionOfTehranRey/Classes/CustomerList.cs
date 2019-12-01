using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace HomeCustomerVersionOfTehranRey.Classes
{
    public class CustomerList
    {
        private ArrayList listCustomer;

        public CustomerList()
        {
            listCustomer = new ArrayList();
        }

        public Customer getCustomer(int arraylistIndex)
        {
            return (Customer)listCustomer[arraylistIndex];
        }

        public void Edit(Customer firstCustomer, Customer secondCustomer)
        {
            int customerIndex = listCustomer.IndexOf(firstCustomer);
            listCustomer[customerIndex] = secondCustomer;
        }


        public int getCount()
        {
            return (listCustomer.Count);
        }
        public void Add(Customer customer)
        {
            listCustomer.Add(customer);
           
        }
        public Customer findByName(String name)
        {
            for (int i = 0; i < listCustomer.Count; i++)
            {
                Customer temp = (Customer)listCustomer[i];
                if (temp.name == name)
                {
                    return temp; 
                }
            }
            return null;
            
        }
    }
}
