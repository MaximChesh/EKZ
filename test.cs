using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekzKD
{
    /// <summary>
    /// Программа для тестов
    /// </summary>
    public class test
    {
        /// <summary>
        /// Тестирование на расчет стоимости
        /// </summary>
        /// <param name="VA"></param>
        /// <param name="grA"></param>
        /// <param name="Summa"></param>
        /// <param name="sh"></param>
        /// <param name="h"></param>
        /// <param name="dl"></param>
        /// <param name="p"></param>
        /// <param name="P"></param>
        /// <param name="stoit"></param>
        /// <returns></returns>
        public double SUM(double VA, double grA, double Summa, double sh, double h, double dl, double p, double P, double stoit)
        {
            double VGr = sh * h * dl;

            if (VGr > VA)
            {
                Console.WriteLine("Слишком тяжелый груз, >1500кг");
            }
            else
            {
                Console.WriteLine("Вес груза прошел проверку");
            }

            double mGr = (VGr / 1000) * p;
            if (mGr > grA)
            {
                Console.WriteLine("Слишком тяжелый груз, >1500кг");
            }
            else
            {
                Console.WriteLine("Вес груза прошел проверку");
            }
            Summa = P * stoit;

            double dopSum = 0;
            if (mGr >= 300)
            {
                do
                {
                    dopSum = dopSum + 1;
                    mGr = mGr - 300;
                } while (mGr > 0);
            }

            Summa = Summa + dopSum;
            Console.WriteLine(Summa);
            return Summa;
        }
    }
}
