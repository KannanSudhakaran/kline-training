using Lab02MiddleAndDepdencyInjection;
using Lab02MiddleAndDepdencyInjection.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IEmailService, AmazonSES>();
//builder.Services.AddTransient<IEmailService, AmazonSES>();
//builder.Services.AddScoped<IEmailService, AmazonSES>(); //use this if you want to create a new instance for each request
builder.Services.AddControllersWithViews();//enable service for DI

var app = builder.Build();

//app.UseMiddleware<KlineMiddleware>();
app.UseMyKlineMiddleware();

app.MapDefaultControllerRoute();//enable mvc routing
//{controller=Home}/{action=Index}/{id?}

app.Run();
