using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Management
{
    class Customer
    {
       public string name { get; set; }
       public string dob { get; set; }
        public int sex { get; set; }
       public int status { get; set; }
       public string phone { get; set; }
      public  string address { get; set; }

        public Customer(string name, string dob, int sex, int status, string phone, string address)
        {
            this.name = name;
            this.dob = dob;
            this.sex = sex;
            this.status = status;
            this.phone = phone;
            this.address = address;
        }
    }
}
