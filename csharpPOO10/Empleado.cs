namespace csharpPOO10
{
    class Empleado
    {
        
        private double salario;
        private Bonus bonusEmpleado;
        
        public Empleado(Bonus bonusEmpleado, double salario){

            this.salario = salario;
            this.bonusEmpleado = bonusEmpleado;

        }

        public double GetSalario(){

            return this.salario + (double)bonusEmpleado;

        }

    }
}