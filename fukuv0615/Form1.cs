namespace fukuv0615
{
    public partial class Form1 : Form
    {
        int ans = rand.Next(0, 100);
        int count = rand.Next(0);
        int guess = 0;
        static Random rand = new Random();
        public Form1()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            MessageBox.Show($"{count}");
            if ((guess == count) && (count == ans)) 
            {
                MessageBox.Show("bingo");
            }
        }
    }
}