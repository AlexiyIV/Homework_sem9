long InputData(string msg)
{
    Console.Write(msg);
    long d = long.Parse(Console.ReadLine());
    return d;
}

long AckermansFunction(long m, long n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermansFunction(m - 1, 1);
    else return AckermansFunction(m - 1, AckermansFunction(m, n - 1)); ;
}

long m = InputData("Введите M ");
long n = InputData("Введите N ");

if (m >= 0 && n >= 0) Console.WriteLine(AckermansFunction(m, n));
else Console.WriteLine("Ошибка");