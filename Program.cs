namespace StacksAndQueues
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queue Program");
            Console.WriteLine("Creating Stack using Linked List");

            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();

            Console.WriteLine("\n-----------------\n");

            stack.Peek();
            stack.Pop();
            stack.IsEmpty();
            stack.Display();
        }
    }



}
    




    

   

