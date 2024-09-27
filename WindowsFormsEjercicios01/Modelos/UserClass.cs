using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace WindowsFormsEjercicios01.Modelos
{
    public class UserClass
    {
        private string Name;
        private string Password;

        public string getPassword()
        {
            return Password;
        }
        public string getName()
        {
            return Name;
        }

        public UserClass(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public bool Equals(UserClass obj)
        {
            if (obj.getName() == getName() && obj.getPassword() == getPassword())
            {
                return true;
            }
            return false;
        }

        public bool Equals(string un, string pwd)
        {
            if (un == getName() && pwd == getPassword())
            {
                return true;
            }
            return false;
        }

        public static bool usernameMatch(string un, string pwd, List<UserClass> userlist)
        {
            foreach (UserClass uc in userlist)

                if (uc.Equals(un, pwd))
                {
                    return true;
                }

            return false;

        }
        public static bool usernameMatch(UserClass uc, UserClass uc2)
        {
            MessageBox.Show("Unimplemented method");
            return false;

        }

    }

}
