using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChirchenkoME.Sprint6.Task5.V24.Lib
{
    public class DataService : ISprint6Task5V24
    {
        public double[] LoadFromDataFile(string path)
        {
            //Прочитать данные из файла InPutFileTask5V24.txt. Вывести в dataGridView.Дан список из чисел. Вывести все элементы, равные 0. Построить диаграмму по этим значениям. Графический интерфейс пользователя оформить по примеру из лекции. У вещественных значений округлить до трёх знаков после запятой.
            string[] lines = System.IO.File.ReadAllLines(path);

            double[] numbers = new double[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                if (double.TryParse(lines[i], out double value))
                {
                    numbers[i] = Math.Round(value, 3);
                }
                else
                {
                    numbers[i] = 0; // или обработать ошибку по-другому
                }
            }
            return numbers;
        }
    }
}
