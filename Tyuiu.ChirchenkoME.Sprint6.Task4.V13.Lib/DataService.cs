using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChirchenkoME.Sprint6.Task4.V13.Lib
{
    public class DataService : ISprint6Task4V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Написать программу, которая выводит таблицу значений функции f(x) = 3x + 2 - (2x-x/ cos(x)+1) (произвести табулирование) f(x) на заданном диапазоне  [-5; 5] с шагом 1. Произвести проверку деления на ноль. При делении на ноль вернуть значение 0. Округлить до двух знаков после запятой. Результат вывести в textBox, построить график функции и сохранить в файл OutPutFileTask4V13.txt по нажатию кнопки. Графический интерфейс пользователя оформить по примеру из лекции.
            int size = (stopValue - startValue) + 1;
            double[] results = new double[size];
            for (int i = 0; i < size; i++)
            {
                int x = startValue + i;
                double result;
                if (Math.Cos(x) + 1 == 0)
                {
                    result = 0;
                }
                else
                {
                    result = 3 * x + 2 - (2 * x - x / (Math.Cos(x) + 1));
                }
                results[i] = Math.Round(result, 2);
            }
            return results;
        }
    }
}
