using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstring
{
    internal class Program
    {

        public static class LongestSubstring
        {
            public static int LengthOfLongestSubstring(string s)
            {
                if (s.Length == 0) return 0;
                int max = int.MinValue;
                List<char> charSet = new List<char>();

                for (int i = 0; i < s.Length; i++)
                {
                    if (charSet.Contains(s[i]))
                    {
                        int index = 0;
                        while (charSet.Contains(s[i]))
                        {
                            charSet.RemoveAt(index);
                        }
                    }
                    charSet.Add(s[i]);
                    max = Math.Max(max, charSet.Count);
                }
                return max;
            }
        }

        static void Main(string[] args)
        {
            string s ="dvddf";
          int Result=  LongestSubstring.LengthOfLongestSubstring(s);
        }
    }
}
