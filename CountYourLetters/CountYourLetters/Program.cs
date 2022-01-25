Console.WriteLine("Type a phrase on a single line:");
System.Collections.Generic.Dictionary<String, int> Letters;
string my_string;
my_string = Console.ReadLine();
Letters= new System.Collections.Generic.Dictionary<String, int>();

foreach( char c in my_string)
{
    string x = c.ToString();
    if(Letters.ContainsKey(x))
    {
        Letters[x] += 1;
        Console.WriteLine($"Already counted " +x + " "+  (Convert.ToInt32(Letters[x])-1) + " times.  Adding 1 more.");
    }
    else
    {
        Letters.Add(x, 1);
        Console.WriteLine($"not seen " + x + " before, setting it to 1");
    }
    
}
Console.WriteLine("*********DONE PROCESSING*********");

foreach(KeyValuePair<String, int> k in Letters)
{
    Console.WriteLine(k.Key+" was found " +k.Value+" time(s)");
}

//string[] items;
//items = new string[Letters.Count];

//foreach( char c in my_string)
//{

//   string x = c.ToString();


//   if(Letters.ContainsKey(x) && x != y)
//  {
//       Console.WriteLine(x+$" was found "+ Letters[x] + " times." );


// }
//}
