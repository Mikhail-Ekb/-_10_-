using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_10_Работа_над_ошибками
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Angle angle;
            do
            {
                    Console.Write("Введите градусы: ");
                    int gradus_ = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите минуты: ");
                    int min_ = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите секунды: ");
                    int sec_ = Convert.ToInt32(Console.ReadLine());

                    angle = new Angle(gradus_, min_, sec_);

                if (!angle.isCorrect)
                    Console.WriteLine("\nОшибка. Повторите ввод.");

            } while (angle.isCorrect == false);

            double radian = angle.ToRadians();
            Console.Write($"Радианы: {radian}");
            Console.ReadLine();
        }
    }
}
