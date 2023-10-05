using System.ComponentModel.Design;
using System.Net.Sockets;

int a;
float rez = 0;
do
{
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");
    a = Convert.ToInt32(Console.ReadLine());
    while (a != 9)
    {
        if (a < 1 || a >= 10)
        {
            Console.WriteLine("Введите число от 1 до 9 !!!!!!!!!!!!!!!!!!!!");
            break;
        }
        Console.WriteLine("Введите первое число");
        string b1 = Console.ReadLine();
        Console.WriteLine("Введите второе число");
        string c1 = Console.ReadLine();
        float x;
        float y;
        bool x1 = Single.TryParse(b1, out x);
        bool y1 = Single.TryParse(c1, out y);
        float b = Convert.ToSingle(b1);
        float c = Convert.ToSingle(c1);
        switch (a)
        {
            case 1:
                rez = b + c;
                break;
            case 2:
                rez = b - c;
                break;
            case 3:
                rez = b * c;
                break;
            case 4:
                if (c == 0)
                {
                    Console.WriteLine("На 0 делить нельзя!!!!!");
                }
                else
                {
                    rez = b / c;
                }
                break;
            case 5:
                rez = (float)Convert.ToDouble(Math.Pow(b, c));
                break;
            case 6:
                if (b < 0)
                {
                    Console.WriteLine("Корня из отрицательного числа не бывает!!!!");
                }
                else
                {
                    rez = (float)Convert.ToDouble(Math.Sqrt(b));
                }
                break;
            case 7:
                rez = b / 100;
                break;
            case 8:
                rez = 1;
                if (b < 0)
                {
                    Console.WriteLine("Не бывает отрицательного факториала!!!!!!");
                }
                else if (b == 0)
                {
                    rez = 1;
                }
                else
                {
                    for (int i = 1; i <= b; i++)
                    {
                        rez = rez * i;
                    }
                }
                break;
        }
        Console.WriteLine("Ваш результат:" + rez);
        rez = 0;
        Console.WriteLine("Выберите действие:");
        a = Convert.ToInt32(Console.ReadLine());

    }
} while (a != 9);