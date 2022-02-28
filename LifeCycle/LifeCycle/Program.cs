var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();
Console.WriteLine("Hello");
//This is the area for the middleware


app.MapGet("/", () => "Hello World!");
app.MapGet("/normal", ()=> "Hello Normal World!");
//Console.WriteLine("MapGet Was Called");
app.Use(async (HttpContext c,  RequestDelegate n) =>
{
    if (c.Request.Path == "/short")
    {
        Console.WriteLine("This is on /short");
        await n(c);
    }
    else
    {
        Console.WriteLine("not on /short");
    }
   
    Console.WriteLine("end of middleware 1");
});
app.Run( async c => {
    Console.WriteLine("starting 2nd middleware");
      await c.Response.WriteAsync("2nd Middleware Executed");
    Console.WriteLine("exitting 2nd middleare");
});

//end of middleware
Console.WriteLine("Calling Run ");
app.Run();
Console.WriteLine("Exiting");