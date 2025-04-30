namespace CS0418_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
        }

        // 시간을 저장할 변수들
        private int hours = 0;
        private int minutes = 0;
        private int seconds = 0;

        // 타이머 상태 변수
        private bool isRunning = false;


        private void button1_Click(object sender, EventArgs e)
        {
            if (isRunning == false)
            {
                timer1.Start();
                isRunning = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isRunning == true)
            {
                timer1.Stop();
                isRunning = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isRunning == true)
            {
                timer1.Stop();
                hours = 0;
                minutes = 0;
                seconds = 0;
                UpdateTimeLabel();
                isRunning = false;
            }
        }


        private void UpdateTimeLabel()
        {
            // 00:00:00 형식으로 시간 표시
            textBox1.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isRunning == true)
            {
                seconds++;
            }
            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes == 60)
            {
                hours++;
                minutes = 0;
            }
            UpdateTimeLabel();
        }
    }
}
