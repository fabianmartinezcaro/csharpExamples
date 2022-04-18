namespace csharpPOO5
{
    public class CuentaBancaria
    {
        protected string nombreTitular;
             protected int numeroCuenta;
             protected double saldo;
             protected int contador; 

             public CuentaBancaria (string nombreTitular) {

                this.nombreTitular = nombreTitular;
                this.saldo = 0;
                this.numeroCuenta = this.numeroCuenta + 1;
                contador+=1;

             }

             public void Credito(double credito){

                this.saldo = this.saldo + credito;

             }

             public void Debito(double debito){

                this.saldo = this.saldo - debito;

             }

             public void ConsultarSaldo(){

                System.Console.WriteLine($"Tu saldo es de {this.saldo}");

             }

             public void GetInfo(){

                System.Console.WriteLine($"{this.numeroCuenta}, {this.contador}");

             }
    }
}