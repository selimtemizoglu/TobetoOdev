static void Add()
{
    Console.WriteLine("Added!");
}
Add();
Add();
var result = Add2(2);
Console.WriteLine(result);
static int Add2(int x,int number1 = 12, int number2 = 15)
{
    var result = number1 + number2;
    return result;
}

Console.ReadLine();
