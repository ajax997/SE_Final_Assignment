using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Management
{
    class UserLogin
    {
        public int staff_id
        {
            get; set;
        }
        public string password
        {
            get; set;
        }
        public string fullname
        {
            get; set;
        }
        public int sex
        {
            get; set;
        }
        public string DOB
        {
            get; set;
        }
        public string phone
        {
            get; set;
        }
        public string address
        {
            get; set;
        }
        public int admin
        {
            get;set;
        }
        public string permission
        {
            get;set;
        }


        public UserLogin(int staff_id, string password, string fullname, int sex, string DOB, string phone, string address, int admin)
        {
            this.staff_id = staff_id;
            this.password = password;
            this.fullname = fullname;
            this.sex = sex;
            this.DOB = DOB;
            this.phone = phone;
            this.address = address;
            this.admin = admin;
           
        }
    }
}
