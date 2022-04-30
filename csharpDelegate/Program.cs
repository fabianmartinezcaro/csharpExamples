namespace csharpDelegate{

    class Program{

        public static void Main(string[] args){

            // Creating new delegate instance pointing to WelcomeMessage
            DelegatedObject test = new DelegatedObject(WelcomeMessage.Greeting);

            // Using delegate calling the WelcomeMessage method
            test();

            // Changing the pointer to GoodbyeMessage
            test=new DelegatedObject(Goodbye.GoodbyeMessage);
            
            // Testing the new pointer
            test();
            
        }

        delegate void DelegatedObject();

    }

}