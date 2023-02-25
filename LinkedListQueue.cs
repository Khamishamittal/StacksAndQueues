using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StacksAndQueues
{
   public class LinkedListQueue
    {
        public node head = null;

        public void Enqueue(int data)
        {
            node node = new node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;


            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }

        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            node temp = this.head;
            this.head = this.head.next;
            Console.WriteLine("Item removed is {0}", temp.data);
        }

        public void Display()
        {
            node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}

