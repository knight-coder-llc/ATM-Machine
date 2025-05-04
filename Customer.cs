using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    class Customer
    {
        int id;
        string name;
        public Customer(int num, string name)
        {
            id = num;
            this.name = name;
        }

        public int getID()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
    }
}
