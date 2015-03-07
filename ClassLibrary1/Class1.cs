using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class PasswordChecker
    {
        public 

        private static string specSymbol = "A";

        public static bool verify(string pass , string username , bool isAdmin)
        {

            if (isAdmin)
            {
                string adminPattern = @"\d{1,}[a-zA-Z{1,}]";
                var reg = new Regex(adminPattern);

                var a = reg.Match(pass);
                return true;
            }
            else
            {
                string simplePattern = @"\d{1,}[a-zA-Z{1,}]";
                var reg = new Regex(simplePattern);
                var a = reg.Match(pass);
                return true;
            }
        }
    }
}