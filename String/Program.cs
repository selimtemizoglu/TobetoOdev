﻿NewMethod();

static void NewMethod()
{
    string city = "Ankara";
    //Console.WriteLine(city[0])

    foreach (var item in city)
    {
        Console.WriteLine(item);
    }

    string city2 = "İstanbul";

    Console.WriteLine(String.Format("{0}{1}", city, city2));
    Console.ReadLine();
}
