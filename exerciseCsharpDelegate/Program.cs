namespace exerciseCsharpDelegate{

    class Program{

        delegate string NewMessage(string message);
        public static void Main(string[] args)
        {
            
            
            NewMessage content = new NewMessage(Message.SetMessage);
            content("Hello");


        }

    }   
    
}