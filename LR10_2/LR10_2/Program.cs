int Gen()
{
    Random rand = new Random();
    int res = rand.Next(32768, 100000);
    return res;
}

int num = Gen();
Console.WriteLine(num);
try
{
    try
    {
        checked
        {
            short num1 = (short)num;
            Console.WriteLine("Результат работы второго блока try: " + num1);
        }
    }
    catch (OverflowException)
    {
        Console.WriteLine("Сработал внутренний обработчик");
        throw;
    }
}
catch
{
    Console.WriteLine("Сработал внешний обработчик");
}
finally
{
    unchecked
    {
        short fin = (short)Gen();
        Console.WriteLine("Результат работы блока finaly: " + fin);
    }
}

//поменял