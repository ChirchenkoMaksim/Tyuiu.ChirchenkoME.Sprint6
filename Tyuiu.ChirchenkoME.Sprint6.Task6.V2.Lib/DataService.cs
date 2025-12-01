using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChirchenkoME.Sprint6.Task6.V2.Lib
{
    public class DataService : ISprint6Task6V2
    {
        public string CollectTextFromFile(string path)
        {
            // Дан файл InPutFileTask6V2.txt который может находится в любом месте на диске. Загрузить файл в textBoxIn через openFileDialog. Вывести второе слово каждой строки в результирующею строку и вывести ее в textBoxOut. Графический интерфейс пользователя оформить по образцу как в лекции
            string[] lines = System.IO.File.ReadAllLines(path);
            var resultWords = new List<string>();
            foreach (var line in lines)
            {
                var words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (words.Length >= 2)
                {
                    resultWords.Add(words[1]);
                }
            }
            return string.Join(" ", resultWords);


        }
    }
}
