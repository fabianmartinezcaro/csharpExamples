namespace csharpPOO11{

    class Program{

        public static void Main(string[] args)
        {

        AlmacenObjetos<DateTime> fechas = new AlmacenObjetos<DateTime>(1);
            
        AlmacenObjetos<Empleado> archivos = new AlmacenObjetos<Empleado>(4); 
        archivos.Agregar(new Empleado(1500));
        archivos.Agregar(new Empleado(2304));
        archivos.Agregar(new Empleado(3000));
        archivos.Agregar(new Empleado(900));
        fechas.Agregar(new DateTime());

        Empleado empleado = archivos.ObtenerElemento(1);
        System.Console.WriteLine(empleado.ObtenerSalario());
        System.Console.WriteLine(fechas);


        }

    }

    class AlmacenObjetos<T> {

        public AlmacenObjetos(int z){

            datosElemento = new T[z];

        }

        public void Agregar(T obj){

            datosElemento[i] = obj;
            i++;

        }

        public T ObtenerElemento(int i){

            return datosElemento[i];

        }

        private T[] datosElemento;
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