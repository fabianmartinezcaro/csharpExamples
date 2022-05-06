using System.Text.RegularExpressions;

namespace csharpRegularExpressions{
    class Program{

        public static void Main(string[] args){
            
            string pattern = @"\b(\w+?)\s\1\b";
            string input = "This this is a nice day. What about this? This tastes good. I saw a a dog.";

            foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
                    Console.WriteLine("{0} (duplicates '{1}') at position {2}",  match.Value, match.Groups[1].Value, match.Index);

            
            string pattern2 = @"[ae]";
            string input2 = "this is a good day to start doing some work";

            foreach (Match match in Regex.Matches(input2, pattern2, RegexOptions.IgnoreCase))
                    System.Console.WriteLine("{0}, {1}, {2}", match.Value, match.Groups[1], match.Index);

        }

    }

}