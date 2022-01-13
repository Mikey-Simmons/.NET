//Exercise - Character Escape Sequences and Verbatim Strings
//Suppose you've been asked by your manager to create a mockup of a command-line tool that will generate invoices in both English and Japanese. 
//You don't have to build the actual functionality that generates the invoices yet. You only need to provide the command line's user interface to internal customers in the billing department for their approval. Your manager asked you to make sure you add formatting to make the current progress of the tool clear. Your manager also asked you to provide instructions for the Japanese users on how to generate invoices in Japanese.

//Formatting Literal Strings in C#
//C# provides a wealth of options for formatting strings. We'll only look at a few of the most used in this module. However just about anything you can imagine, you could accomplish. 
//The hardest part may be knowing what terminology to use when searching for answers.

//An escape character sequence is a special instruction to the runtime that you want to insert a special character that will affect the output of your string. In C#, the escape character sequences begin with a backslash \ and then include another character. For example, the \n sequence will add a new line, and a \t sequence will add a tab.

//The following code uses escape character sequences to add whitespace.

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

//What if you need to insert a double-quotation mark in a literal string? If you don't use the character escape sequence, 
//you'll confuse the compiler because it will think you want to terminate the string prematurely ... 
//and will not understand the purpose of the characters after the second double-quotation mark.
//To handle that situation, use the \" escape sequence.

Console.WriteLine("Hello \"World\"!");

//What if you need to use the backslash for other purposes, like to display a file path?
//The problem is the sequence \s. The \r doesn't produce an error because it is a valid escape sequence for a carriage return. 
//However, it's unlikely that you would want to use a carriage return in this context.

//To solve the problem, you use the \\ to display a single backslash.

Console.WriteLine("c:\\source\\repos");

//Verbatim String Literal

// A verbatim string literal will keep all whitespace and characters without the need to escape the backslash. 
// To create a verbatim string, use the @ directive before the literal string.

Console.WriteLine(@"   c:\source\repos   
      (this is where your code goes)");