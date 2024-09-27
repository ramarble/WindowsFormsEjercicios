using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsEjercicios01.Modelos;

namespace WindowsFormsEjercicios01.Controladores
{
    internal static class DataUsers
    {
        public static List<UserClass> userlist = new List<UserClass>(); 
        public static List<UserClass> populateUserlist(List<UserClass> userlist)
        {
            userlist.Add(new UserClass("admin", "12345"));
            userlist.Add(new UserClass("test", "123"));

            return userlist;
        }

        public static List<UserClass> addUserClass(List<UserClass> userlist, string un, string pwd)
        {
            userlist.Add(new UserClass(un, pwd));
            return userlist;
        }

    }
}
