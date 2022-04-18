namespace csharpPOO9
{
    public class Empleado
    {

        private string nombre;
        private double salario;

        // METODO DE CONTROL
        private double evaluarSalario(double salario){

            if (salario < 0) return 0;
            else return salario;

        }

        // PROPERTY
        /*public double SALARIO{

            get{return this.salario;}
            set{this.salario = evaluarSalario(value);}

        }*/

        public double SALARIO{

            get=>this.salario;
            set=>this.salario = evaluarSalario(value);

        }
        
        public Empleado(string nombre){

            this.nombre = nombre;

        }

        public void SetSalario(double salario){

            if(salario < 0){

                System.Console.WriteLine("El salario no puede ser negativo, se le asignará por defecto 0");
                this.salario = 0;

            }else{

                this.salario = salario;

            }

        }

        public double GetSalario(){

            return salario;
            
        }

    }
}