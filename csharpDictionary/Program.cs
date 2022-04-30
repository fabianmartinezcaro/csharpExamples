namespace csharpDictionary{

    class Program{

        public static void Main(string[] args){
            
            //DICTIONARY DECLARATION
            Dictionary<int, string> elements = new Dictionary<int, string>();

            elements.Add(1001, "string1");
            elements.Add(1002, "string2");
            elements.Add(1003, "string3");
            
            // PRINTING KEY AND VALUE FROM ELEMENTS
            System.Console.WriteLine("Printing added elements: ");
            foreach(KeyValuePair<int, string> element in elements){

                System.Console.WriteLine("Key: {0}, Value: {1}", element.Key, element.Value);

            }
            
            elements.Remove(1001);
            
            System.Console.WriteLine("Printing element list without an element: ");
            foreach(KeyValuePair<int, string> element in elements){

                System.Console.WriteLine("Key: {0}, Value: {1}", element.Key, element.Value);

            }

        }

    }


}