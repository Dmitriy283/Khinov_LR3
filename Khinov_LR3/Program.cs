using Khinov_LR3;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<CalcService>();
builder.Services.AddTransient<WhatTime>();
var app = builder.Build();
app.UseMiddleware<CalculatorMiddleware>();
app.Run();
