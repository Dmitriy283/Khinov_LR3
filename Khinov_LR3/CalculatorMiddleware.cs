namespace Khinov_LR3
{
    public class CalculatorMiddleware
    {
        readonly RequestDelegate next;
        public CalculatorMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext context, WhatTime time, CalcService calcService)
        {
            string path = context.Request.Path;
            if (path == "/calculator")
            {
                int x = Int32.Parse(context.Request.Query["x"]);
                int y = Int32.Parse(context.Request.Query["y"]);
                var path2 = context.Request.Query["oper"];
                String result;
                if (path2 == "plus")
                {
                    result = $"<p>{x}+{y} = {calcService.Add(x, y)}";
                    await context.Response.WriteAsync(result);
                }
                if (path2 == "minus")
                {
                    result = $"<p>{x}-{y} = {calcService.Sub(x, y)}";
                    await context.Response.WriteAsync(result);
                }
                if (path2 == "mutli")
                {
                    result = $"<p>{x}*{y} = {calcService.Multi(x, y)}";
                    await context.Response.WriteAsync(result);
                }
                if (path2 == "divide")
                {
                    result = $"<p>{x}/{y} = {calcService.Div(x, y)}";
                    await context.Response.WriteAsync(result);
                }

            }
            else if (path == "/time")
            {
                await context.Response.WriteAsync(time.GetTimeNow());
            }
            else
            {
                await context.Response.WriteAsync("Hello World!, Enter /calculator or /time");
            }
        }
    }
}
