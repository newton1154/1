
Console.WriteLine("Введите номер операции:");
Console.WriteLine("1. Сложение");
Console.WriteLine("2. Вычитание");
Console.WriteLine("3. Умножение");
Console.WriteLine("4. Деление");
start:
string input = Console.ReadLine();

if (int.TryParse(input, out int choice))
{
    Console.Write("Введите первое число: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int num2 = int.Parse(Console.ReadLine());

    double result;
    switch (choice)
    {
        case 1:
            result = num1 + num2;
            Console.WriteLine($"Результат: {num1} + {num2} = {result}");
            break;
        case 2:
            result = num1 - num2;
            Console.WriteLine($"Результат: {num1} - {num2} = {result}");
            break;
        case 3:
            result = num1 * num2;
            Console.WriteLine($"Результат: {num1} * {num2} = {result}");
            break;
        case 4:
            if (num2 == 0)
            {
                Console.WriteLine("Ошибка: Деление на 0");
            }
            else
            {
                result = (double)num1 / num2;
                Console.WriteLine($"Результат: {num1} / {num2} = {result}");
            }
            break;
        default:
            Console.WriteLine("Ошибка: Неверный номер операции");
            break;

    }
}
else
{
    Console.WriteLine("Ошибка: Неверный ввод");
}
goto start;