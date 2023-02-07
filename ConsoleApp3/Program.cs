// See https://aka.ms/new-console-template for more information
int number = new Random().Next(10) + 1;
int attempts = 0;
Console.WriteLine("Игра \"Угадай число\".");
Console.WriteLine("Компьютер \"задумал\"число от 1 до 10.");
Console.WriteLine("Угадайте чиисло за 5 попыток");
Console.WriteLine();
do
{
    Console.WriteLine("Введите число и нажмите Enter");
    Console.Write("-> ");
    int input = int.Parse(Console.ReadLine());
    if (input == number) 
    {
        Console.WriteLine();
        Console.WriteLine("вы угадали число");
        Console.WriteLine("Спасибо за игру");
        goto done;

    }
    if (input > number) 
    {
        Console.WriteLine("Вы ввели число больше загадоного! Введите число от 1 до 10");
    }
    if (input != number && input < number) 
    {
        Console.WriteLine("Вы ввели число меньше звгвдоного! Введите число от 1 до 10");
    }
    attempts++;
}
while (attempts != 5);
Console.Clear();
Console.WriteLine();
Console.WriteLine("вы несправились! Побробуйте ещё раз");
done:
Console.ReadKey();
