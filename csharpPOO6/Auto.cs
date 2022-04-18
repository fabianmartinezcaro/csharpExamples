namespace csharpPOO6
{
    public class Auto : Vehiculo, IVehiculos, ICuatroPuertas
    {

        public override void Conducir(){

            System.Console.WriteLine("Conduciendo auto...");

        }

        public void Acelerar(){

            System.Console.WriteLine("Acelerando...");

        }

        public void Frenar(){

            System.Console.WriteLine("Frenando...");

        }

        public int CantidadRuedas(){

            return 4;

        }

        public int NumeroPuertas(){

            return 4;

        }
        
    }
}