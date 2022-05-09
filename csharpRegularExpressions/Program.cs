using System.Text.RegularExpressions;

namespace csharpRegularExpressions{
    class Program{

        public static void Main(string[] args){
            
            // PART 1

            // WE NEED A PATTERN
            string pattern = @"\d{3}";

            // WE ALSO NEED AN INPUT TO EVALUATE
            string input = "This this is a nice day. Adress: Shark 0345, Phone: (+34)376 29 38";

            // WE CREATE A REGEX INSTANCE
            Regex test = new Regex(pattern);

            // WE CREATE A MATCHCOLLECTION INSTANCE WHERE THE REGEX INSTANCE IS CALLED WITH THE INPUT INSIDE
            MatchCollection myMatch = test.Matches(input);

            // WE JUST PRINT WITH SOME CONDITIONALS ADDED
            if(myMatch.Count > 0)System.Console.WriteLine($"Se ha encontrado un numero de telefono");
            else System.Console.WriteLine("No se han encontrado.");



            // PART 2

            string newPattern = @"\+34|\+44";

            string newInput = "My phone numbers are (+34)769 36 97 and (+44)187 38 65";

            Regex test2 = new Regex(newPattern);

            MatchCollection blockedNumbers = test2.Matches(newInput);

            if(blockedNumbers.Count > 0) System.Console.WriteLine("We found 2 numbers blocked");
            else System.Console.WriteLine("Nothing here");




            string WEB_PATTERN = "https?://(www.)?google.com";

            string WEB_URL = "https://www.google.com";

            Regex WEB_AUTH_TESTER = new Regex(WEB_PATTERN);

            MatchCollection COLLETION_FOUNDED = WEB_AUTH_TESTER.Matches(WEB_URL);

            if(COLLETION_FOUNDED.Count > 0) System.Console.WriteLine("Pagina web encontrada.");
            else System.Console.WriteLine("No se ha encontrado ninguna web.");

        }

    }

}