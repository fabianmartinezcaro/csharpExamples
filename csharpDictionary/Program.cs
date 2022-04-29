namespace csharpDictionary{

    class Program{

        public static void Main(string[] args){
            
            //DICTIONARY DECLARATION
            Dictionary<int, string> elements = new Dictionary<int, string>();

            elements.Add(1001, "Juan");
            elements.Add(1002, "Jaime");
            elements.Add(1003, "Vicente");
            
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