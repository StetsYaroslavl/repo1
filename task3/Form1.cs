namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int a = r.Next(1, 10);
            string[] l = new string[10];
            l.Append<string>("Ти зможеш!");
            l.Append<string>("В тебе все вийде!");
            l.Append<string>("Не падай духом!");
            l.Append<string>("Не здавайся!");
            l.Append<string>("Я вірю в тебе!");
            l.Append<string>("Ще трохи!");
            l.Append<string>("Ти неймовірний/а!");
            l.Append<string>("Не засмучуйся!");
            l.Append<string>("Ми непереможні!");
            l.Append<string>("Вір в себе!");
            label1.Text = l[a-1];
        }
    }
}
