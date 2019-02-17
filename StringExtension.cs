using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace PadawansTask12
{
    public static class StringExtension
    {
        public static bool AllCharactersAreUnique(string source)
        {
            if (source == null) 
                throw new ArgumentNullException();
            if(source.Length == 0)
                throw new ArgumentException();

            List<char> resultList = new List<char>();
            foreach (char ch in source)
            {
                if (!resultList.Contains(ch))
                    resultList.Add(ch);
                else
                    return false;
            }

            return true;
        }
    }
}