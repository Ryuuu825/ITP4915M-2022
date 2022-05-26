using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Utils
{
    public static class RandomId
    {
        public static readonly string Letter = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public static readonly string Number = "0123456789";
        public static readonly string Special = "!@#$%^&*()_+-=[]{}|;':,./<>?";

        public static string Generate(int length, bool useLetter = true, bool useNumber = true, bool useSpecial = true)
        {
            string result = "";
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                int rndNum = rnd.Next(0, 3);
                if (rndNum == 0)
                {
                    result += Letter[rnd.Next(0, Letter.Length)];
                }
                else if (rndNum == 1)
                {
                    result += Number[rnd.Next(0, Number.Length)];
                }
                else if (rndNum == 2)
                {
                    result += Special[rnd.Next(0, Special.Length)];
                }
            }
            return result;
        }

        public static string GenerateID(int length)
        {
            return Generate(length, false, true, false);
        }
    }
}
