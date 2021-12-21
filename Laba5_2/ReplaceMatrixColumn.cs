namespace Laba5_2
{
    public class ReplaceMatrixColumn
    {
        public Matrix Matrix2 { set; get; }
        public Matrix Matrix1 { set; get; }

        public ReplaceMatrixColumn()
        {
        }
/// <summary>
/// Метод меняет значения столбцов в матрицах места
/// </summary>
/// <param name="col1">Номер стобца первой матрицы</param>
/// <param name="col2">Номер столбца 2 матрицы</param>
        public void Replace(int col1, int col2)
        {
            var columns = Matrix1.Columns;
            var array1 = new int[columns];
            var array2 = new int[columns];
            for (var i = 0; i < columns; i++)
            for (var j = 0; j < columns; j++)
            {
                if (j + 1 == col1)
                {
                    array1[i] = Matrix1.Values[i, j];
                }

                if (j + 1 == col2)
                {
                    array2[i] = this.Matrix2.Values[i, j];
                }
            }
            
            for (var i = 0; i < columns; i++)
            for (var j = 0; j < columns; j++)
            {
                if (j + 1 == col1)
                {
                    Matrix1.Values[i, j] = array2[i];
                }

                if (j + 1 == col2)
                {
                    this.Matrix2.Values[i, j] = array1[i];
                }
            }
        }
    }
}