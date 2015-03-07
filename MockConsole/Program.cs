using System;
using System.Collections.Generic;
using System.Text;


namespace CustomPasswordCheker
{
    internal class foo : IUserRepositiry
    {

        public int CreateUser(string password, string name)
        {
            return 42;
        }

        public bool UserNameIsUsed(string name)
        {
            return false;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            var pass = new PasswordChecker(new foo());
            var adsf = pass.Verify("1234567890aA", "user", true);
        }
    }
}
