/*
namespace CS0326_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] intArray = { 52, 273, 32, 65, 103 };

            while (i < intArray.Length)
            {
                Console.WriteLine(i + "번째 출력: " + intArray[i]);
                i++;
            }

             ======================================

            string input;
            do
            {
                Console.WriteLine("입력(exit을 입력하면 종료): ");
                input = Console.ReadLine();
            } while (input != "exit");

             ======================================

            int output = 0;
            for (i = 0; i <= 100; i++)
            {
                output += i;
            }

            Console.WriteLine(output);

             ======================================

            for (i = '가'; i <= '힣'; i++)
            {
                Console.Write((char)i);
            }

             ======================================

            int[] intArray = { 1, 2, 3, 4, 5, 6 }
            ;
            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }

            ======================================

            string[] array = { "사과", "배", "포도", "딸기", "바나나" }
            ;

            foreach (string item in array)
            {
                Console.WriteLine(item);
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            ======================================

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            ====================================== 

            while (true)
            {
                Console.WriteLine("숫자를 입력해주세요(짝수를 입력하면 종료): ");
                int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0) break;
            }

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) continue;
                Console.WriteLine(i);
            }

            ====================================== 
        }
    }
}
*/
