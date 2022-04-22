namespace csharpPOO11{

    class Program{

        public static void Main(string[] args)
        {
            
        AlmacenObjetos archivos = new AlmacenObjetos(4); 
        archivos.Agregar(new Empleado(1500));
        archivos.Agregar(new Empleado(2304));
        archivos.Agregar(new Empleado(3000));
        archivos.Agregar(new Empleado(900));

        Empleado empleado = (Empleado)archivos.ObtenerElemento(1);
        System.Console.WriteLine(empleado.ObtenerSalario());


        }

    }

    public class AlmacenObjetos{

        public AlmacenObjetos(int z){

            datosElemento = new Object[z];

        }

        public void Agregar(Object obj){

            datosElemento[i] = obj;
            i++;

        }

        public Object ObtenerElemento(int i){

            return datosElemento[i];

        }

        private Object[] datosElemento;
        private int i = 0;

    }

    public class Empleado{

        private double salario;

        public Empleado(double salario){

            this.salario = salario;

        }

        public double ObtenerSalario(){

            return this.salario;

        }




    }

}