var builder = WebApplication.CreateBuilder(args);

//services are added to the container here.
var app = builder.Build();
// Middleware can be added to the pipeline here.

app.Use( async(context,nextMiddleWare) =>
{
    //preprocessing logic
    Console.WriteLine("preprocssing for Middleware 1");
    await nextMiddleWare();

    //postprocessing logic
    Console.WriteLine("PostProcessing for Middleware 1");
});

app.Use(async (context, nextMiddleWare) =>
{
    //preprocessing logic
    Console.WriteLine("preprocssing for Middleware 2");
    await nextMiddleWare();
    Console.WriteLine("PostProcessing for Middleware 2");

    //postprocessing logic
});

app.MapGet("/", () => "Hello World!");

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("<h1>Inside Run 1</1h>");
//});


app.MapGet("/howdy",()=> Results.Content("<h1>Howdy , Kline</h1>","text/html"));

app.Run();
