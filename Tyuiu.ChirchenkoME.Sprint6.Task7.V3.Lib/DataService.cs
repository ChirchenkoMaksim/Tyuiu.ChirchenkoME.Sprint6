using System;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChirchenkoME.Sprint6.Task7.V3.Lib
{
    public class DataService : ISprint6Task7V3
    {
        public int[,] GetMatrix(string path)
        {
            //Дан файл InPutFileTask7V3.csv в котором хранится матрица целочисленных значений. Загрузить файл через openFileDialog в объект dataGridViewIn. Изменить в первом столбце четные значения на -1 . Результат вывести в объект dataGridViewOut. Сохранить результат в файл OutPutFileTask7.csv через saveFileDialog. Графический интерфейс пользователя оформить по образцу как в лекции
            string[] lines = System.IO.File.ReadAllLines(path);
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
            for (int i = 0; i < rowCount; i++)
            {
                if (matrix[i, 0] % 2 == 0)
                {
                    matrix[i, 0] = -1;
                }
            }
            return matrix;
        }
    }
}