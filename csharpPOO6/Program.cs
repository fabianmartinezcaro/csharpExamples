namespace csharpPOO6{

    class Program{

        public static void Main(string[] args)
        {

            System.Console.WriteLine("AVION:");
            Avion avion1 = new Avion();
            avion1.Conducir();

            System.Console.WriteLine("AUTO:");
            Auto auto1 = new Auto();
            auto1.Conducir();

            System.Console.WriteLine("MOTO:");
            Moto moto1 = new Moto();
            moto1.Conducir();

            Vehiculo miVehiculo = auto1;
            Avion helloworld = new Avion();
            miVehiculo = helloworld;

            Barco barco1 = new Barco();
            barco1.Conducir();

            moto1.CantidadRuedas();
            helloworld.CantidadRuedas();

            System.Console.WriteLine(auto1.NumeroPuertas());
            
            ITienePuertas avion = avion1;
            avion.NumeroPuertas();
            avion1.NumeroPuertas();
            
        }

    }

}