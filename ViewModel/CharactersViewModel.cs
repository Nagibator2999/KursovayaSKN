using KursovayaP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace KursovayaP.ViewModel
{
    public class CharactersViewModel
    {
        public List<Character> Characters { get; set; }

        public CharactersViewModel()
        {
            Uri UriImages = new Uri("/Sourse/Images/CharactersIcon/5/albedo.jpg", UriKind.Relative);
            Characters = new List<Character>
            {
                new Character {
                    Name = "Альбедо",
                    Element = "Гео",
                    Weapon = "Меч",
                    BestArtifactSet = "Горного Роста",
                    Image = new BitmapImage(UriImages)
                }
            };
            Uri UriImages1 = new Uri("/Sourse/Images/CharactersIcon/4/ember.png", UriKind.Relative);
            Characters = new List<Character>
            { 
                new Character {
                    Name = "Эмбер",
                    Element = "Пиро",
                    Weapon = "Лук",
                    BestArtifactSet = "Горячего Пожара",
                    Image = new BitmapImage(UriImages1)
                }
              };
                //new Character {
                //    Name = "Барбара",
                //    Element = "Гидро",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Водного Покрова",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Беннетт",
                //    Element = "Пиро",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Горячего Пожара",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Дилюк",
                //    Element = "Пиро",
                //    Weapon = "Двуручный меч",
                //    BestArtifactSet = "Горячего Пожара",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Диона",
                //    Element = "Крио",
                //    Weapon = "Лук",
                //    BestArtifactSet = "Снежной Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Эола",
                //    Element = "Крио",
                //    Weapon = "Двуручный меч",
                //    BestArtifactSet = "Снежной Ярости",
                //    Image = new BitmapImage(UriImages)

                //},
                //new Character {
                //    Name = "Фишль",
                //    Element = "Электро",
                //    Weapon = "Лук",
                //    BestArtifactSet = "Громовой Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Джинн",
                //    Element = "Анемо",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Вестерождённый",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Кэйа",
                //    Element = "Крио",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Снежной Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Кли",
                //    Element = "Пиро",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Горячего Пожара",
                //    Image = new BitmapImage(UriImages)                 
                //},
                //new Character {
                //    Name = "Лиза",
                //    Element = "Электро",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Громовой Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Мика",
                //    Element = "Крио",
                //    Weapon = "Копьё",
                //    BestArtifactSet = "Снежной Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Мона",
                //    Element = "Гидро",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Водного Покрова",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Ноэлль",
                //    Element = "Гео",
                //    Weapon = "Двуручный меч",
                //    BestArtifactSet = "Горного Роста",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Рейзор",
                //    Element = "Электро",
                //    Weapon = "Двуручный меч",
                //    BestArtifactSet = "Громовой Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Розария",
                //    Element = "Крио",
                //    Weapon = "Копьё",
                //    BestArtifactSet = "Снежной Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Сахароза",
                //    Element = "Анемо",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Вестерождённый",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Венти",
                //    Element = "Анемо",
                //    Weapon = "Лук",
                //    BestArtifactSet = "Вестерождённый",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Бай Чжу",
                //    Element = "Дендро",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Цветущего Камня",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Бей Доу",
                //    Element = "Электро",
                //    Weapon = "Двуручный меч",
                //    BestArtifactSet = "Громовой Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Чун Юнь",
                //    Element = "Крио",
                //    Weapon = "Двуручный меч",
                //    BestArtifactSet = "Снежной Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Ка Мин",
                //    Element = "Пиро",
                //    Weapon = "Двуручный меч",
                //    BestArtifactSet = "Горячего Пожара",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Гань Юй",
                //    Element = "Крио",
                //    Weapon = "Лук",
                //    BestArtifactSet = "Снежной Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Ху Тао",
                //    Element = "Пиро",
                //    Weapon = "Копьё",
                //    BestArtifactSet = "Горячего Пожара",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Кэ Цин",
                //    Element = "Электро",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Громовой Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Нин Гуан",
                //    Element = "Гео",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Горного Роста",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Цици",
                //    Element = "Крио",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Снежной Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Шень Хэ",
                //    Element = "Крио",
                //    Weapon = "Копьё",
                //    BestArtifactSet = "Снежной Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Сянлин",
                //    Element = "Пиро",
                //    Weapon = "Копьё",
                //    BestArtifactSet = "Горячего Пожара",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Сянь Юнь",
                //    Element = "Анемо",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Вестерождённый",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Сяо",
                //    Element = "Анемо",
                //    Weapon = "Копьё",
                //    BestArtifactSet = "Вестерождённый",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Син Цю",
                //    Element = "Гидро",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Водного Покрова",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Синь Янь",
                //    Element = "Пиро",
                //    Weapon = "Двуручный меч",
                //    BestArtifactSet = "Горячего Пожара",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Янь Фэй",
                //    Element = "Пиро",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Горячего Пожара",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Яо Яо",
                //    Element = "Дендро",
                //    Weapon = "Копьё",
                //    BestArtifactSet = "Цветущего Камня",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Е Лань",
                //    Element = "Гидро",
                //    Weapon = "Лук",
                //    BestArtifactSet = "Водного Покрова",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Юнь Цзинь",
                //    Element = "Гео",
                //    Weapon = "Копьё",
                //    BestArtifactSet = "Горного Роста",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Чжун Ли",
                //    Element = "Гео",
                //    Weapon = "Копьё",
                //    BestArtifactSet = "Горного Роста",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Аратаки Итто",
                //    Element = "Гео",
                //    Weapon = "Двуручный меч",
                //    BestArtifactSet = "Горного Роста",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Тиори",
                //    Element = "Гео",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Горного Роста",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Горо",
                //    Element = "Гео",
                //    Weapon = "Лук",
                //    BestArtifactSet = "Горного Роста",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Каэдехара Кадзуха",
                //    Element = "Анемо",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Вестерождённый",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Камисато Аяка",
                //    Element = "Крио",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Снежной Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Камисато Аято",
                //    Element = "Гидро",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Водного Покрова",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Кирара",
                //    Element = "Дендро",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Цветущего Камня",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Кудзе Сара",
                //    Element = "Электро",
                //    Weapon = "Лук",
                //    BestArtifactSet = "Громовой Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Куки Синобу",
                //    Element = "Электро",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Громовой Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Райден Сегун",
                //    Element = "Электро",
                //    Weapon = "Копьё",
                //    BestArtifactSet = "Громовой Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Сангономия Кокоми",
                //    Element = "Гидро",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Водного Покрова",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Саю",
                //    Element = "Анемо",
                //    Weapon = "Двуручный меч",
                //    BestArtifactSet = "Вестерождённый",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Сиканоин Хейдзо",
                //    Element = "Анемо",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Вестерождённый",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Тома",
                //    Element = "Пиро",
                //    Weapon = "Копьё",
                //    BestArtifactSet = "Горячего Пожара",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Яэ Мико",
                //    Element = "Электро",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Громовой Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Ёимия",
                //    Element = "Пиро",
                //    Weapon = "Лук",
                //    BestArtifactSet = "Горячего Пожара",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Аль-Хайтам",
                //    Element = "Дендро",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Цветущего Камня",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Кандакия",
                //    Element = "Гидро",
                //    Weapon = "Копьё",
                //    BestArtifactSet = "Водного Покрова",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Коллеи",
                //    Element = "Дендро",
                //    Weapon = "Лук",
                //    BestArtifactSet = "Цветущего Камня",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Сайно",
                //    Element = "Электро",
                //    Weapon = "Копьё",
                //    BestArtifactSet = "Громовой Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Дэхья",
                //    Element = "Пиро",
                //    Weapon = "Двуручный меч",
                //    BestArtifactSet = "Горячего Пожара",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Дори",
                //    Element = "Электро",
                //    Weapon = "Двуручный меч",
                //    BestArtifactSet = "Громовой Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Фарузан",
                //    Element = "Анемо",
                //    Weapon = "Лук",
                //    BestArtifactSet = "Вестерождённый",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Кавех",
                //    Element = "Дендро",
                //    Weapon = "Двуручный меч",
                //    BestArtifactSet = "Цветущего Камня",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Лайла",
                //    Element = "Крио",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Снежной Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Нахида",
                //    Element = "Дендро",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Цветущего Камня",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Нилу",
                //    Element = "Гидро",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Водного Покрова",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Сетос",
                //    Element = "Электро",
                //    Weapon = "Лук",
                //    BestArtifactSet = "Громовой Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Тигнари",
                //    Element = "Дендро",
                //    Weapon = "Лук",
                //    BestArtifactSet = "Цветущего Камня",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Странник",
                //    Element = "Анемо",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Вестерождённый",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Шарлотта",
                //    Element = "Крио",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Снежной Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Шеврёз",
                //    Element = "Пиро",
                //    Weapon = "Копьё",
                //    BestArtifactSet = "Горячего Пожара",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Клоринда",
                //    Element = "Электро",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Громовой Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Эмилия",
                //    Element = "Дендро",
                //    Weapon = "Копьё",
                //    BestArtifactSet = "Цветущего Камня",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Фремине",
                //    Element = "Крио",
                //    Weapon = "Двуручный меч",
                //    BestArtifactSet = "Снежной Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Фурина",
                //    Element = "Гидро",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Водного Покрова",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Линетт",
                //    Element = "Анемо",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Вестерождённый",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Лини",
                //    Element = "Пиро",
                //    Weapon = "Лук",
                //    BestArtifactSet = "Горячего Пожара",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Навия",
                //    Element = "Гео",
                //    Weapon = "Двуручный меч",
                //    BestArtifactSet = "Горного Роста",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Нёвиллет",
                //    Element = "Гидро",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Водного Покрова",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Сиджвин",
                //    Element = "Гидро",
                //    Weapon = "Лук",
                //    BestArtifactSet = "Водного Покрова",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Ризли",
                //    Element = "Крио",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Снежной Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Часка",
                //    Element = "Анемо",
                //    Weapon = "Лук",
                //    BestArtifactSet = "Вестерождённый",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Качина",
                //    Element = "Гео",
                //    Weapon = "Копьё",
                //    BestArtifactSet = "Горного Роста",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Кинич",
                //    Element = "Дендро",
                //    Weapon = "Двуручный меч",
                //    BestArtifactSet = "Цветущего Камня",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Муалани",
                //    Element = "Гидро",
                //    Weapon = "Катализатор",
                //    BestArtifactSet = "Водного Покрова",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Оророн",
                //    Element = "Электро",
                //    Weapon = "Лук",
                //    BestArtifactSet = "Громовой Ярости",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Шилонен",
                //    Element = "Гео",
                //    Weapon = "Меч",
                //    BestArtifactSet = "Горного Роста",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Арлекино",
                //    Element = "Пиро",
                //    Weapon = "Копьё",
                //    BestArtifactSet = "Горячего Пожара",
                //    Image = new BitmapImage(UriImages)
                //},
                //new Character {
                //    Name = "Тарталья",
                //    Element = "Гидро",
                //    Weapon = "Лук",
                //    BestArtifactSet = "Водного Покрова",
                //    Image = new BitmapImage(UriImages)
                //},
            



        }
    }
    

}
