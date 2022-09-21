Console.WriteLine("Меню:\r\n" +
"1. Сложить 2 числа\r\n" +
"2.Вычесть первое из второго\r\n" +
"3.Перемножить два числа\r\n" +
"4.Разделить первое на второе\r\n" +
"5.Возвести в степень N первое число\r\n" +
"6.Найти квадратный корень из числа\r\n" +
"7.Найти 1 процент от числа\r\n" +
"8.Найти факториал из числа\r\n" +
"9.Выйти из программы\r\n");
bool BillieHarrington = true;

do
{
    Console.WriteLine("Введите номер математической операции ");
    int operationNumber = Convert.ToInt32(Console.ReadLine());
    if (operationNumber == 9)
    {
        BillieHarrington = false;
    }
    if (operationNumber == 1)
    {
        Console.WriteLine("Введите первое число ");
        int fNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите первое число ");
        int sNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(sNumber + fNumber);
    }
    if (operationNumber == 2)
    {
        Console.WriteLine("Введите первое число ");
        int fNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите первое число ");
        int sNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(sNumber - fNumber);
    }
    if (operationNumber == 3)
    {
        Console.WriteLine("Введите первое число ");
        int fNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите первое число ");
        int sNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(fNumber * sNumber);
    }
    if (operationNumber == 4)
    {
        Console.WriteLine("Введите первое число ");
        int fNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите первое число ");
        int sNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(fNumber / sNumber);
    }
    if (operationNumber == 5)
    {
        Console.WriteLine("Введите число ");
        int fNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень числа");
        int sNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Pow(fNumber, sNumber));
    }
    if (operationNumber == 6)
    {
        Console.WriteLine("Введите число ");
        int fNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(fNumber));
    }
    if (operationNumber == 7)
    {
        Console.WriteLine("Введите число ");
        int fNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((fNumber / 100) * 1);
    }
    if (operationNumber == 8)
    {
        Console.Write("Введите число ");
        int fNumber = int.Parse(Console.ReadLine());
        int fact = 1;
        for (int i = 1; i <= fNumber; i++)
        {
            fact *= i;
        }
        Console.WriteLine(fact);
    }
}
while (BillieHarrington == true);
{
    Console.WriteLine("sucsessfull exit");
}




