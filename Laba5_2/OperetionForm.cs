using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Laba5_2
{
    public partial class OperetionForm : Form
    {
        private string operation { get; }

        private static Matrix _matrix1 = null;
        private static Matrix _matrix2 = null;
        private static Matrix _matrix3 = null;

        private static OutMatrixForm _matrixForm = null;

        private static bool _f1 = false;
        private static bool _f2 = false;

        public OperetionForm()
        {
            InitializeComponent();
        }

        public OperetionForm(string o)
        {
            operation = o;
            InitializeComponent();
        }

        public OperetionForm(string o, int width, int height)
        {
            operation = o;
            Width = width;
            Height = height;
            InitializeComponent();
        }

        private void OperetionForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            SetTitleForm();
        }

        private void SetTitleForm()
        {
            switch (operation)
            {
                case "+":
                    Text = @"Сложение матриц";
                    break;
                case "-":
                    Text = @"Вычисление матриц";
                    break;
                case "*":
                    Text = @"Умножение матриц";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;

            var n = int.Parse(textBox1.Text);
            _matrix1 = new Matrix(n);

            _matrixForm = new OutMatrixForm(_matrix1);

            if (_matrixForm.ShowDialog() == DialogResult.OK)
            {
                var matrix = _matrixForm.Matrix;
                for (int i = 0; i < matrix.Rows; i++)
                for (int j = 0; j < matrix.Columns; j++)
                    _matrix1.Values[i, j] = matrix.Values[i, j];
                _f1 = true;
                label2.Text = _f1.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!_f1)
            {
                MessageBox.Show(@"Сперва заполните матрицу 1");
                return;
            }

            if (textBox1.Text == "") return;

            var n = int.Parse(textBox1.Text);
            _matrix2 = new Matrix(n);

            _matrixForm = new OutMatrixForm(_matrix2);

            if (_matrixForm.ShowDialog() == DialogResult.OK)
            {
                var matrix = _matrixForm.Matrix;
                for (int i = 0; i < matrix.Rows; i++)
                for (int j = 0; j < matrix.Columns; j++)
                    _matrix2.Values[i, j] = matrix.Values[i, j];
                _f2 = true;
                label3.Text = _f2.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!_f1 || !_f2) return;

            switch (operation)
            {
                case "+":
                    _matrix3 = _matrix1.Plus(_matrix2);
                    break;
                case "-":
                    _matrix3 = _matrix1.Minus(_matrix2);
                    break;
                case "*":
                    _matrix3 = _matrix1.Ymnogitb(_matrix2);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            new OutMatrixForm(_matrix3).Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}