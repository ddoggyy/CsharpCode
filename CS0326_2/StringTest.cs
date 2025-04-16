namespace CS0326_2
{
    internal class StringTest
    {
        static void Main(string[] args)
        {
            string input1 = "Potato Tomato";

            Console.WriteLine(input1.ToUpper());
            Console.WriteLine(input1.ToLower());

            string input2 = "감자 고구마 토마토";
            string[] inputs = input2.Split(new char[]{ ' ' });

            // 문자열 자르기
            foreach (var item in inputs)
            {
                Console.WriteLine(item);
            }

            // 공백 제거
            string input3 = " test       \n";
            Console.WriteLine("::" + input3.Trim() + "::");

            // 배열 -> 문자열로 변환
            string[] array = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(",", array));
        }
    }
}