namespace Guess_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1,num2,count;
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            num2 = Convert.ToInt32(textBox1.Text);
            label2.Text = num2.ToString();
            if (num1 > num2)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else if (num2 > num1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (num1 == num2)
            {
                MessageBox.Show("You are correct","Congrulations",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                MessageBox.Show("Trying = "+ count);
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            num1 = rnd.Next(1, 100);
            label1.Text =num1.ToString();
            
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}