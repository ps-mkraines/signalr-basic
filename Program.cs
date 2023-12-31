
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR(); //.AddAzureSignalR();

var app = builder.Build();

app.UseDefaultFiles();
app.UseRouting();

app.UseStaticFiles();

app.MapHub<ChatHub>("/chat");

app.MapGet("/status", () => "Status: Green.");

app.Run();
