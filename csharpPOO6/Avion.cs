namespace csharpPOO6
{
    public class Avion : Vehiculo, IVehiculos, ITienePuertas
    {
        
        public override void Conducir(){

            System.Console.WriteLine("Piloteando avion...");

        }

        public void Despegar(){

            System.Console.WriteLine("El avion va a despegar...");
            System.Threading.Thread.Sleep(4000);
            System.Console.WriteLine("Avion en vuelo.");

        }

        public void Aterrizar(){

            System.Console.WriteLine("Aterrizando...");
            System.Threading.Thread.Sleep(4000);
            System.Console.WriteLine("El avion ha aterrizado.");

        }

        public int CantidadRuedas(){

            return 12;

        }

        public int NumeroPuertas(){

            return 2;

        }  

    }
}