using System;

namespace ESI_DEV
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> test = new List<int> { 1, 10, 20, 25, 32 };

            List<string> test2 = new List<string> { "A", "B", "C", "D", "E" };

            Console.WriteLine(GetRandomInList(test2));

            Queue<int> testQueue = new Queue<int>();

            testQueue.Add(1);
            testQueue.Add(2);
            testQueue.Add(3);
            testQueue.Add(4);

            Console.WriteLine(testQueue.GetAndRemove());
            Console.WriteLine(testQueue.GetAndRemove());
            Console.WriteLine(testQueue.GetAndRemove());

            Stack<int> testStack = new Stack<int>();

            testStack.Add(1);
            testStack.Add(2);
            testStack.Add(3);
            testStack.Add(4);

            Console.WriteLine(testStack.GetAndRemove());
            Console.WriteLine(testStack.GetAndRemove());
            Console.WriteLine(testStack.GetAndRemove());
        }

        public static T GetRandomInList<T>(List<T> list)
        {
            T toReturn;

            Random random = new Random();
            int randomIndex = random.Next(list.Count);

            toReturn = list[randomIndex];

            return toReturn;
        }
    }
}