namespace csharpPOO4{

    class Program{

        public static void Main(string[] args)
        {   

            int[] arrayElements = ReadData();
            System.Console.WriteLine("From Main");

            foreach(int element in arrayElements){

                System.Console.WriteLine(element);

            }

        }

        static int[] ReadData(){

            // CUANTOS ELEMENTOS TIENE EL ARRAY
            System.Console.WriteLine("Número de elementos: ");
            string input = Console.ReadLine();
            int inputProcessed = int.Parse(input);
            int[] data = new int[inputProcessed];

            // CUALES SON LOS VALORES DE EL ARRAY
            for (int i = 0; i < inputProcessed; i++){
                
                System.Console.WriteLine($"Ingrese el valor del índice {i}:");
                input = Console.ReadLine();
                int dataElements = int.Parse(input);
                data[i] = dataElements;

            }

            return data;

        }

    }

}