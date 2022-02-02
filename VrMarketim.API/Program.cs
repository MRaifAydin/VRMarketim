using Microsoft.AspNetCore.Mvc.Formatters;
using VrMarketim.Business.Abstract;
using VrMarketim.Business.Concrete;
using VrMarketim.DataAccess.Abstract;
using VrMarketim.DataAccess.Concrete;
using VrMarketim.MailService;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSingleton<IAccountService, AccountManager>();
builder.Services.AddSingleton<IAccountRepository, AccountRepository>();
builder.Services.AddSingleton<IGeneralProductService, GeneralProductManager>();
builder.Services.AddSingleton<IGeneralProductRepository, GeneralProductRepository>();
builder.Services.AddSingleton<IBasketService, BasketManager>();
builder.Services.AddSingleton<IBasketRepository, BasketRepository>();
builder.Services.AddSingleton<IPurchaseRepository, PurchaseRepository>();
builder.Services.AddSingleton<IPurchaseService, PurchaseManager>();
var mailConfig = builder.Configuration.GetSection("MailConfiguration").Get<MailConfiguration>();
builder.Services.AddSingleton(mailConfig);
builder.Services.AddScoped<IMailSender, MailSender>();
builder.Services.AddMvc(options =>
{
    options.AllowEmptyInputInBodyModelBinding = true;
    foreach (var formatter in options.InputFormatters)
    {
        if (formatter.GetType() == typeof(SystemTextJsonInputFormatter))
            ((SystemTextJsonInputFormatter)formatter).SupportedMediaTypes.Add(
            Microsoft.Net.Http.Headers.MediaTypeHeaderValue.Parse("text/plain"));
    }
}).AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials());

app.UseAuthorization();

app.MapControllers();

app.Run();
