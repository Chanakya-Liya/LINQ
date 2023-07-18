using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTestFile
{
    internal class Users
    {
        public int id;
        public string userName { set; get; }
        public string password { set; get; }

        public Users(int id, string userName, string password)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
        }
    }
}
