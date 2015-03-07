using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;

namespace Consoletest
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = PasswordChecker();
            var b = a.verify("abcd1234", "ad", true);
            int adfsfh = 0;
        }
    }
}
