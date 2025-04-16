namespace CS0319
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력: ");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("짝수입니다!");
            }
            else
            {
                Console.WriteLine("홀수입니다!");
            }

            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }
            else
            {
                Console.WriteLine("오후입니다.");
            }

            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }
            else
            {
                if (DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심 먹을 시간입니다.");
                }
                else
                {
                    Console.WriteLine("저녁 먹을 시간입니다.");
                }
            }

            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }
            else if (DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심 먹을 시간입니다.");
            }
            else
            {
                Console.WriteLine("저녁 먹을 시간입니다.");
            }

            double score1 = 100;
            if (score1 >= 4.5) Console.WriteLine("신");
            else if (4.2 <= score1) Console.WriteLine("교수님의 사랑");
            else if (3.5 <= score1) Console.WriteLine("현 체제의 수호자");
            else if (2.8 <= score1) Console.WriteLine("일반인");
            else if (2.3 <= score1) Console.WriteLine("일탈을 꿈꾸는 소시민");
            else if (1.75 <= score1) Console.WriteLine("오락문화의 선구자");
            else if (1.0 <= score1) Console.WriteLine("불가촉천민");
            else if (0.5 <= score1) Console.WriteLine("자벌레");
            else if (0 <= score1) Console.WriteLine("플랑크톤");
            else Console.WriteLine("시대를 앞서가는 혁명의 씨앗");


            switch (input % 2)
            {
                case 0:
                    Console.WriteLine("짝수입니다."); break;
                case 1:
                    Console.WriteLine("홀수입니다."); break;
            }


            Console.Write("이번 달은 몇 월인가요: ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다."); break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다."); break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다."); break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다."); break;
                default:
                    Console.WriteLine("대체 어떤 행성에 살고 계신가요?"); break;
            }
           
            Console.WriteLine(input > 0 ? "자연수입니다" : "자연수가 아닙니다");


            String line = Console.ReadLine();

            if (line.Contains("안녕")){
                Console.WriteLine("안녕하세요...!");
            }
            else
            {
                Console.WriteLine("^^");
            }
        }
    }
}
