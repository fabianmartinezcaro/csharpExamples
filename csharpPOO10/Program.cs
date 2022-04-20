namespace csharpPOO10
{

    class Program{

        public static void Main(string[] args)
        {
            
        Empleado juan = new Empleado(Bonus.Excelencia, 2500);
        System.Console.WriteLine(juan.GetSalario());

        }
    
    }

    enum Bonus {Bajo = 300, Normal = 500, Bueno = 1000, Excelencia = 2500};

}
