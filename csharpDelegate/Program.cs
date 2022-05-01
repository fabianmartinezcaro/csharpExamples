namespace csharpDelegate{

    class Program{

        public static void Main(string[] args){
            

            //      DELEGATES
            // Creating new delegate instance pointing to WelcomeMessage
            DelegatedObject test = new DelegatedObject(WelcomeMessage.Greeting);

            // Using delegate calling the WelcomeMessage method
            test();

            // Changing the pointer to GoodbyeMessage
            test=new DelegatedObject(Goodbye.GoodbyeMessage);
            
            // Testing the new pointer
            test();





            //      PREDICATED DELEGATES
            //      PAIR NUMBERS
            static bool PairNumbers(int num){

                if (num % 2 == 0) return true;
                else return false;

            }

            System.Console.WriteLine("PAIR NUMBERS");
            // WE CREATE A NEW LIST 
            List<int> numbers = new List<int>();

            // WE ADD A RANGE OF NUMBERS
            numbers.AddRange(new int[]{1,2,3,4,5,6,7,8,9,10});

            // WE START A PREDICATE POINTING TO PAIRNUMBERS METHOD
            Predicate<int> newOne = new Predicate<int>(PairNumbers);
            
            // WE START A NEW LIST POINTING TO THE NEWONE PREDICATE
            List<int> PairNumber = numbers.FindAll(newOne);

            // WE GO THROUGHT THE PAIR NUMBERS USING THIS FOREACH
            foreach(int parNumber in PairNumber){

                System.Console.WriteLine(parNumber);

            }

            
            // NEXT EXAMPLE WITH PRIME NUMBERS

            //      PRIME NUMBERS
            static bool PrimeNumbers(int num){

                if(num == 2) return true;
                if(num < 2 || num % 2 == 0) return false;
                else return true;

            }

            System.Console.WriteLine("PRIME NUMBERS");
            List<int> numbs = new List<int>();
            numbs.AddRange(new int[]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20});

            Predicate<int> test2 = new Predicate<int>(PrimeNumbers);

            List<int> searchingPrimeNumbs = numbs.FindAll(test2);

            foreach(int primeNumber in searchingPrimeNumbs){

                System.Console.WriteLine(primeNumber);

            }


            
        }

        delegate void DelegatedObject();

    }

}