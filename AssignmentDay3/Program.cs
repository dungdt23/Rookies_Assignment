using AssignmentDay3;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IMessageWriter, LoggingMessageWriter>();
//configure for swagger 
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapGet("/", () => "Hello World!");
app.UseMyCustomMiddleware();
app.Run();

