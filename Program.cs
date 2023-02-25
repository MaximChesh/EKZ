using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekzKD
{
    /// <summary>
    /// Главная программа для расчета стоимости груза
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Ввод данных о грузе, расчет стоимости груза и запись в файл
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //фиксированные данные грузовика
            double grA = 1500; //грузоподъемность грузовика
            double VA = 12; //объем грузовика
            double lengthA = 3.5; //длина грузовика
            double widthA = 1.8; //ширина грузовика

            double cost = 35; //стоимость руб за км
            double Summa = 0; //итоговоая стоимость

            try
            {
                //данные груза
                double length = 0; //длина груза
                double width = 0; //ширина груза
                double height = 0; //высота груза
                double density = 0; //средняя плотность материала груза
                double distance = 0; //расстояние поездки

                //Ввод данных о грузе
                length = print.printLength(length, lengthA); 
                width = print.printWidth(width, widthA);
                height = print.printHeight(height);
                density = print.printDensity(density);
                distance = print.printDistance(distance);

                //Расчет стоимости поездки
                Summa = stoimost.SUM(VA,grA,Summa, width, height, length, density, distance, cost);

                string result = Convert.ToString(Summa);

                //Запись итоговой стоимости в файл
                try
                {
                    Console.WriteLine("Введите путь файла для сохранения данных: \n");
                    string fileNamewrite = Console.ReadLine();

                    //запись результатов расчета в txt файл
                    writefile.writetxt(@fileNamewrite, result);
                }
                catch (Exception) { Console.WriteLine("Ошибка введенном пути файла"); }

                Console.ReadKey();
            }
            catch (Exception) { Console.WriteLine("Ошибка ввода данных");}
        }
        
    }
}
