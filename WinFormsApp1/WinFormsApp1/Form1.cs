namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.SelectionStart = 1;
            textBox2.SelectionLength = textBox2.Text.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(@"..\Test.txt").ToList();
            
            //textBox2.Text = lines[0];
        }
    }
}