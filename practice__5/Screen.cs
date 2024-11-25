using System;
using System.Collections.Generic;


namespace practice__5
{
    //производный класс "Монитор"
    public class Screen : ComputerTechnique
    {
        int refreshRate;
        double diagonal;

        //конструктор с параметрами
        public Screen(string manufacturer = "Неизвестно", string model = "Неизвестно", int price = 0, int refreshRate = 0, double diagonal = 0.0)
            : base(manufacturer, model, price)
        {
            this.RefreshRate = refreshRate;
            this.Diagonal = diagonal;
        }
        //виртуальная функция печати сведений об объекте
        public override string PrintInfo()
        {
            return $"Монитор. Производитель: {Manufacturer}, Модель: {Model}, Цена: {Price}, Частота обновления: {RefreshRate}, Диагональ: {Diagonal}";
        }


        //свойства
        public int RefreshRate
        {
            set
            {
                if (value > 0 && value < 1000)
                {
                    refreshRate = value;
                }
                else
                {
                    Console.WriteLine("Значение частоты введено некорректно. Установим значение для данной характеристики равное 0");
                }
            }
            get
            {
                return refreshRate;
            }
        }

        public double Diagonal
        {
            set
            {
                if (value > 0.0 && value < 100.0)
                {
                    diagonal = value;
                }
                else
                {
                    Console.WriteLine("Диагональ введена некорректно. Установим значение для данной характеристики равное 0");
                }
            }
            get
            {
                return diagonal;
            }
        }
    }
}
