using System;

namespace OPD_1
{
    internal class Program
    {
        static void Strategy()
        {
            Matrix matrix = new Matrix();

            while (true)
            {            
                Console.Clear();
                Console.WriteLine("Cтратегия и сортировка");
                Console.WriteLine("1 – Выбрать алгоритм сортировки");
                Console.WriteLine("2 – Выбрать тип сортировки");
                Console.WriteLine("3 – Отсортировать матрицу");
                Console.WriteLine("0 - Назад");
                switch (char.ToLower(Console.ReadKey(true).KeyChar))
                {
                    case '1':
                        ChoseStrategy(ref matrix);
                        break;
                    case '2':
                        ChoseType(ref matrix);
                        break;
                    case '3':
                        Console.Clear();
                        Console.Write("до    ");
                        matrix.Show();
                        matrix.SortMatrix();
                        Console.Write("после ");
                        matrix.Show();
                        Console.WriteLine("Нажмите чтобы продолжить ...");
                        Console.ReadKey();
                        break;
                    case '0':
                        return;
                    default:
                        break;
                }
            }

        }
        static void ChoseStrategy(ref Matrix mat)
        {
            Console.Clear();
            Console.WriteLine("Алгоритмы");
            Console.WriteLine("1 – Buble Sort");
            Console.WriteLine("0 - Назад");
            switch (char.ToLower(Console.ReadKey(true).KeyChar))
            {
                case '1':
                    mat.setAlgorythm(new BubleSort());
                    break;
                case '0':
                    return;
                default:
                    break;
            }
        }
        static void ChoseType(ref Matrix mat)
        {
            Console.Clear();
            Console.WriteLine("Тип сортировки");
            Console.WriteLine("1 – В порядке возрастания сумм элементов строк матрицы");
            Console.WriteLine("2 – В порядке убывания сумм элементов строк матрицы");
            Console.WriteLine("3 - По возрастанию максимального элемента в строке матрицы");
            Console.WriteLine("4 – По убыванию максимального элемента в строке матрицы");
            Console.WriteLine("5 - В порядке возрастания минимального элемента в строке матрицы");
            Console.WriteLine("6 – В порядке убывания минимального элемента в строке матрицы");
            Console.WriteLine("0 - Назад");
            switch (char.ToLower(Console.ReadKey(true).KeyChar))
            {
                case '1':
                    mat.setType(new SumType(false));
                    break;
                case '2':
                    mat.setType(new SumType(true));
                    break;
                case '3':
                    mat.setType(new MaxType(false));
                    break;
                case '4':
                    mat.setType(new MaxType(true));
                    break;
                case '5':
                    mat.setType(new MinType(false));
                    break;
                case '6':
                    mat.setType(new MinType(true));
                    break;
                case '0':
                    return;
                default:
                    break;
            }
        }
        static void Observer()
        {
            int time = 5;
            string message = "Тестовое сообщение";
            Countdown cd = new Countdown();
            cd.Attach(new ObserverA());
            cd.Attach(new ObserverB());
            cd.Attach(new ObserverC());
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Наблюдатель");
                Console.WriteLine("1 – Задать сообщение");
                Console.WriteLine("2 – Задать задержку");
                Console.WriteLine("3 – Отправить сообщение");
                Console.WriteLine("0 - назад");
                switch (char.ToLower(Console.ReadKey(true).KeyChar))
                {
                    case '1':
                        Console.Clear();
                        Console.Write("Введите сообщение:");
                        message = Console.ReadLine();
                        break;
                    case '2':
                        Console.Clear();
                        Console.Write("Задайте время в секундах:");
                        Int32.TryParse(Console.ReadLine(), out time);
                        break;
                    case '3':
                        Console.Clear();
                        cd.SendMessages(message, time);
                        Console.WriteLine("Нажмите чтобы продолжить ...");
                        Console.ReadKey();
                        break;
                    case '0':
                        return;
                    default:
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Практическое задание #2");
                Console.WriteLine("1 – Cтратегия и сортировка");
                Console.WriteLine("2 – Наблюдатель и подписчики");
                Console.WriteLine("0 - Выход из программы");
                switch (char.ToLower(Console.ReadKey(true).KeyChar))
                {
                    case '1':
                            Strategy();
                        break;
                    case '2':
                            Observer();
                        break;
                    case '0':
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
