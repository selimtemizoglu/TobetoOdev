static void Add()
{
    Console.WriteLine("Added!");
}
Add();
Add();
var result = Add2(2,4);
Console.WriteLine(result);
static int Add2(int number1, int number2)
{
    var result = number1 + number2;
    return result;
}

Console.ReadLine();

