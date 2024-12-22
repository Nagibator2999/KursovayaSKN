﻿using KursovayaP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaP.ViewModel
{
    public class ArtifactsVM
    {
        public List<Artifact> Artifacts { get; set; }

        public ArtifactsVM()
        {
            Artifacts = new List<Artifact>
        {
                new Artifact { SetName = "Изумрудная тень", TwoPieceBonus = "Бонус Анемо Урона +15%", FourPieceBonus = "Увеличивает урон от Вихря на 60%. Снижает сопротивление противника к элементу, который был в Вихре, на 40% на 10 секунд." },
                new Artifact { SetName = "Обсидиановый фолиант", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Свиток героя сожжённого города", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Фрагмент гармонической фантазии", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Незаконченные грёзы", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Ночной шёпот в Лесу откликающегося эха", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Песнь былых времён", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Охотник Сумеречного двора", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Золотая труппа", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Сияние Вурукаши", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Сон нимфы", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Цветок потерянного рая", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Хроники Чертогов в пустыне", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Позолоченные сны", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Воспоминания дремучего леса", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Киноварное загробье", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Отголоски подношения", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Моллюск морских красок", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Кокон сладких грёз", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Воспоминания Симэнавы", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Эмблема рассечённой судьбы", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Бледный огонь", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Стойкость Миллелита", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Сердце глубин", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Заблудший в метели", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Встречная комета", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Архаичный камень", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Ступающий по лаве", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Горящая алая ведьма", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Усмиряющий гром", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Громогласный рёв ярости", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Изумрудная тень", TwoPieceBonus = "Бонус Анемо Урона +15%", FourPieceBonus = "Увеличивает урон от Вихря на 60%. Снижает сопротивление противника к элементу, который был в Вихре, на 40% на 10 секунд." },
                new Artifact { SetName = "Рыцарь крови", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Церемония древней знати", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Возлюбленная юная дева", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Странствующий ансамбль", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },
                new Artifact { SetName = "Конец гладиатора", TwoPieceBonus = "Бонус Пиро Урона +15%", FourPieceBonus = "Увеличивает урон от Перегрузки и Горения на 40%. При срабатывании таких эффектов уменьшает время восстановления Элементального навыка на 1 секунду. Может происходить раз в 0.8 секунд." },

        };
        }
    }
}