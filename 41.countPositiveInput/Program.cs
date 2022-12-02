int input = -1;
int i = 0;
int count = 0;
while (input != 0)
{
    i++;
    input = AskIntNumber($"Введите {i} число или 0 для выхода:");
    if (input == 0)
        break;
    else if (input > 0)
        count++;
}
Console.WriteLine($"Введено {i} чисел. Из них положительных: {count}");

int AskIntNumber(string WelcomeText)
{
    Console.Write(WelcomeText);
    string input = Console.ReadLine() ?? string.Empty;
    return Convert.ToInt32(input);
}