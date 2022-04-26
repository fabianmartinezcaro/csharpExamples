namespace csharpCollections{

    class Program{

        public static void Main(string[] args)
        {
            
            List<int> numeros = new List<int>();

            int elemento = 1;

            System.Console.WriteLine("Para salir pulse 0");
            while(elemento != 0){

                System.Console.WriteLine("Ingrese un número: ");
                elemento = Int32.Parse(Console.ReadLine());
                numeros.Add(elemento);

            }        

            numeros.RemoveAt(numeros.Count-1);

            System.Console.WriteLine("Lista: ");
            foreach(int numero in numeros){

                System.Console.WriteLine(numero);

            }

        }

    }

}
