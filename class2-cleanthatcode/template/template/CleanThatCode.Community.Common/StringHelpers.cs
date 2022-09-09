using System.Linq;

namespace CleanThatCode.Community.Common
{
    // Your job is to implement this class
    public static class StringHelpers
    {
        // Instead of spaces it should be separated with dots, e.g. Hello World -> Hello.World
        public static string ToDotSeparatedString(this string str)
        {
            return str.Replace(" ", ".");
        }

        // All words in the string should be capitalized, e.g. teenage mutant ninja turtles -> Teenage Mutant Ninja Turtles
        public static string CapitalizeAllWords(this string str)
        {
            str = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
            return str;
        }

        // The words should be reversed in the string, e.g. Hi Ho Silver Away! -> Away! Silver Ho Hi
        public static string ReverseWords(this string str)
        {
            int temp;
            string a = "";
            string[] s = str.Split(' ');
            int k = s.Length - 1;
            temp = k;
            for (int i = k; temp >= 0; k--) {
                if (temp > 0) {
                    a += s[temp] + "" + ' ';
                    --temp;
                }
                else {
                    a += s[temp];
                    --temp;
                }
            }
            return a;
        }
    }
}