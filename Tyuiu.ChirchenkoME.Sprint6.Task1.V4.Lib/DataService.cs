using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChirchenkoME.Sprint6.Task1.V4.Lib
{
    public class DataService : ISprint6Task1V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Написать программу, которая выводит таблицу значений функции: F(x) = sin(x)/(x + 1.2) - sin(x) * 2 - 2x (произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести проверку деления на ноль. При делении на ноль вернуть значение 0. Результат вывести в Textbox Значения округлить до двух знаков после запятой. Графический интерфейс оформить по шаблону из лекции.
            int size = (stopValue - startValue) + 1;
            double[] results = new double[size];
            for (int i = 0; i < size; i++)
            {
                int x = startValue + i;
                double result;
                if (x + 1.2 == 0)
                {
                    result = 0;
                }
                else
                {
                    result = Math.Sin(x) / (x + 1.2) - Math.Sin(x) * 2 - 2 * x;
                }
                results[i] = Math.Round(result, 2);
            }
            return results;
        }
    }
}
