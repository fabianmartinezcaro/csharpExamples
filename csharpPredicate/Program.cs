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

            Person GeorgeExist = new Person();
            GeorgeExist.name = "George";

            people.AddRange(new Person[]{JohnExist, TimExist, GeorgeExist});

            Predicate<Person> person = new Predicate<Person>(JohnExist);

            bool personExist = people.Exists(person);


        }

    }

}