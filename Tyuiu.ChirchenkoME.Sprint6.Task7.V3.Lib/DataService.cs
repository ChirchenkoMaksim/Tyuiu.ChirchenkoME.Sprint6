using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChirchenkoME.Sprint6.Task7.V3.Lib
{
    public class DataService : ISprint6Task7V3
    {
        public int[,] GetMatrix(string path)
        {
            //Дан файл InPutFileTask7V3.csv в котором хранится матрица целочисленных значений. Загрузить файл через openFileDialog в объект dataGridViewIn. Изменить в первом столбце четные значения на -1 . Результат вывести в объект dataGridViewOut. Сохранить результат в файл OutPutFileTask7.csv через saveFileDialog. Графический интерфейс пользователя оформить по образцу как в лекции
            string[] lines = File.ReadAllLines(path);
            if (lines.Length == 0)
                return new int[0, 0];

            char[] separators = new[] { ',', ';' };
            // find first non-empty line to determine column count
            int colCount = 0;
            foreach (var l in lines)
            {
                var trimmed = l?.Trim();
                if (!string.IsNullOrEmpty(trimmed))
                {
                    colCount = trimmed.Split(separators, StringSplitOptions.RemoveEmptyEntries).Length;
                    break;
                }
            }
            if (colCount == 0)
                return new int[0, 0];

            int rowCount = lines.Length;
            int[,] matrix = new int[rowCount, colCount];
            for (int i = 0; i < rowCount; i++)
            {
                var values = lines[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < colCount; j++)
                {
                    if (j < values.Length && int.TryParse(values[j].Trim(), out int parsed))
                    {
                        matrix[i, j] = parsed;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            // Do not modify matrix here; processing is performed by ProcessMatrix
            return matrix;
        }

        public int[,] ProcessMatrix(int[,] input)
        {
            if (input == null)
                return new int[0, 0];

            int rows = input.GetLength(0);
            int cols = input.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = input[i, j];
                }
                // change even values in first column to -1
                if (cols > 0)
                {
                    int v = result[i, 0];
                    if (v % 2 == 0)
                        result[i, 0] = -1;
                }
            }
            return result;
        }

        public void SaveToFile(string path, int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            var sb = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                var parts = new string[cols];
                for (int j = 0; j < cols; j++)
                {
                    parts[j] = matrix[i, j].ToString();
                }
                sb.AppendLine(string.Join(";", parts));
            }
            File.WriteAllText(path, sb.ToString());
        }
    }
}