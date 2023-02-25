# README

Программа для расчета стоимости перевозки груза по тарифу. Реализованный в Visual Studio технологией платформы .NET Framework.

## Начало работы

Для работы с проектом необходимо перейти по ссылке и скачать либо zip архив, либо клонировать репозиторий себе на компьютер. Если вы скачали zip архивом его необходимо распаковать в удобное для вас место и внутри папки проекта запустить sln файл.

### Необходимые условия

Для установки необходима Visual Studio.
<br>
Данную программу можно скачать с 
[Visual Studio downloading](https://visualstudio.microsoft.com/ru/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false) (Перейдя по ссылке сразу начнётся установка exe файла)

### Установка

1. Шаг<br>
Проверить, если на компьютере программное обеспечение в ввиде Visual Studio. Если её нет, то необходимо перейти предыдущему пункту и прочесть его. 
2. Шаг<br>
После необходимо перейти на проект [EKZ](https://github.com/MaximChesh/EKZ)
3. Шаг<br>
Перейдя на проект необходимо нажать на зелёную кнопку Code
![Проект на GitHub](https://cdn.discordapp.com/attachments/659701707437244428/1079107836480606258/image.png)
4. Шаг<br>
Далее откроется меню, где возможно выбрать один из нескольких вариантов:
![](https://cdn.discordapp.com/attachments/659701707437244428/1079107673972289646/image.png)
    * Нажав на Open with Visual Studio, то вам откроеться программа Visual Studio и начнётся процесс переноса проекта на ваш компьютер;
    * Нажав на Dowload ZIP вы скачаете zip архив, который вам надо будет разорхивировать на компьютере. А после открыть внутри sln файл.
5. Шаг<br>
Вам необходимо будет нажать на кнопку Triangles. После этого запуститься программа.
![](https://cdn.discordapp.com/attachments/659701707437244428/1079108022552506489/image.png)
6. Шаг<br>
Программа запущена!
![Запущенная программа](https://cdn.discordapp.com/attachments/659701707437244428/1079109445767929957/image.png)

## Код

``` C#
public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double grA = 1500;
            double VA = 12;
            double lengthA = 3.5;
            double widthA = 1.8;

            double cost = 35;
            double Summa = 0;

            try
            {
                double length = 0;
                double width = 0;
                double height = 0;
                double density = 0;
                double distance = 0;

                length = print.printLength(length, lengthA); 
                width = print.printWidth(width, widthA);
                height = print.printHeight(height);
                density = print.printDensity(density);
                distance = print.printDistance(distance);

                Summa = stoimost.SUM(VA,grA,Summa, width, height, length, density, distance, cost);

                string result = Convert.ToString(Summa);

                try
                {
                    Console.WriteLine("Введите путь файла для сохранения данных: \n");
                    string fileNamewrite = Console.ReadLine();

                    writefile.writetxt(@fileNamewrite, result);
                }
                catch (Exception) { Console.WriteLine("Ошибка введенном пути файла"); }

                Console.ReadKey();
            }
            catch (Exception) { Console.WriteLine("Ошибка ввода данных");}
        }
        
    }
```

## Авторы

* **Кулюкина Дарья** - *Основная работа* - [MaximChesh](https://github.com/MaximChesh)

See also the list of [EKZ](https://github.com/MaximChesh/EKZ) who participated in this project.
