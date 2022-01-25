using System.Collections.Generic;
Console.WriteLine("Enter as many integers as you wish seperated by spaces, press return when you are ready for the sum");
string my_string;

my_string = Console.ReadLine();

string[] items = my_string.Split(" ");
int sum;
sum = 0;
foreach(string item in items)
{
    int number;
    bool success = int.TryParse(item, out number);
    if (success)
    {
        sum = sum + number;
        Console.WriteLine($"Accepted: " + item+", the total is now: "+sum);
        
    }
    else
    {
        Console.WriteLine($"Rejected:"+item +" invalid integer!");
    }
}

Console.WriteLine($"The total final sum of acceptable integers is " + sum);

