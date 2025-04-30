namespace CS0430_Inheritance
{
    internal class CS0430_Inheritance
    {
        class Animal
        {
            public int Age { get; set; }

            public Animal() { this.Age = 0; }

            public void TestPublic() { }
            protected void TestProtected() { }
            private void TestPrivate() { }

            public void TestA()
            {
                TestPublic(); // 모두 접근 가능
                TestProtected(); // 상속 받은 클래스까지 접근 가능 
                TestPrivate(); // 자신 클래스 안에서만 접근 가능
            }


            public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
            public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
        }
        
        class Dog : Animal
        {
            public string Color { get; set; }
            public void Bark() { Console.WriteLine("왈왈 짖습니다."); }
           
            public void TestB()
            {
                base.TestPublic();
                this.Bark();

                TestPublic();
                TestProtected();
                //TestPrivate();
            }
        }

        class Cat : Animal
        {
            public void Meow() { Console.WriteLine("냥냥 웁니다."); }
        }

        static void Main(string[] args)
        {
            /* 
            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            foreach(var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }

            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }
            */ 

            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();

                // ((Dog)item).Bark();
                // ((Cat)item).Meow(); Dog도 Cat.Meow()를 불러오게 되는 오류 발생

                if (item is Dog) { ((Dog)item).Bark(); }
                if (item is Cat) { ((Cat)item).Meow(); } // is 사용하여 구분 가능
            }
        }
    }
}
