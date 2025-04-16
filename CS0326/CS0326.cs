namespace CS0326
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 52, 273, 32, 65, 103 };
            intArray[0] = 0;
            int[] newintArray = new int[100];

            while (true)
            {
                Console.WriteLine(intArray[0]);
                Console.WriteLine(intArray[1]);
                Console.WriteLine(intArray[2]);
                Console.WriteLine(intArray[3]);
                Console.WriteLine(newintArray[0]);
            }

        }
    }
}