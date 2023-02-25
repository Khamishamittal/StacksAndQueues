namespace StacksAndQueues
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queue Program");

            Console.WriteLine("Creating Stack using Linked List");

            CreateStack stack = new CreateStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();


        }

    }
}
    

