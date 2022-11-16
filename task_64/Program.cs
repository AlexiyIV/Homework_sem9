int InputData(string message)
{
    Console.Write(message);
    int d = int.Parse(Console.ReadLine());
    return d;
}

int AllNatur(int n)
{
    if (n > 1) return AllNatur(n - 1) + 1;
    else return 1;
}

void Print(int n)
{
    for (int i = n; i > 0; i--)
    {
        Console.Write(AllNatur(i) + " ");
    }
}

int n = InputData("Введите N ");

Print(n);


