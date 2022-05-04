namespace csharpLambdaExpressions{

    class Program{

        public static void Main(string[] args){

            Person userJose = new Person("Jose", 36);
            Person userFrancis = new Person("Francis", 25);
            Person userSarah = new Person("Sarah", 23);

            // COMPARING AGE BETWEEN TWO INSTANCES (PERSON)
            CompareAge firstComparison = (person1, person2) => person1 == person2;
            System.Console.WriteLine(firstComparison(userJose.Age, userFrancis.Age));

            // LAMBDA EXPRESSION WITH ONLY ONE PARAMETER
            MathOne firstOperation = new MathOne(num => num * num);
            System.Console.WriteLine(firstOperation(3));

            // LAMBDA EXPRESSION WITH MORE PARAMETERS
            MathMoreParam secondOperation = new MathMoreParam((number1, number2) => number1 + number2);
            System.Console.WriteLine(secondOperation(35,150));


            // LIST
            List<int> numbers = new List<int>{1,2,3,4,5,6,7,8,9};

            // FILTERING LIST
            List<int> pairNumbers = numbers.FindAll(i => i % 2 == 0);
            
            // PRINTING THE NEW LIST
            pairNumbers.ForEach(number => {
                
                System.Console.WriteLine("Pair numbers: ");
                System.Console.WriteLine(number);

                });

        }

        // DELEGATE

        // DELEGATE WITH ONE PARAMETER
        public delegate int MathOne(int number);

        // DELEGATE WITH MORE PARAMETERS
        public delegate int MathMoreParam(int num1, int num2);

        // DELEGATE TO COMPARE TWO PERSON'S AGE
        public delegate bool CompareAge(int firstAge, int secondAge);
    

    }

}