using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Haven_System_Ad.Forms
{
    class UserSession
    {
        private static UserSession _instance;

        public string Username { get; private set; }
        public string Role { get; private set; }

        private UserSession() { }

        public static UserSession Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserSession();
                }
                return _instance;
            }
        }

        public void SetUser(string username, string role)
        {
            Username = username;
            Role = role;
        }

        public void Logout()
        {
            Username = null;
            Role = null;
        }
    }
}
