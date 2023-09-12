//Task: 16. Реалізувати функцію зведення у квадрат доутку двох дійсних чисел
namespace Lab1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            double number1 = r.NextDouble() * 21 - 10, number2 = r.NextDouble() * 21 - 10;

            Console.WriteLine("({0} * {1})^2 = {2}", number1, number2, Squaring(number1, number2));
        }

        /// <summary>
        /// Функція зведення у квадрат добутку двох дійсних чисел
        /// </summary>
        /// <param name="number1">множник1</param>
        /// <param name="number2">множник2</param>
        /// <returns>Квадрат добутку двох дійсних чисел</returns>
        static double Squaring(double number1, double number2)
        {
            return Math.Pow(number1 * number2, 2);
        }
    }
}