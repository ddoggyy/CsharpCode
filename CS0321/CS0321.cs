using System.Runtime.CompilerServices;

namespace CS0321
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("시험 점수를 입력하세요: ");
            int score = int.Parse(Console.ReadLine());
            if (score <= 100 && score >= 0)
            {
                if (90 <= score)
                {
                    Console.WriteLine("학점: A");
                    if (95 <= score) Console.WriteLine("우수 학생입니다!");
                }
                else if (score < 90 && score >= 80) Console.WriteLine("학점: B");
                else if (score < 80 && score >= 70) Console.WriteLine("학점: C");
                else if (score < 70 && score >= 60) Console.WriteLine("학점: D");
                else Console.WriteLine("학점: F");

                Console.WriteLine(score >= 60 ? "합격입니다!" : "불합격입니다.");
            }
            else Console.WriteLine("유효하지 않은 점수입니다.");

           /*========================================================================*/

            Console.WriteLine("\n\n\n계절 판별기 프로그램에 오신 것을 환영합니다!");
            Console.Write("1부터 12 사이의 숫자(월)를 입력해주세요: ");
            int month = int.Parse(Console.ReadLine());
            int isSeasonHard = 0; // 극단적인 계절 판별하기 위한 변수 추가
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("입력하신 " + month + "월은 겨울입니다.");
                    isSeasonHard++;
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("입력하신 " + month + "월은 봄입니다."); 
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("입력하신 " + month + "월은 여름입니다.");
                    isSeasonHard++;
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("입력하신 " + month + "월은 가을입니다.");
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다."); break;
            }
            Console.WriteLine(isSeasonHard == 1 ? "극단적인 계절입니다" : "온화한 계절입니다");
            Console.WriteLine(DateTime.Now.Hour < 12 ? "좋은 아침입니다." : "좋은하루 되세요.");

        }

    }
}
