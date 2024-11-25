using System;
using System.Collections.Generic;


namespace practice__5
{
    //производный класс "Клавиатура"
    public class Keyboard : ComputerTechnique
    {
        int weight;
        public string backlighting;

        //конструктор с параметрами
        public Keyboard(string manufacturer = "Неизвестно", string model = "Неизвестно", int price = 0, int weight = 0, string backlighting = "Неизвестно")
            : base(manufacturer, model, price)
        {
            this.Weight = weight;
            this.Backlighting = backlighting;
        }
        //виртуальная функция печати сведений об объекте
        public override string PrintInfo()
        {
            return $"Клавиатура. Производитель: {Manufacturer}, Модель: {Model}, Цена: {Price}, Вес: {Weight}, Подсветка: {Backlighting}";
        }
        //свойства
        public int Weight
        {
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    Console.WriteLine("Значение веса введено некорректно. Установим значение для данной характеристики равное 0");
                }
            }
            get
            {
                return weight;
            }
        }

        public string Backlighting
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    backlighting = value;
                }
                else
                {
                    Console.WriteLine("Характеристика тип подсветки не может быть пустой. Установим значение по умолчанию: 'Неизвестно'.");
                    backlighting = "Неизвестно";
                }
            }
            get
            {
                return backlighting;
            }
        }

    }
}
