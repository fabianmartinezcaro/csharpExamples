namespace csharpPOO9{

    class Program{

        public static void Main(string[] args)
        {
            
            Empleado empleado1 = new Empleado("Fabian");
            
            empleado1.SALARIO = 1200;

            System.Console.WriteLine(empleado1.GetSalario());

            empleado1.SALARIO += 3500;

            System.Console.WriteLine(empleado1.SALARIO);

        }

    }

}