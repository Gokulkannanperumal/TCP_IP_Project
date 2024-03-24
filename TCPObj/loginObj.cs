using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPObj
{
    [Serializable]
    public class loginObj
    {

        public string username;

        public string _username
        {
            get { return username; }
            set { username = value; }
        }

        public string password;

        public string _password
        {
            get { return password; }
            set { password = value; }
        }


    }
}
