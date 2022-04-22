namespace csharpGenerics
{
    public class Electrician: IOnlyEmployees
    {
        
        private double salary;

        public Electrician(double salary){

            this.salary = salary;

        }

        public double GetSalary(){

            return salary;

        }


    }
}