namespace exercisesPredicate
{

    class Program{

        public static void Main(string[] args){

            // CREATING A LIST OF EMPLOYEES
            List<Employee> employees = new List<Employee>();

            // ADDING EMPLOYEES
            employees.Add(new Employee("Joseph", 34));
            employees.Add(new Employee("Sarah", 18));
            employees.Add(new Employee("John", 19));
            employees.Add(new Employee("Matt", 39));
            employees.Add(new Employee("Ron", 21));
            employees.Add(new Employee("Alexander", 20));
            employees.Add(new Employee("Joseph", 37));

            // INIT A PREDICATE
            Predicate<Employee> employeePredicate = new Predicate<Employee>(OlderEmployees);

            // FILTERING BY OLDEREMPLOYEE FUNCTION
            List<Employee> selectedEmployees = employees.FindAll(employeePredicate);

            // SELECTED EMPLOYEES
            System.Console.WriteLine("EMPLOYEE PREDICATE: ");
            foreach(Employee selectedEmployee in selectedEmployees){

                System.Console.WriteLine(selectedEmployee.ToString());

            }


            // EMPLOYEE INFORMATION
            System.Console.WriteLine("EMPLOYEE INFORMATION: ");
            foreach(Employee employee in employees){

                System.Console.WriteLine(employee.ToString());

            }

            System.Console.WriteLine("\n");


            // EMPLOYEE AGE VALIDATION
            System.Console.WriteLine("EMPLOYEE AGE VALIDATION: "); 
            foreach(Employee employee in employees){

                System.Console.WriteLine(employee.ToString() + " | VALIDATION: " + OlderEmployees(employee));

            }

            
            // OUTPUTS

                /*

                EMPLOYEE PREDICATE: 
                
                Hey! I'm an Employee, my name is Joseph and I am 34 years old
                Hey! I'm an Employee, my name is Matt and I am 39 years old
                Hey! I'm an Employee, my name is Joseph and I am 37 years old
                */

                /* 

                EMPLOYEE INFORMATION 

                Hey! I'm an Employee, my name is Joseph and I am 34 years old
                Hey! I'm an Employee, my name is Sarah and I am 18 years old
                Hey! I'm an Employee, my name is John and I am 19 years old
                Hey! I'm an Employee, my name is Matt and I am 39 years old
                Hey! I'm an Employee, my name is Ron and I am 21 years old
                Hey! I'm an Employee, my name is Alexander and I am 20 years old
                Hey! I'm an Employee, my name is Joseph and I am 37 years old*/

                /*

                EMPLOYEE AGE VALIDATION

                Hey! I'm an Employee, my name is Joseph and I am 34 years old | VALIDATION: True
                Hey! I'm an Employee, my name is Sarah and I am 18 years old | VALIDATION: False
                Hey! I'm an Employee, my name is John and I am 19 years old | VALIDATION: False
                Hey! I'm an Employee, my name is Matt and I am 39 years old | VALIDATION: True
                Hey! I'm an Employee, my name is Ron and I am 21 years old | VALIDATION: False
                Hey! I'm an Employee, my name is Alexander and I am 20 years old | VALIDATION: False
                Hey! I'm an Employee, my name is Joseph and I am 37 years old | VALIDATION: True*/


        }



        // CONDITION EMPLOYEE AGE > 25
            static bool OlderEmployees(Employee employee){

                if (employee.GetAge() > 25) return true;
                else return false;

            }

    }
    
}