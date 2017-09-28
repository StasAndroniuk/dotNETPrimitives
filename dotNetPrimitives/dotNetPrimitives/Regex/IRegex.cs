using System.Text.RegularExpressions;

namespace DotNetPrimitives.Regexes
{
    public interface IRegex
    {
        bool IsMatch(string str);
        Match Match(string str);
    }
}
