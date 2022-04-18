namespace csharpPOO2
{
    public class Punto
    {

        // PROPIEDADES DE LA CLASE PUNTO
        private int x;
        private int y;
        private static int contadorDeObjetos = 0;

        //CONSTRUCTOR POR DEFECTO
        public Punto(){

            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;

        }

        // CONSTRUCTOR PERSONALIZADO
        public Punto(int x, int y){

            this.x = x;
            this.y = y;
            contadorDeObjetos++;

        }

        // RETORNO DE EL CONTADOR DE OBJETOS
        public static int ContadorDeObjetos() => contadorDeObjetos;

        // CALCULO DE LA DISTANCIA ENTRE LOS PUNTOS
        public double distanciaHasta(Punto otroPunto){

            double xDif = this.x - otroPunto.x;
            double yDif = this.y = y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return distanciaPuntos;

        }
    }
}