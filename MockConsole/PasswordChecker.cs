using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CustomPasswordCheker
{
    public interface IUserRepositiry
    {
        int CreateUser(string password , string name);
        bool UserNameIsUsed(string name);
    }

    public class  PasswordChecker //: IUserRepositiry
    {
        private  IUserRepositiry _userRepositiry;
        private  string specSymbol = "A";

        public PasswordChecker(IUserRepositiry userRepositiry)
        {
            _userRepositiry = userRepositiry;
        }
        public  int Verify(string pass, string username, bool isAdmin)
        {

            if (VefifyEngine(pass, username, isAdmin))
            {
                var booked = _userRepositiry.UserNameIsUsed(username);
                if (!booked)
                {
                    return _userRepositiry.CreateUser(pass, username);
                }
            }
            return -1;
        }

        public  bool VefifyEngine(string password, string username, bool isAdmin)
        {
            if (isAdmin)
            {
                if (!(password.Contains(specSymbol) || password.Length > 10)) { return false; }
            }
            else
            {
                if (password.Length < 7) { return false; }
            }

            var checkConteinsAlp = new Regex(@"[a-zA-Z]+");
            var checkConteinsDig = new Regex(@"[0-9]+");

            var alpRes = checkConteinsAlp.Match(password);
            var digRes = checkConteinsDig.Match(password);

            return (alpRes.Length > 0 && digRes.Length > 0);
        }
    }
}
