using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_start.BusinessLayer
{
   public class UserInfo
    {
        private string username;
        private string password;
        private string completeName;
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string CompleteName
        {
            get
            {
                return completeName;
            }

            set
            {
                completeName = value;
            }
        }

        public UserInfo()
        {
            this.username = "";
            this.password = "";
            this.completeName = "";
        }
    }
}
