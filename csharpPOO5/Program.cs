namespace csharpPOO5{

    class Program{

        public static void Main(string[] args){
            
        CuentaBancaria primera = new CuentaBancaria("Jose Gomez");
        primera.GetInfo();
        primera.Credito(10.358);
        primera.ConsultarSaldo();
        primera.Debito(5.590);
        primera.ConsultarSaldo();
        CuentaBancaria segunda = new CuentaBancaria("Test");
        segunda.Credito(20.990);
        segunda.GetInfo();
        CuentaBancaria tercera = new CuentaBancaria("TEST 3");
        tercera.GetInfo();
            
        } 


    }

}