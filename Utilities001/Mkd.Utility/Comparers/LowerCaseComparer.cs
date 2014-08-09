using System;
using System.Collections.Generic;

namespace Mkd.Utility
{
    public class LowerCaseComparer : IEqualityComparer<string>
    {
        public bool Equals(string x , string y)
        {
            return String.Equals(x , y , StringComparison.CurrentCultureIgnoreCase);
        }

        public int GetHashCode(string obj)
        {
            return obj.GetHashCode();
        }
    }
}