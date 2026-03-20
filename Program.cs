using Microsoft.AspNetCore.HttpLogging;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();



// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});
builder.Services.AddHttpLogging(options =>
{
    options.LoggingFields = HttpLoggingFields.RequestMethod | 
                            HttpLoggingFields.RequestPath | 
                            HttpLoggingFields.ResponseStatusCode | 
                            HttpLoggingFields.Duration;
});
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

Settings.TemplatesPath = configuration.GetSection("TemplatesPath").Value!;

//app.UseHttpsRedirection(); // WHILE uplay does seemingly have support for https, we have no feasible way of patching urls rn so we stay on HTTP primarily for development reasons.
app.UseHttpLogging();
app.UseStaticFiles();
app.MapControllers();
app.Run();
