namespace CS0416_3
{
    internal class CS0416_3
    {
        class Test
        {
            public int value = 10; // value의 주소에 10을 할당
        }

        static void Change(Test input) 
        {
            input.value = 20; // 매개변수의 주소값을 20으로 변경
        }

        static void Main(string[] args)
        {
            Test test = new Test();
            test.value = 10; // test의 주소에 10을 할당
            Change(test); // test의 주소를 20으로 변경

            Console.WriteLine(test.value);

            Test testA = new Test();
            Test testB = testA; // 가리키는 주소 위치가 testA임
            testA.value = 10; // testA의 주소에 10을 할당
            testB.value = 20; // testB의 주소에 20을 할당, 그러나 testB의 주소는 testA이므로 testA의 주소에 20을 할당한 것과 같음
            Console.WriteLine(testA.value); 
        }
    }
}
