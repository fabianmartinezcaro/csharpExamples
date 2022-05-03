namespace exercisesPredicate
{
    public class Employee{

        private string name {get; set;}
        private int age {get; set;}


        public Employee(string name, int age){

            this.name = name;
            this.age = age;

        }

        public static void Task(){

            System.Console.WriteLine("I'm working with some account papers!");

        }


        public override string ToString(){

            return $"Hey! I'm an Employee, my name is {name} and I am {age} years old";

        }

    }
}