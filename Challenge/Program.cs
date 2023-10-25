static void Add()
{
    Console.WriteLine("Added!");
}
Add();
Add();
var result = Add2(2);
Console.WriteLine(result);

int number1 = 20;
int number2 = 100;
var result2 = Add3(ref number1,number2);
Console.WriteLine(result2);
Console.WriteLine(number1);

static int Add2(int x, int number1 = 12, int number2 = 15)
{
    var result = number1 + number2;
    return result;
}

static int Add3(ref int number1,int number2)
{
    return number1 = 30 + number2;
}

Console.ReadLine();