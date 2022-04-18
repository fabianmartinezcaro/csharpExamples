namespace csharpPOO7
{
    public class AvisosTrafico:IAvisos
    {   

        private string remitente;
        private string mensaje;

        public AvisosTrafico(){

            remitente = "Carabineros De Chile";
            mensaje = "Se ha detectado una infracción";

        }

        public AvisosTrafico(string remitente, string mensaje){

            this.remitente = remitente;
            this.mensaje = mensaje;

        }
        
        public void MostrarAviso(){

            System.Console.WriteLine($"Enviado por: {remitente} | Mensaje: {mensaje} | Fecha: 12-03-23");

        }

        public DateTime ObtenerFecha(){

            return System.DateTime.Now;

        }


    }   
}