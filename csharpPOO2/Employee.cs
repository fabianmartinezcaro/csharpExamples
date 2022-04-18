namespace csharpPOO2
{
    public class Employee
    {
        
        private string Name;
        private string Email;
        private int Age;

        public Employee(string name, string email, int age){

            this.Name = name;
            this.Email = email;
            this.Age = age;

        }

        public string GetInfo(){

            return $"Name={Name}\nEmail={Email}\nAge={Age}";

        }

    }
}