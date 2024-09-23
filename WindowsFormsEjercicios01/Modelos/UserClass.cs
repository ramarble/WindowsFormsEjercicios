using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace WindowsFormsEjercicios01.Modelos
{
    public class UserClass
    {
        private string Name;
        private string Password;
        public string getPassword() {
            return this.Password;
        }
        public string getName()
        {
            return this.Name;
        }

        public UserClass(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public bool Equals(UserClass obj)
        {
            if (obj.getName() == this.getName() && obj.getPassword() == this.getPassword())
            {
                return true;
            }
            return false;
        }

        public bool Equals(string un, string pwd)
        {
            if (un == this.getName() && pwd == this.getPassword())
            {
                return true;
            }
            return false;
        }

        static List<UserClass> userlist = new List<UserClass>();

        public static List<UserClass> getUserList()
        {
            return userlist;
        }

        public static void populateUserlist()
        {
            userlist.Add(new UserClass("admin", "12345"));
            userlist.Add(new UserClass("test", "123"));

        }
        public static Boolean usernameMatch(string un, string pwd)
        {
            foreach (UserClass uc in userlist)
            
                if (uc.Equals(un, pwd)) {
                    
                    return true;
                
                }
                
            return false;

            }
        }
    }
