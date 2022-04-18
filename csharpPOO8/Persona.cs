namespace csharpPOO8
{
    public class Persona:Mamiferos, IMamiferosTerrestres
    {

        public Persona(string nombrePersona): base(nombrePersona){     

        }
        
        public override void Pensar(){

            System.Console.WriteLine("Puedo pensar de manera avanzada");
            
        }

        public void Respirar(){

            System.Console.WriteLine("Puedo respirar");

        }

        public int NumeroPatas(){

            return 2;

        }



    }
}