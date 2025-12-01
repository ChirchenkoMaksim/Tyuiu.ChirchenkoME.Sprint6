using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChirchenkoME.Sprint6.Task0.V21.Lib
{
    public class DataService : ISprint6Task0V21
    {
        public double Calculate(int x)
        {
            // Дано выражение F(x) = 2x³ + (1/2)x² - 3.5x + 2, вычислить его значение при x = 2, результат вывести в TextBox. Округлить до трёх знаков после запятой. Графический интерфейс оформить по шаблону из лекции.
            double result = 2 * Math.Pow(x, 3) + (0.5 * Math.Pow(x, 2)) - (3.5 * x) + 2;
            return Math.Round(result, 3);



        }
    }
}
