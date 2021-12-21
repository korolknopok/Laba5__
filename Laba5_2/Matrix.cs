using System.Windows.Forms;

namespace Laba5_2
{
    public class Matrix
    {
        /// <summary>
        /// Значение матрицы в ввиде целочисленного двумерного массива
        /// </summary>
        public int[,] Values { get; }

        public int Rows;
        public int Columns;

        public Matrix(int[,] values, int n)
        {
            this.Values = values;
            this.Rows = n;
            this.Columns = n;
        }
        /// <summary>
        /// Конструктор для создания матрицы
        /// </summary>
        /// <param name="rowCount"></param>
        /// <param name="columnCount"></param>
        public Matrix(int rowCount, int columnCount)
        {
            this.Values = new int[rowCount, columnCount];
            this.Rows = rowCount;
            this.Columns = columnCount;
        }
        
        /// <summary>
        /// Конструктор для создания квадратной матрицы
        /// </summary>
        /// <param name="n"></param>
        public Matrix(int n)
        {
            this.Rows = n;
            this.Columns = n;
            this.Values = new int[n, n];
        }
        /// <summary>
        /// метод для сложения одной матрецы на другую
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public Matrix Plus(Matrix matrix)
        {
            if (this.Rows != matrix.Rows) return null;

            var newMatrix = new Matrix(this.Rows);

            for (var i = 0; i < this.Rows; i++)
            for (var j = 0; j < this.Rows; j++)
                newMatrix.Values[i, j] = matrix.Values[i, j] + this.Values[i, j];

            return newMatrix;
        }
/// <summary>
/// метод для вычитания одной матрецы на другую
/// </summary>
/// <param name="matrix"></param>
/// <returns></returns>
        public Matrix Minus(Matrix matrix)
        {
            if (this.Rows != matrix.Rows) return null;

            var newMatrix = new Matrix(this.Rows);

            for (var i = 0; i < this.Rows; i++)
            for (var j = 0; j < this.Rows; j++)
                newMatrix.Values[i, j] = matrix.Values[i, j] - this.Values[i, j];

            return newMatrix;
        }
/// <summary>
/// метод для умножения одной матрецы на другую
/// </summary>
/// <param name="matrix"></param>
/// <returns></returns>
        public Matrix Ymnogitb(Matrix matrix)
        {
            if (this.Rows != matrix.Rows) return null;

            var newMatrix = new Matrix(this.Rows);

            for (var i = 0; i < this.Rows; i++)
            for (var j = 0; j < this.Rows; j++)
            {
                newMatrix.Values[i, j] = 0;
                for (int k = 0; k < this.Rows; k++)
                    newMatrix.Values[i, j] += this.Values[k, j] * matrix.Values[i, k];
            }

            return newMatrix;
        }
    }
}