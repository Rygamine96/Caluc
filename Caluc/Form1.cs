using System.Data;
using System.Reflection;

namespace Caluc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClick(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            textBox1.Text += currentButton.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                var d = new DataTable();
                textBox1.Text = d.Compute(textBox1.Text, "").ToString();
            }
            catch (Exception )
            {
                textBox1.Text = "�� �����";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" ;
        }


    }
}
