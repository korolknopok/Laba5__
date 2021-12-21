using System;
using System.Windows.Forms;

namespace Laba5_2
{
    public partial class FormMain : Form
    {
        private const int WIDTH = 700;
        private const int HEIGHT = 500;
        public FormMain()
        {
            Wight = WIDTH;
            Height = HEIGHT;
            InitializeComponent();
        }

        public int Wight { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            new OperetionForm("*",WIDTH,HEIGHT).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new OperetionForm("+",WIDTH,HEIGHT).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new OperetionForm("-",WIDTH,HEIGHT).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new ReplaceColumnForm().Show();
        }
    }
}