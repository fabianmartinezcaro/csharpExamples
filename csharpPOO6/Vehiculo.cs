namespace csharpPOO6
{
    public class Vehiculo
    {
        
        public virtual void Conducir(){

            System.Console.WriteLine("Conduciendo...");

        }

        public void ArrancarMotor(){

            System.Console.WriteLine("Motor iniciado...");

        }

        public void PararMotor(){

            System.Console.WriteLine("Motor detenido...");

        }

    }
}