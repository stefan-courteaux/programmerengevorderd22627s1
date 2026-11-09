var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapPost("/upload", async (IFormFile file) =>
{
    using var memoryStream = new MemoryStream();
    await file.CopyToAsync(memoryStream);
    var fileBytes = memoryStream.ToArray();
    
    Console.WriteLine($"Uploaded {fileBytes.Length} bytes.");
    
}).DisableAntiforgery();

app.Run();
