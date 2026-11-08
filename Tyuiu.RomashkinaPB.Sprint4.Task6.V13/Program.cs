using Tyuiu.RomashkinaPB.Sprint4.Task6.V13.Lib;

namespace Tyuiu.RomashkinaPB.Sprint4.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Ромашкина П. Б. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт # 4                                                              *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Ромашкина Полина Борисовна | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Ford, Toyota, Honda, Chevrolet,            *");
            Console.WriteLine("* Mercedes, BMW, Audi] используя класс Array подсчитайте количество       *");
            Console.WriteLine("* элементов, длина которых больше 4.                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var car = new string[] { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi"};
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= car.Length - 1; i++)
            {
                Console.WriteLine(car[i]);
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов длина которых больше 4: ");

            int nums = ds.Calculate(car);

            Console.WriteLine(nums);
            Console.ReadKey();


        }
    }
}
