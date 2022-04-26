namespace csharpQueue{

    class Program{

        public static void Main(string[] args)
        {
            
            Queue<int> numeros = new Queue<int>();

            // ADDING ELEMENTS ON QUEUE
            foreach(int numero in new int[]{2,4,6,8,10,12}){

                numeros.Enqueue(numero);

            }

            // PRINTING THE ELEMENTS IN QUEUE
            System.Console.WriteLine("ADDING: \n");
            foreach(int numero in numeros){

                System.Console.WriteLine(numero);

            }
            System.Console.WriteLine("\n");



            // DELETING ELEMENTS IN QUEUE
            System.Console.WriteLine("DELETING: \n");
            numeros.Dequeue();

            foreach(int numero in numeros){

                System.Console.WriteLine(numero);

            }
            
            System.Console.WriteLine("\n");

            // GET THE OLDEST ELEMENT IN QUEUE
            System.Console.WriteLine(numeros.Peek());
            
        }

    }

}