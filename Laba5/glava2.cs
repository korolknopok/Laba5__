using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laba5
{
    public partial class glava2 : Form
    {
        public glava2()
        {
            InitializeComponent();
        }

        public glava2(Form1 f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            newForm1.Show();

            glava2 newGlava2 = new glava2();
            newGlava2.Show();
        }
    }
    
}