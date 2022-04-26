namespace csharpGenerics
{
    public class Secretary: IOnlyEmployees
    {
        
        private double salary;
        public Secretary(double salary){

            this.salary = salary;

        }
        
        public double GetSalary(){

            return salary;

        }

    }
}