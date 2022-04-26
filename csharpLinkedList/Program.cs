namespace csharpLinkedList{

    class Program{

        public static void Main(string[] args){
            
            //LINKEDLIST 
            
            LinkedList<int> numeros = new LinkedList<int>();

            System.Console.WriteLine("Creando una lista de numeros con LinkedList: ");

            foreach(int numero in new int[]{10,9,6,3,1}){
        
                numeros.AddLast(numero);

            }

            foreach(int numero in numeros){

                System.Console.WriteLine(numero);

            }

            System.Console.WriteLine("Mayor de la lista: ");
            System.Console.WriteLine(numeros.Max());

            System.Console.WriteLine("LinkedListNode: ");
            for(LinkedListNode<int> nodo = numeros.First ;nodo != null; nodo = nodo.Next){
                
                int numero = nodo.Value;
                System.Console.WriteLine(numero);

            }

        }  
            
     }

}

