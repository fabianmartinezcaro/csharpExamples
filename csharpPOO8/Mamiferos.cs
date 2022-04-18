namespace csharpPOO8
{
    public class Mamiferos:Animales
    {

        private string NombreSerVivo;

        public Mamiferos(string NombreSerVivo){

            this.NombreSerVivo = NombreSerVivo;

        }

        public override void getNombre(){

            System.Console.WriteLine("Soy un mamifero llamado: " + NombreSerVivo);

        }
        
        public void CuidarCrias(){

            System.Console.WriteLine("Cuidando crias");

        }

        public virtual void Pensar(){

            System.Console.WriteLine("Pensar de forma basica");

        }
        

    }
}