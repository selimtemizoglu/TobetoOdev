var number = 10;

if (number >= 0 && number<= 100)
{
    Console.WriteLine("Number is between 0-100");
}
else if (number > 0 && number <= 200)
{
    Console.WriteLine("Number is between 101-200");
}
else if (number > 200 || number < 0 )
{
    Console.WriteLine("Number is less than 0 or greater than 200");
}
Console.ReadLine();