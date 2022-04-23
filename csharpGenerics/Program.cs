namespace csharpGenerics{
    
    class Program{

        public static void Main(string[] args)
        {
            // INSTANCIACIÓN DE CLASE STUDENT CON RESTRICCIÓN
            //EmployeeStorage<Student> student = new EmployeeStorage<Student>(1);
            EmployeeStorage<Electrician> electricians = new EmployeeStorage<Electrician>(3);
            electricians.AddEmployee(new Electrician(1500));
            electricians.AddEmployee(new Electrician(1850));
            electricians.AddEmployee(new Electrician(2500));
            System.Console.WriteLine(electricians.GetEmployee(0));

        }

    }

}
