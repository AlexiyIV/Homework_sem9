int InputData(string msg)
{
    Console.Write(msg);
    int d = int.Parse(Console.ReadLine());
    return d;
}

int RecSum(int m, int n)
{
    if (m <= n)  return  RecSum(m, n - 1) + n;
    else return 0;
}

int m = InputData("Введите M ");
int n = InputData("Введите N ");
if (m < n) Console.WriteLine(RecSum(m, n));
else Console.WriteLine("Ошибка");
