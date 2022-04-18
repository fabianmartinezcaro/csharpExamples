namespace csharpPOO8
{
    public class Caballo:Mamiferos, IMamiferosTerrestres
    {
        
        public Caballo(string nombreCaballo): base(nombreCaballo){


        }

        public void Galopar(){

            System.Console.WriteLine("Puedo galopar!");

        }

        public void Respirar(){

            System.Console.WriteLine("Puedo respirar");

        }

        public int NumeroPatas(){

            return 4;

        }

    }
}