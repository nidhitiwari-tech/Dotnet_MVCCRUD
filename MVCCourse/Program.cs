
using Microsoft.Extensions.Hosting;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;
using System.Xml.Linq;
using System;
using System.Net.Mime;
using System.Text;
using MVCCourse.Properties.Controllers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseRouting();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
