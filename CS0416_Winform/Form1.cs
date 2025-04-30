using System.Drawing.Text;

namespace CS0416_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException(); // 
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            label1.Text += "+";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int elapsedTime = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            textBox1.Text = $"{elapsedTime}초 경과";
            label1.Text = $"{elapsedTime}초 경과";
        }
    }
}
