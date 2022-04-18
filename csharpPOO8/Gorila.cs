namespace csharpPOO8
{
    public class Gorila:Mamiferos, IMamiferosTerrestres
    {        
        public Gorila(string nombreGorila): base(nombreGorila){


        }

        public void Trepar(){

            System.Console.WriteLine("Puedo trepar!");

        }

        public void Respirar(){

            System.Console.WriteLine("Puedo respirar");

        }

        public int NumeroPatas(){

            return 2;

        }


    }
}