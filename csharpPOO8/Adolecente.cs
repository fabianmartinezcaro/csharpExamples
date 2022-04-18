namespace csharpPOO8
{
    public class Adolecente:Persona
    {
        
        public Adolecente(string nombreAdolecente): base(nombreAdolecente){

        }

        public override void Pensar(){

            System.Console.WriteLine("Las hormonas me impiden pensar con claridad");

        }

    }
}