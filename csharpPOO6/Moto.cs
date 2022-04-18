namespace csharpPOO6
{
    public class Moto : Vehiculo, IVehiculos, ICuatroPuertas, ITienePuertas
    {
        
        public int CantidadRuedas(){

            return 2;

        }

        int ICuatroPuertas.NumeroPuertas(){

            return 0;

        }

        int ITienePuertas.NumeroPuertas(){

            return 0;

        }

    }
}