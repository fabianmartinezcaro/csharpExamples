namespace csharpStacks{
    
    class Program{

        public static void Main(string[] args)
        {
            
            
            Stack<string> elements = new Stack<string>();
            
            //ADDING ELEMENTS INTO ELEMENTS STACK
            foreach(string element in new string[]{"Black", "White", "Green", "Red", "Blue"}){

                elements.Push(element);

            }


            //PRINTING ELEMENTS VALUES
            foreach(string element in elements){

                System.Console.WriteLine(element);

            }


            //DELETING AN ELEMENTS VALUE
            elements.Pop();

            System.Console.WriteLine("NEW LIST OF ELEMENTS: ");
            foreach(string element in elements){

                System.Console.WriteLine(element);

            }


        }

    }

}