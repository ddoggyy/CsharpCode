using System.Security.Cryptography;

namespace CS0328_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int answer, menuSelect, count, dan;
            bool isnotZero = true;
            bool isnotCorrect = true;
            Console.WriteLine("=== 숫자 게임 프로젝트 ===\n");

            while (isnotZero)
            {
                Console.WriteLine("===== 메뉴 =====");
                Console.WriteLine("1. 숫자 맞추기");
                Console.WriteLine("2. 구구단 연습");
                Console.WriteLine("0. 종료");
                Console.Write("메뉴를 선택하세요: ");
                menuSelect = int.Parse(Console.ReadLine());
                switch (menuSelect)
                {
                    case 1:
                        Console.WriteLine("\n=== 숫자 맞추기 게임 ===");
                        Console.WriteLine("1부터 50 사이의 숫자를 맞춰보세요!");
                        int CorrectAnswer = random.Next(1, 51);
                        count = 0;
                        do
                        {
                            isnotCorrect = true;
                            Console.Write("숫자를 입력하세요 (1-50, 0 입력시 포기): ");
                            answer = int.Parse(Console.ReadLine());
                            if ((answer <= 50 && answer >= 1) || answer == 0)  
                            {
                                if (answer == 0)
                                {
                                    Console.WriteLine("정답은 " + CorrectAnswer + "였습니다!\n");
                                    isnotCorrect = false;
                                }
                                else if (answer == CorrectAnswer)
                                {
                                    Console.WriteLine("정답입니다! " + count + "번 만에 맞추셨습니다.\n");
                                    isnotCorrect = false;
                                }
                                else if (CorrectAnswer > answer)
                                {
                                    Console.WriteLine("더 큰 숫자입니다!\n");
                                    count++;
                                }
                                else if (CorrectAnswer < answer)
                                {
                                    Console.WriteLine("더 작은 숫자입니다!\n");
                                    count++;
                                }
                            }
                            else Console.WriteLine("1부터 50 사이의 숫자를 입력하세요.\n");
                        } while (isnotCorrect);
                        break;

                    case 2:
                        Console.WriteLine("\n=== 구구단 연습 ===");
                        Console.Write("몇 단을 연습하시겠습니까? (1-9): ");
                        dan = int.Parse(Console.ReadLine());
                        if (dan >= 1 && dan <= 9)
                        {
                            Console.WriteLine("\n[" + dan + "단]");
                            for (int i = 1; i <= 9; i++)
                            {
                                Console.WriteLine(dan + " x " + i + " = " + dan * i);
                            }
                            Console.WriteLine("\n[역순 구구단]");
                            for (int i = 9; i >= 1; i--)
                            {
                                Console.WriteLine(dan + " x " + i + " = " + dan * i);
                            }
                            Console.WriteLine("\n");
                        }
                        else Console.WriteLine("1-9 사이의 숫자를 입력하세요.\n");
                        break;
                    case 0:
                        Console.WriteLine("프로그램을 종료합니다.");
                        isnotZero = false;
                        break;
                    default:
                        Console.WriteLine("0-2 사이의 메뉴를 선택하세요.\n");
                        break;
                }


            }


        }
    }
}