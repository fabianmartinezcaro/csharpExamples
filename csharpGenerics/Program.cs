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
            System.Console.WriteLine(electricians.GetEmployee(0).GetSalary());

            EmployeeStorage<Manager> manager = new EmployeeStorage<Manager>(3);
            manager.AddEmployee(new Manager(3500));
            manager.AddEmployee(new Manager(2500));
            manager.AddEmployee(new Manager(5500));
            System.Console.WriteLine(manager.GetEmployee(1).GetSalary());

            EmployeeStorage<Secretary> secretaria = new EmployeeStorage<Secretary>(2);
            secretaria.AddEmployee(new Secretary(1000));
            secretaria.AddEmployee(new Secretary(950));
            System.Console.WriteLine(secretaria.GetEmployee(1).GetSalary());


        }

    }

}
