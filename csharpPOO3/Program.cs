namespace csharpPOO3 {

    class Program {

        public static void Main(string[] args){

            Person persona = new Person();
            persona.Greet();

            Student estudiante = new Student();
            estudiante.setAge(20);            
            estudiante.Greet();
            estudiante.showAge();
            estudiante.Study();

            Professor profesor = new Professor();
            profesor.setAge(45);
            profesor.Greet();
            profesor.Explain();

        }

    }

}