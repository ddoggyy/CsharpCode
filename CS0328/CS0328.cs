namespace CS0328
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0) Console.WriteLine(" __@");
                else if (x % 3 == 1) Console.WriteLine("_^@");
                else Console.WriteLine("^_@");

                Thread.Sleep(300);
                x++;
            } 
            */

            bool state = true;
            while (state)
            {
                ConsoleKeyInfo info = Console.ReadKey();

                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위쪽으로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽으로 이동");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래쪽으로 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽으로 이동");
                        break;
                    case ConsoleKey.X:
                        state = false;
                        break;
                }
            }
        }
    }
}
