namespace csharpPOO7{
    
    class Program{

        public static void Main(string[] args){

            AvisosTrafico nuevo1 = new AvisosTrafico();
            System.Console.WriteLine(nuevo1.ObtenerFecha());
            nuevo1.MostrarAviso();

        }

    }

}