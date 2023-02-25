using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekzKD
{
    /// <summary>
    /// Программа для расчета
    /// </summary>
    public class stoimost
    {
        /// <summary>
        /// Расчет перевозки стоимости перевозки
        /// </summary>
        /// <param name="VA"></param>
        /// <param name="grA"></param>
        /// <param name="Summa"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="length"></param>
        /// <param name="density"></param>
        /// <param name="distance"></param>
        /// <param name="cost"></param>
        /// <returns></returns>
        public static double SUM(double VA, double grA, double Summa, double width, double height, double length, double density, double distance, double cost)
        {
            double VGr = width * height * length;

            //Проверка груза на вес
            if (VGr > VA)
            {
                Console.WriteLine("Слишком тяжелый груз, >1500кг");
            }
            else
            {
                Console.WriteLine("Объем груза прошел проверку");
            }

            //Проверка груза
            double mGr = (VGr / 1000) * density;
            if(mGr > grA)
            {
                Console.WriteLine("Слишком тяжелый груз, >1500кг");
            }
            else
            {
                Console.WriteLine("Вес груза прошел проверку");
            }
            Summa = distance * cost;

            double dopSum = 0; //допольнительная сумма за перегруз
            if (mGr >= 300)
            {
                do
                {
                    dopSum = dopSum + 1;
                    mGr = mGr - 300;
                } while (mGr > 0);
            }

            Summa = Summa + dopSum;
            Console.WriteLine("Стоимость поездки: " + Summa);

            return (Summa);
        }
    }
}
