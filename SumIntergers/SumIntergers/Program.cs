using System.Collections.Generic;
Console.WriteLine("Enter as many integers as you wish seperated by spaces, press return when you are ready for the sum");
string my_string;

my_string = Console.ReadLine();
//bool TryParse(int?)
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
        Console.WriteLine($"Rejected:"+item);
    }
}

Console.WriteLine($"The total final sum of acceptable integers is " + sum);
//int[] nums = Array.ConvertAll(items, int.Parse);
//int sum;
//sum = 0;
//for (int i = 0; i < nums.Length; i++)
{
 //   sum = sum + nums[i];
//    Console.WriteLine($"Accepted: "+ nums[i]+", the total is now: "+sum);
}


