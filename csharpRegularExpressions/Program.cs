using System.Text.RegularExpressions;

namespace csharpRegularExpressions{
    class Program{

        public static void Main(string[] args){
            
            string pattern = @"\d{3}-\d{2}-\d{2}";
            string input = "This this is a nice day. Adress: Shark 0345, Phone: (+34)376 29 38";

            Regex test = new Regex(pattern);
            MatchCollection myMatch = test.Matches(input);

            if(myMatch.Count > 0)System.Console.WriteLine($"Se ha encontrado un numero de telefono");
            else System.Console.WriteLine("No se han encontrado.");


        }

    }

}