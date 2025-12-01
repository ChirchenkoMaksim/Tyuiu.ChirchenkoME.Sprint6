using System.Collections.Generic;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChirchenkoME.Sprint6.Task5.V24.Lib
{
    public class DataService : ISprint6Task5V24
    {
        public double[] LoadFromDataFile(string path)
        {
            //Прочитать данные из файла InPutFileTask5V24.txt. Вывести в dataGridView.Дан список из чисел. Вывести все элементы, равные 0. Построить диаграмму по этим значениям. Графический интерфейс пользователя оформить по примеру из лекции. У вещественных значений округлить до трёх знаков после запятой.
            string[] lines = System.IO.File.ReadAllLines(path);

            var zeros = new List<double>();
            foreach (var line in lines)
            {
                if (double.TryParse(line, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out double value))
                {
                    double rounded = System.Math.Round(value, 3);
                    if (rounded == 0.0)
                    {
                        zeros.Add(rounded);
                    }
                }
                // skip non-numeric lines (do not treat them as 0)
            }
            return zeros.ToArray();
        }
    }
}