namespace csharpPOO3
{
    public class Student : Person
    {
        
        public void Study(){

            Console.WriteLine("Im studying!");

        }

        public void showAge(){

            Console.WriteLine($"My age is: {Age} years old.");

        }

    }
}