namespace TypyDatovychStruktur
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //fixed size
            int[] array = new int[3];

            //constant time complexityt O(1)
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;

            // constant time complexity O(1)
            Console.WriteLine("array[1] O(1): " + array[1]);

            // linear time complexity O(n)
            Console.WriteLine("O(n) foreach i in array");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            // in C# beggining capacity is 4
            // after exceeding the capacity it is increased
            List<int> list = new List<int>();


            // constant time complexity O(1)
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);

            // list has to increase its capacity so the time complexity is O(n)
            list.Add(50);

            // linear time complexity O(n)
            // all elements have to shift forward
            list.Insert(0, 99);


            LinkedList<int> linkedList = new LinkedList<int>();

            // O(1) time complexity
            linkedList.AddLast(10);
            linkedList.AddLast(540);
            linkedList.AddFirst(50);
            linkedList.AddFirst(60);
            linkedList.AddFirst(70);
            linkedList.AddFirst(80);
            linkedList.AddFirst(90);


            Console.WriteLine();

            // O(n) time complexity
            Console.WriteLine("O(n) time complexity, get element at 4 index: " + linkedList.ElementAt(4));
            Console.WriteLine("Last item of linkedList O(1): " + linkedList.Last());
            Console.WriteLine("Last item of linkedList O(1): " + linkedList.First());

            // O(1) complexity
            linkedList.RemoveFirst();
            linkedList.RemoveLast();

            // O(n) time complexity
            linkedList.Remove(10);


            Queue<int> queue = new Queue<int>();

            // O(1) time complexity
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            // O(n) time complexity
            while (queue.Count > 0)
            {
                // O(1) time complexity
                int a = queue.Dequeue();
                Console.WriteLine("Dequeue: " + a);
            }

            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // O(n) time complexity
            while (stack.Count > 0)
            {
                // O(1) time complexity
                int a = stack.Pop();
                Console.WriteLine("Pop: " + a);
            }

            // pak jsou povidani o stromu a halde, staci vyuzit 3 minuty na kazdou strukturu
            // array, list, linked list(jejich druhy), strom, halda
            // obrazky a tomu podobne a mate vyhrano

        }
    }
}