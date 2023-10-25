static void Add()
{
    Console.WriteLine("Added!");
}
Add();
Add();
var result = Add2(2);
Console.WriteLine(result);

//int number1;
//int number2 = 100;
//var result2 = Add3(out number1, number2);
//Console.WriteLine(result2);
//Console.WriteLine(number1);

Console.WriteLine(Multiply(2, 4));

Console.WriteLine(Multiply2(2, 4, 6));

Console.WriteLine(Add4(1,2,3,4,5,6));

static int Add2(int x, int number1 = 12, int number2 = 15)
{
    var result = number1 + number2;



    return result;
}

static int Add3(out int number1, int number2)
{
    return number1 = 30 + number2;
}

static int Multiply(int number1, int number2)
{
    return number1 * number2;
}
static int Multiply2(int number1, int number2, int number3)
{
    return number1 * number2 * number3;
}

static int Add4(params int [] numbers)
{
    return numbers.Sum();
}
Console.ReadLine();

