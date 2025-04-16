using System.Numerics;
using System.Runtime.CompilerServices;

namespace CS0314
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ProgramManager.GetInstance().Run();
        }
    }

    public class ProgramManager
    {
        private static ProgramManager m_instance;

        private Student student;

        private string name;
        private string id;
        private int math;
        private int eng;

        public static ProgramManager GetInstance()
        {
            if (m_instance == null)
            {
                m_instance = new ProgramManager();

                return m_instance;
            }

            return m_instance;
        }

        public void Run()
        {
            Input();

            student = new Student(name, id, new Scores(math, eng));

            student.ShowStudentInfo();
            student.ShowScoreInfo();
            student.ShowAvgInfo();
        }

        private void Input()
        {
            Console.Write("학생 이름을 입력하세요: ");
            this.name = Console.ReadLine();
            Console.Write("학번을 입력하세요: ");
            id = Console.ReadLine();
            Console.Write("수학 점수를 입력하세요: ");
            math = int.Parse(Console.ReadLine());
            Console.Write("영어 점수를 입력하세요: ");
            eng = int.Parse(Console.ReadLine());
            Console.Write("\n\n");
        }
    }

    public class Student
    {
        private string name;
        private string id;
        private Scores score;

        public Student(string name, string id, Scores score)
        {
            this.name = name;
            this.id = id;
            this.score = score;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine("=== 학생 정보 ===");
            Console.WriteLine($"이름: {this.name} (자료형: {this.name.GetType()})");
            Console.WriteLine($"학번: {this.id} (자료형: {this.name.GetType()})");
            Console.Write("\n\n");
        }

        public void ShowScoreInfo()
        {
            Console.WriteLine("=== 성적 정보 ===");
            Console.WriteLine($"수학: {this.score.GetMath()}점 (자료형: {this.score.GetMath().GetType()})");
            Console.WriteLine($"학번: {this.score.GetEng()}점 (자료형: {this.score.GetEng().GetType()})");
            Console.Write("\n\n");
        }

        public void ShowAvgInfo()
        {
            Console.WriteLine("=== 계산 정보 ===");
            Console.WriteLine($"총점: {this.score.GetTotal()}점 (자료형: {this.score.GetTotal().GetType()})");
            Console.WriteLine($"평균: {this.score.GetAvg()}점 (자료형: {this.score.GetAvg().GetType()})");
            Console.Write("\n\n");
        }
    }

    public class Scores
    {
        private int math;
        private int eng;
        private int total;
        private double avg;

        public Scores(int math, int eng)
        {
            this.math = math;
            this.eng = eng;
            this.total = math + eng;
            this.avg = ((double)math + eng) / 2;
        }

        public int GetMath()
        {
            return math;
        }

        public int GetEng()
        {
            return eng;
        }

        public int GetTotal()
        {
            return total;
        }

        public Double GetAvg()
        {
            return avg;
        }
    }
}
