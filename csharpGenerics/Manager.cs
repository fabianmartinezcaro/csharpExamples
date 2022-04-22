namespace csharpGenerics
{
    public class Manager: IOnlyEmployees
    {

    private double salary;

        public Manager(double salary){

            this.salary = salary;

        }

        public double GetSalary(){

            return salary;

        }



    }
}