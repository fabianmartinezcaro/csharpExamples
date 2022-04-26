namespace csharpLinkedList
{
    public class EmployeeStorage<T> where T: IOnlyEmployees
    {

        private int i=0;
        private T[] dataEmployees;


        public EmployeeStorage(int salary){

            dataEmployees = new T[salary];

        }

        public void AddEmployee(T employee){

            dataEmployees[i] = employee;
            i++;

        }

        public T GetEmployee(int i){

            return dataEmployees[i];

        }


        
    }
}