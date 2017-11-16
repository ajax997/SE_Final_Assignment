using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Management
{
    class UserLogin
    {
        public string username
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

        public UserLogin(string username, string password, string fullname, string dOB, string phone, string address, int admin, string permission)
        {
            this.username = username;
            this.password = password;
            this.fullname = fullname;
            DOB = dOB;
            this.phone = phone;
            this.address = address;
            this.admin = admin;
            this.permission = permission;
        }
    }
}
