//variables_challenge

//Write code in the .NET Editor to display a message
//When you're finished, the message should resemble the following output:

//Output
//Hello, Bob! You have 3 in your inbox. The temperature is 34.4 celsius.

//Store the following values from the output in variables:

//Bob
//3
//34.4
//These variables should be given names that reflect their purpose.

//Make sure you select the correct data type for each of the variables based on the type of data it will hold.

//Finally, you'll combine the variables with literal strings passed into a series of Console.Write() commands to form the complete message.

//Whether you get stuck and need to peek at the solution or you finish successfully, continue on to view a solution to this challenge.

string name = "Bob";
int num = 3;
decimal num2 = 34.4m;

Console.Write("Hello ");
Console.Write(name);
Console.Write("! ");
Console.Write("You have ");
Console.Write(num);
Console.Write(" in your inbox.  The temperature is ");
Console.Write(num2);
Console.Write(" celsius.");
