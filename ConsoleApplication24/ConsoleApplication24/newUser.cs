using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    public class newUser
    {
        string _userName;
        string _passWord;

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = UserName;
            }
        }

        public string PassWord
        {
            get
            {
                return _passWord;
            }

            set {
                _passWord = PassWord;
            }
        }
        public newUser(string userName, string passWord)
        {
            userName = UserName;
            passWord = PassWord;
        }
    }
}
