using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChirchenkoME.Sprint6.Task2.V23.Lib
{
    public class DataService : ISprint6Task2V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Написать программу, которая выводит таблицу значений функции: F(x) = 4 - 2x + (2 + cos(x))/(2x - 2) (произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести проверку деления на ноль. При делении на ноль вернуть значение 0. Значения занести в DataGridView Значения округлить до двух знаков после запятой. Графический интерфейс оформить по шаблону из лекции.
            int size = (stopValue - startValue) + 1;
            double[] results = new double[size];
            double sum = 0;
            for (int i = 0; i < size; i++)
            {
                int x = startValue + i;
                double result;
                if (2 * x - 2 == 0)
                {
                    result = 0;
                }
                else
                {
                    result = 4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2);
                }
                results[i] = Math.Round(result, 2);
                sum += results[i];
            }
            return results;
        }
    }
}
