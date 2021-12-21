using System;
using System.Windows.Forms;

namespace Laba5_2
{
    public partial class OutMatrixForm : Form
    {
        public Matrix Matrix { get; set; }
        
        public OutMatrixForm()
        {
            InitializeComponent();
        }
        public OutMatrixForm(Matrix matrix)
        {
            InitializeComponent();
            this.Matrix = matrix;
            this.dataGridView1.RowCount = matrix.Rows;
            this.dataGridView1.ColumnCount = matrix.Columns;
        }
        

        private void OutMatrixForm_Load(object sender, EventArgs e)
        {
            var matrixValues = Matrix.Values;
            for (var i = 0; i < Matrix.Rows; i++)
            for (var j = 0; j < Matrix.Columns; j++)
                dataGridView1.Rows[i].Cells[j].Value = matrixValues[i, j].ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Matrix.Rows; i++)
            {
                for (int j = 0; j < Matrix.Columns; j++)
                {
                    var strCell = dataGridView1.Rows[i].Cells[j].Value.ToString();

                    if (strCell == "") strCell = @"0";
                    Matrix.Values[i, j] = int.Parse(strCell);
                }
            }
        }
        
    }
}