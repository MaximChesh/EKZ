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
После необходимо перейти на проект [EKZ](https://github.com/mitiay1973/maska)
3. Шаг<br>
Перейдя на проект необходимо нажать на зелёную кнопку Code
![Проект на GitHub](https://sun9-60.userapi.com/impg/1bZeOSgWhk8xtSZ74h11Q_-reWGUXLBCSt0Oow/fdHX7uBWcbM.jpg?size=1002x281&quality=96&sign=849903628027a4362bbf2184c594bfad&type=album)
4. Шаг<br>
Далее откроется меню, где возможно выбрать один из нескольких вариантов:
![](https://sun9-65.userapi.com/impg/MKY2GfBMb5N7jkUXL1Bld18RvWEzjG-58Tko8w/8uVyz5s-dK4.jpg?size=441x470&quality=96&sign=19d1e79b08fd17c5fe21d1cafce5cd65&type=album)
    * Нажав на Open with Visual Studio, то вам откроеться программа Visual Studio и начнётся процесс переноса проекта на ваш компьютер;
    * Нажав на Dowload ZIP вы скачаете zip архив, который вам надо будет разорхивировать на компьютере. А после открыть внутри sln файл.
5. Шаг<br>
Вам необходимо будет нажать на кнопку Triangles. После этого запуститься программа.
![](https://sun9-north.userapi.com/sun9-80/s/v1/ig2/YqV0R3rfGvS9zz5vzHovNsHI9oa62K9zglGlJzOobILmaaowrC4ZCD1A7UbupGZSO8Hzykoz9QPLQHreCMWOncc5.jpg?size=943x307&quality=96&type=album)
6. Шаг<br>
Программа запущена!
![Запущенная программа](https://sun9-38.userapi.com/impg/4Bo_6VuuIFym5KNXb5YAfajwhD669dYZnlNQMQ/wxrhiSqCfqQ.jpg?size=1175x683&quality=96&sign=9ce631a0e06e54fe108519ce6f9bd963&type=album)

## Код

``` C#
public Frame frame1;
        String User;
        public Maski(Frame frame, string user)
        {
            InitializeComponent();
            User = user;
            if(User== "Guest")
            {
                AddMaska.Visibility= Visibility.Collapsed;
            }
            var allTypes = Entities.GetContext().ProductType.ToList();
            allTypes.Insert(0, new ProductType
            {
                Title = "Все типы"
            });
            ComboType.ItemsSource = allTypes;
            ComboType.SelectedIndex = 0;
            frame1 = frame;
            var current = Entities.GetContext().Product.ToList();
            LViewTours.ItemsSource = current;
        }
        private void UpdateMaski()
        {
            var currentProducts = Entities.GetContext().Product.ToList();
            if (ComboType.SelectedIndex>0)
            {
                for (int i = 0; i < currentProducts.Count; i++)
                {
                    if (currentProducts[i].ProductType.Title!=ComboType.Text)
                    {
                        currentProducts.RemoveAt(i);
                        i--;
                    }
                }
            }
            currentProducts = currentProducts.Where(p => p.Title.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
            LViewTours.ItemsSource = currentProducts.ToList();
        }
        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateMaski();
        }

        private async void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await Task.Delay(100);
            UpdateMaski();
        }

        private void AddMaska_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(new AddMaska(frame1, User));
        }
        private async void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            if (User != "Guest")
            {
                await Task.Delay(100);
                object itemm = LViewTours.SelectedItem;
                    frame1.Navigate(new IzmMaska(frame1, User, itemm));
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(new Glavnaya( User, frame1));
        }
```
## Поледняя версия
Maska -[Maska 1.0.zip](https://github.com/mitiay1973/maska/files/10717304/Maska.1.0.zip)

## Авторы

* **Кулюкина Дарья** - *Макет приложения* - [MaximChesh](https://github.com/MaximChesh)
* **Смолин Иван** - *Макет приложения* - [Pieez](https://github.com/Pieez)
* **Барашенков Илья** - *Разработка дизайна (UI), тестирование* - [FannDrozh](https://github.com/FannDrozh)
* **Кирилл Манаков** - *Разработка дизайна (UI)* - [KirillManakow](https://github.com/KirillManakow)
* **Дима Сорокин** - *Разработка функционала программы* - [mitiay1973](https://github.com/mitiay1973)
* **Анастасия Полковникова** - *Работа с БД SQL* - [PolkovnikovaA](https://github.com/PolkovnikovaA)
* **Анастасия Власова** - *Работа с БД SQL* - [Anastasiy1307](https://github.com/Anastasiy1307)
* **Зуева Елизавета** - *Работа с БД SQL* - [zuevae](https://github.com/zuevae)

See also the list of [Maska](https://github.com/mitiay1973/maska) who participated in this project.
