using System;

namespace App1
{
    class Program
    {
        static void Main()
        {
            //я всё сделаю в одном проекте, чтобы было легче проверять 

            Console.WriteLine("Задание 1");

            Console.WriteLine("Введите первое значение температуры");

            int firstTemperature = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе значение температуры");

            int secondTemperature = Convert.ToInt32(Console.ReadLine());

            double averageTemperature = (((double)firstTemperature + secondTemperature) / 2);
            Console.WriteLine($"Среднее значение температуры за сутки = {averageTemperature}");

            Console.WriteLine();
            Console.WriteLine("Задание 2");

            Console.WriteLine("Введите номер месяца");

            int numberMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Название месяца - {NameMonth(numberMonth)}");

            Console.WriteLine();
            Console.WriteLine("Задание 3");

            Console.WriteLine("Введите ваше число");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Число является четным");
            }
            else
            {
                Console.WriteLine("Число является нечетным");
            }

            Console.WriteLine();
            Console.WriteLine("Задание 4");


        }

        private static string NameMonth(int numberMonth)
        {
            switch(numberMonth)
            {
                case 1:
                    return "January";

                case 2:
                    return "February";

                case 3:
                    return "March";

                case 4:
                    return "April";

                case 5:
                    return "May";

                case 6:
                    return "June";

                case 7:
                    return "July";

                case 8:
                    return "August";

                case 9:
                    return "September";

                case 10:
                    return "October";

                case 11:
                    return "November";

                case 12:
                    return "December";

                default:
                    return "Вы ввели неверное число месяца";
            }
        }
    }
}