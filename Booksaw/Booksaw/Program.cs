using Booksaw.Data;
using Booksaw.Services;
using Booksaw.Services.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<IQuotationService, QuotationService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ISettingService, SettingService>();
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
