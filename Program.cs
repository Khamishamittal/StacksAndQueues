namespace StacksAndQueues
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queue Program");

            Console.WriteLine("Creating Queue using Linked List");

            CreateQueue queue = new CreateQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();

        }
    }

}
    

