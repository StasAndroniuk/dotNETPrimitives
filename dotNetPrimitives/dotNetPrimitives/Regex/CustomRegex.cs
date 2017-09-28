using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DotNetPrimitives.Regexes
{
    public class CustomRegex:IRegex
    {   public Regex RegexItem { get; set; }
        public bool IsMatch(string str)
        {
            return RegexItem.IsMatch(str);
        }

        public Match Match(string str)
        {
            return RegexItem.Match(str);
        }
    }
}
