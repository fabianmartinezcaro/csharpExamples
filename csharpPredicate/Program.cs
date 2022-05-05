namespace csharpPredicate
{
    
    class Program{

        public static void Main(string[] args){
            
            List<Person> people = new List<Person>();

            Person JohnExist = new Person();
            JohnExist.name = "John";
            JohnExist.age = 18;

            Person TimExist = new Person();
            TimExist.name = "Tim";
            TimExist.age = 23;

            Person GeorgeExist = new Person();
            GeorgeExist.name = "George";
            GeorgeExist.age = 34;


            people.AddRange(new Person[]{JohnExist, TimExist, GeorgeExist});

            Predicate<Person> person = new Predicate<Person>(PeopleExist);

            bool personExist = people.Exists(person);
            if (personExist) System.Console.WriteLine("Existen personas llamadas Tim");
            else System.Console.WriteLine("No hay personas llamadas Tim en la lista");

            
            
            
            static bool PeopleExist(Person person){

                if (person.name == "Tim") return true;
                else return false;


            }
            


        }

    }

}