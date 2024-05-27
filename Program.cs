
using Lesson25._05;

namespace Lesson25;

public class Program
{
    public static void Main(string[] args)
    {
        MyLinkedListNode m = new MyLinkedListNode
        {
            Value = 1,
            Next = new MyLinkedListNode
            {
                Value = 2,
                Next = new MyLinkedListNode
                {
                    Value = 3,
                    Next = null
                }
            }
        };

        m.PrintAllLinckedNodes();
        m.AddNode(11);
        m.PrintAllLinckedNodes();
    }
}