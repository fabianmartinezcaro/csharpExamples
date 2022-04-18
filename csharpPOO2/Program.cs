using System;
using static System.Math;

namespace csharpPOO2{

    class Program{

        public static void Main(string[] args)
        {
            /*realizarTarea();
            double raiz = Math.Sqrt(9);
            double potencia = Math.Pow(3, 4);

            System.Console.WriteLine(raiz);
            System.Console.WriteLine(potencia);*/

            // CLASE ANONIMA
            //var data = new {Nombre = "Fabian", Edad = 24};
            //System.Console.WriteLine(data.Edad);

            Employee[] trabajador = new Employee[3];
            trabajador[0] = new Employee("Joseph", "JosephG1997@gmail.com", 24);
            trabajador[1] = new Employee("Anna", "anna.gomez@gmail.com", 31);
            trabajador[2] = new Employee("Paula", "paulagibbons@gmail.com", 25);
            var Emp_Joseph = trabajador[0];
            var Emp_Anna = trabajador[1];
            var Emp_Paula = trabajador[2];
            
            foreach (Employee empleado in trabajador){

                System.Console.WriteLine($"{empleado.GetInfo()}\n");

            }

        }

        static void realizarTarea(){

            Punto origen = new Punto();
            Punto destino = new Punto(38, 64);

            double distancia = origen.distanciaHasta(destino);

            Console.WriteLine($"La distancia entre los dos puntos es de {Math.Round(distancia, 2)}");
            Console.WriteLine(Punto.ContadorDeObjetos());

        }



    }


}
