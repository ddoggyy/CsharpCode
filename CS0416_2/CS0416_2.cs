namespace CS0416_2
{
    internal class CS0416_2
    {
        class Box
        {
            private int width;
            public int Width // 변수는 private, 속성은 public
            {
                get { return width; }
                set
                {
                    if (value > 0) { width = value; }
                    else { Console.WriteLine("너비는 자연수를 입력해주세요."); }
                }
            }

            private int height;
            public int Height
            {
                get { return height; }
                set
                {
                    if (value > 0) { height = value; }
                    else { Console.WriteLine("높이는 자연수를 입력해주세요."); }
                }
            }

            public Box(int width, int height)
            {
                Width = width;
                Height = height;
            }
            
            public int Area()
            {
                return this.width * this.height;
            }
        }


        static void Main(string[] args)
        {
            Box box = new Box(10, 10);
            Console.WriteLine(box.Area());
            box.Height = 15;
            box.Width = 15;
            Console.WriteLine(box.Area());
        }
    }
}


