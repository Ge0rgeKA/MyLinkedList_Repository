using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson25._05
{
    public class MyLinkedListNode
    {
        private MyLinkedListNode next;
        //private MyLinkedListNode previous;
        internal int count = 0; //Добавил счетчик, но не придумал как реализовать его
        public int Value { get; set; }

        public int Count
        {
            get { return count; }
        }
        public MyLinkedListNode Next
        {
            get { return next; }
            set
            {
                next = value;
                count++; //попытки реализовать счетчик
            }
        }

        public void PrintAllLinckedNodes()
        {
            Console.WriteLine(Value);
            MyLinkedListNode n = Next;
            while (n != null)
            {
                Console.WriteLine(n.Value);
                n = n.Next;
            }
        }

        public void AddNode(int V)
        {
            MyLinkedListNode n = this;
            
            do
            {
                n = n.Next;
            } while (n != null) ;

            n = new MyLinkedListNode 
            { 
                Value = V, 
                Next = null 
            };
        }
    }
}
