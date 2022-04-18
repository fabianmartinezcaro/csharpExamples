namespace csharpPOO8
{
    public class Lagartija:Animales, IMamiferosTerrestres
    {

        private string nombreReptil;

        public Lagartija(string nombre){

            this.nombreReptil = nombre;

        }

        public override void getNombre()
        {
            
            System.Console.WriteLine("El nombre del reptil es: " + nombreReptil);

        }

        public void Respirar(){

            System.Console.WriteLine("Puedo respirar");

        }

        public int NumeroPatas(){

            return 4;

        }

    }
}