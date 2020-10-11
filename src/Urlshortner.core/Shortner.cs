using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Urlshortner.core
{
    public class Shortner
    {
        private const string Alphabet = "23456789abcdfghjkmnpqrstvwxyzABCDFGHJKLMNPQRSTVWXYZ-_";
        private static readonly int Base = Alphabet.Length;

        public string Encode(int num)
        {
            var sb = new StringBuilder();
            while (num > 0)
            {
                sb.Insert(0, Alphabet.ElementAt(num % Base));
                num = num / Base;
            }
            return sb.ToString();
        }

        public int Decode(string token)
        {
            var num = 0;
            for (var i = 0; i < token.Length; i++)
            {
                num = num * Base + Alphabet.IndexOf(token.ElementAt(i));
            }
            return num;
        }
    }
}
