using Resume_NicolasCastillo_Backend.Data;
using Resume_NicolasCastillo_Backend.Servicios;

var builder = WebApplication.CreateBuilder(args);

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(int.Parse(port));
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp", policy =>
    {
        policy
            .WithOrigins("http://localhost:4200") 
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials(); 
    });
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IConfigurationService,  ConfigurationService>();
builder.Services.AddScoped<ISendMailService, SendMailService>();
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<ILanguageService, LanguageService>();
builder.Services.AddScoped<ITechnologyService, TechnologyService>();
builder.Services.AddScoped<IWorkExperienceService, WorkExperienceService>();
builder.Services.AddScoped<ICertificationService, CertificationService>();
builder.Services.AddScoped<IEducationService, EducationService>();


var app = builder.Build();

app.UseCors("AllowAngularApp");

app.UseSwagger();
app.UseSwaggerUI();
DataGenerator.Seed();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
