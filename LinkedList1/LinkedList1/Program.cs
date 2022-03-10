using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{



    class Program
    {

        static LinkedList<int> ll = new LinkedList<int>();
        static Queue<int> queue = new Queue<int>();
        static List<int[]> l = new List<int[]>()
        {
            new int[]{1,2,3}
        };


        static void Main(string[] args)
        {
            foreach (var li in l)
            {
                foreach (var item in li)
                    Console.WriteLine(item);
            }
            ArrayList ar = new ArrayList();
            Stack stack = new Stack();
            stack.Push(10);
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);
            queue.Enqueue(400);
            queue.Enqueue(500);
            foreach (var item in queue)
            {
                Console.Write(" <= " + item);
            }



            ll.AddLast(10);
            ll.AddLast(20);
            ll.AddLast(30);
            ll.AddLast(40);
            ll.AddLast(50);

            if (ll.Last.Next == null)
                Console.WriteLine("Ending");
            Console.Write("Start --> ");
            LinkedListNode<int> curr = ll.First;
            int pos = 2;
            for (int i = 0; i < ll.Count; i++)
            {
                if (i < pos)
                    curr = curr.Next;
            }
            var res = curr.Value;
            ll.Remove(curr);
            Console.WriteLine("Removed Item:" + res);
            foreach (var item in ll)
            {
                Console.Write(item + " --> ");
            }
            Console.Write(" End\n");
            for (int i = 0; i < 5; i++)
            {
                Fun(i);
            }


        }
        static void Rem()
        {
            LinkedListNode<int> curr = ll.First;
            LinkedListNode<int> previous = null;
            for (int i = 0; i < 5; i++)
            {
                if(curr!=null && i==2)
                {
                    
                }
            }
        }
        static void Fun(int find)
        {
            LinkedListNode<int> curr = ll.First;
            LinkedListNode<int> previous = null;
            for (int i = 0; i < find; i++)
            {
                if (i == 1)
                    curr.
                if (i >= ll.Count)
                    return;
                curr = curr.Next;
            }
            Console.WriteLine("Fun(i)==" + curr.Value);
        }
    }
}
