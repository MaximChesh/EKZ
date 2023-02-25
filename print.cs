using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekzKD
{
    /// <summary>
    /// Программа для ввода данных
    /// </summary>
    public class print
    {
        /// <summary>
        /// Ввод данных длины груза
        /// </summary>
        /// <param name="length"></param>
        /// <param name="lengthA"></param>
        /// <returns></returns>
        public static double printLength(double length, double lengthA)
        {
            do
            {
                try
                {
                    Console.WriteLine("Введите данные длины паллеты в метрах: ");
                    length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(lengthA);
                    
                }
                catch (Exception) { Console.WriteLine("Ошибка введенных данных"); }
                if (length > lengthA)
                {
                    Console.WriteLine("Длина паллеты больше длины грузовика");
                }
            } while(length > lengthA);
            
            return length;
        }

        /// <summary>
        /// Ввод данных ширины груза
        /// </summary>
        /// <param name="width"></param>
        /// <param name="widthA"></param>
        /// <returns></returns>
        public static double printWidth(double width, double widthA)
        {
            do
            {
                try
                {
                    Console.WriteLine("Введите данные ширины паллеты в метрах: ");
                    width = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception) { Console.WriteLine("Ошибка введенных данных"); }
                if (width > widthA)
                {
                    Console.WriteLine("Ширина паллеты больше ширины грузовика");
                }
            } while (width > widthA);

            return width;
        }

        /// <summary>
        /// Ввод данных высоты груза
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double printHeight(double height)
        {
            try
            {
                Console.WriteLine("Введите данные высоты паллеты в метрах: ");
                height = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine("Ошибка введенных данных"); }
            
            return height;
        }

        /// <summary>
        /// Ввод данных средней плотности материала груза
        /// </summary>
        /// <param name="density"></param>
        /// <returns></returns>
        public static double printDensity(double density)
        {
            try
            {
                Console.WriteLine("Введите данные средней плотности материалов паллеты в кг/м^3: ");
                density = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine("Ошибка введенных данных"); }
            
            return density;
        }

        /// <summary>
        /// Ввод данных расстояния провоза
        /// </summary>
        /// <param name="distance"></param>
        /// <returns></returns>
        public static double printDistance(double distance)
        {
            try
            {
                Console.WriteLine("Введите данные о расстоянии доставки паллеты в км: ");
                distance = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception) { Console.WriteLine("Ошибка введенных данных"); }
            
            return distance;
        }
    }
}
