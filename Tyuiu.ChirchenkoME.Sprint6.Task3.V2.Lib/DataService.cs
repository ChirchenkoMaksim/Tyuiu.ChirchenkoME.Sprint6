using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChirchenkoME.Sprint6.Task3.V2.Lib
{
    public class DataService : ISprint6Task3V2
    {
        public int[,] Calculate(int[,] matrix)
        {
            // Дан массив 5 на 5 элементов. Заменить четные значения в первой строке на 0. Результат вывести в DataGridView. Графический интерфейс оформить по шаблону из лекции. -12  -4 -20   5  -5  2  15   1 -20   7 15 -15   2  11   5 -19  -9  16   0   1 17  16   5  12  -8
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int j = 0; j < cols; j++)
            {
                if (matrix[0, j] % 2 == 0)
                {
                    matrix[0, j] = 0;
                }
            }
            return matrix;

        }
    }
}
