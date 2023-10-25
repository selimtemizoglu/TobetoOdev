string[] students = new string[3] { "Engin", "Derin", "Salih" };

string[] students2 = { "Engin", "Derin", "Salih" };
students2[3] = "Ahmet";

foreach (var student in students2)
{
    Console.WriteLine(student);
}
Console.WriteLine();
Console.ReadLine();