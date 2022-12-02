// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double k1 = AskDoubleNumber("Введите k1: ");
double b1 = AskDoubleNumber("Введите b1: ");
double k2 = AskDoubleNumber("Введите k2: ");
double b2 = AskDoubleNumber("Введите b2: ");

double[] crossCoordinates = FindCrossPoint(k1,b1,k2,b2);
PrintArray(crossCoordinates);

double[] FindCrossPoint(double k1, double b1, double k2, double b2)
{
    double[] result = new double[2];
    result[0] = (b2-b1)/(k1-k2);
    result[1] = (k1*b2-k2*b1)/(k1-k2);

    return result;
}

double AskDoubleNumber(string WelcomeText)
{
    Console.Write(WelcomeText);
    string input = Console.ReadLine() ?? string.Empty;
    return Convert.ToDouble(input);
}

void PrintArray(double[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
        Console.Write(array[i] + ((i == count - 1) ? "]" : ", "));

}