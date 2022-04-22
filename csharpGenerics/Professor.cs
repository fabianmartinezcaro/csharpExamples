namespace csharpGenerics
{
    public class Professor: IOnlyEmployees
    {

        private double salary;
    
        public Professor(double salary){

            this.salary = salary;
            
        }

        public double GetSalary(){

            return salary;

        }

    }
}