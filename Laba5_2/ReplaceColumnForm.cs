using System;
using System.Windows.Forms;
using Laba5;

namespace Laba5_2
{
    public partial class ReplaceColumnForm : Form
    {

        public ReplaceColumnForm()
        {
            InitializeComponent();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            ReplaceMatrixColumn replace = new ReplaceMatrixColumn();        
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Я в замешательстве! Введите значение столбца");
                return;
            }

            var col1 = int.Parse(textBox1.Text);
            var col2 = int.Parse(textBox2.Text);

            int rowCount = dgMatrix1.RowCount;
            int columnCount = dgMatrix1.ColumnCount;
            replace.Matrix1 = new Matrix(rowCount, columnCount);
            replace.Matrix2 = new Matrix(rowCount, columnCount);
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    var strCell1 = dgMatrix1.Rows[i].Cells[j].Value.ToString();
                    replace.Matrix1.Values[i, j] = Convert.ToInt32(strCell1);
                    
                    var strCell2 = dgMatrix2.Rows[i].Cells[j].Value.ToString();
                    replace.Matrix2.Values[i, j] = Convert.ToInt32(strCell2);
                }
            }
            
            replace.Replace(col1, col2);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    dgMatrix1.Rows[i].Cells[j].Value = replace.Matrix1.Values[i, j];
                    dgMatrix2.Rows[i].Cells[j].Value = replace.Matrix2.Values[i, j];
                }
            }
        }

        private void dgMatrix1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void ReplaceColumnForm_Load(object sender, EventArgs e)
        {
            dgMatrix1.RowCount = 4;
            dgMatrix1.ColumnCount = 4;
            
            dgMatrix2.RowCount = 4;
            dgMatrix2.ColumnCount = 4;

            for (int i = 0; i < dgMatrix1.RowCount; i++)
            {
                for (int j = 0; j < dgMatrix1.ColumnCount; j++)
                {
                    dgMatrix1.Rows[i].Cells[j].Value = "0";
                    dgMatrix2.Rows[i].Cells[j].Value = "0";
                }
            }
        }
    }
    
}