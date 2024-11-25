using System;
using System.Collections.Generic;


namespace practice__5
{
    //базовый класс "Компьютерная техника"
    public class ComputerTechnique
    {
        string manufacturer;
        string model;
        int price;
        //конструктор с параметрами
        public ComputerTechnique(string manufacturer = "Неизвестно", string model = "Неизвестно", int price = 0)
        {

            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;

        }
        //виртуальная функция для вывода сведений об объекте класса
        public virtual string PrintInfo()
        {
            return $"Компьютерная техника. Производитель: {Manufacturer}, Модель: {Model}, Цена: {Price}";
        }
        //свойства
        public string Manufacturer
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    manufacturer = value;
                }
                else
                {
                    Console.WriteLine("Характеристика производитель не может быть пустой. Установим значение по умолчанию: 'Неизвестно'.");
                    manufacturer = "Неизвестно";
                }
            }
            get
            {
                return manufacturer;
            }
        }

        public string Model
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    model = value;
                }
                else
                {
                    Console.WriteLine("Характеристика модель не может быть пустой. Установим значение по умолчанию: 'Неизвестно'.");
                    model = "Неизвестно";
                }
            }
            get
            {
                return model;
            }
        }


        public int Price
        {
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Значение цены введено некорректно. Установим значение для данной характеристики равное 0");
                }
            }
            get
            {
                return price;
            }

        }

        
        

        //функция изменения характеристик
        public static List<ComputerTechnique> ChangeCharacteristics(List<ComputerTechnique> techniques)
        {
            bool isValid = false;
            while (!isValid)
            {
                if (techniques.Count == 0)
                {
                    Console.WriteLine("\nСписок пуст.\n");
                    return techniques;
                }

                Console.WriteLine("\nВыберите объект для изменения:");
                for (int i = 0; i < techniques.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Производитель: {techniques[i].Manufacturer} " +
                        $"\n   Модель: {techniques[i].Model} " +
                        $"\n   Цена: {techniques[i].Price}");
                }

                Console.Write("Введите номер объекта: ");
                if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > techniques.Count)
                {
                    Console.WriteLine("Такого объекта нет. Выберите объект из списка. ");
                    continue;
                }
                ComputerTechnique chosenTechnique = techniques[index - 1];
                Console.WriteLine("\nВыберите изменяемую характеристику:");
                Console.WriteLine("1. Производитель");
                Console.WriteLine("2. Модель");
                Console.WriteLine("3. Цена");
                if (chosenTechnique is Keyboard)
                {
                    Console.WriteLine("4. Вес (в граммах)");
                    Console.WriteLine("5. Тип подсветки");
                }
                else if (chosenTechnique is Screen)
                {
                    Console.WriteLine("4. Частота обновления ");
                    Console.WriteLine("5. Диагональ экрана");
                }

                Console.Write("Ваш выбор: ");
                if (!int.TryParse(Console.ReadLine(), out int set))
                {
                    Console.WriteLine(" Такой характеристики нет. Выберите характеристику из списка.");
                    continue;
                }

                switch (set)
                {
                    case 1:
                        Console.Write("Введите нового производителя: ");
                        chosenTechnique.Manufacturer = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Введите новую модель: ");
                        chosenTechnique.Model = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Введите новую цену: ");
                        if (int.TryParse(Console.ReadLine(), out int newPrice))
                        {
                            chosenTechnique.Price = newPrice;
                        }
                        else
                        {
                            Console.WriteLine("Неверная цена.");
                        }
                        break;

                    case 4:
                        if (chosenTechnique is Keyboard keyboard)
                        {
                            Console.Write("Введите новый вес: ");
                            if (int.TryParse(Console.ReadLine(), out int newWeight))
                            {
                                keyboard.Weight = newWeight;
                            }
                            else
                            {
                                Console.WriteLine("Неверный вес.");
                            }
                        }
                        else if (chosenTechnique is Screen screen)
                        {
                            Console.Write("Введите новую частоту обновления (в Гц): ");
                            if (int.TryParse(Console.ReadLine(), out int newRefreshRate))
                            {
                                screen.RefreshRate = newRefreshRate;
                            }
                            else
                            {
                                Console.WriteLine("Неверное значение частоты обновления.");
                            }
                        }
                        break;

                    case 5:
                        if (chosenTechnique is Keyboard keyboardd)
                        {
                            Console.Write("Введите новый тип подсветки: ");
                            string newBacklighting = Console.ReadLine();

                            if (!string.IsNullOrWhiteSpace(newBacklighting))
                            {
                                keyboardd.Backlighting = newBacklighting;
                                Console.WriteLine($"Тип подсветки изменен на: {newBacklighting}");
                            }
                            else
                            {
                                Console.WriteLine("Характеристика не может быть пустой.");
                            }
                        }
                        else if (chosenTechnique is Screen screen)
                        {
                            Console.Write("Введите новую диагональ экрана: ");
                            if (double.TryParse(Console.ReadLine(), out double newDiagonal))
                            {
                                screen.Diagonal = newDiagonal;
                                Console.WriteLine($"Диагональ экрана изменена на: {newDiagonal}");
                            }
                            else
                            {
                                Console.WriteLine("Неверная диагональ.");
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }

                Console.WriteLine("Характеристики изменены.\n");
                isValid = true;

            }
            return techniques;
        }

    }

}