using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace HomeCustomerVersionOfTehranRey.Classes
{
    public class CarpetList
    {
        private ArrayList listCarpet;

        public CarpetList()
        {
            listCarpet = new ArrayList();
        }

        public void Add( Carpet carpet)
        {
            listCarpet.Add(carpet);
        }

    }
}
