namespace MyFirstWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }
    }
}
