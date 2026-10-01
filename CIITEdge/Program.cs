//using CIITEdge.Hubs;

//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
//builder.Services.AddSignalR(); // <-- Add this line
//// Add services to the container.
//builder.Services.AddControllersWithViews();
//var app = builder.Build();
//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}
//app.UseHttpsRedirection();
//app.UseRouting();

//app.UseAuthorization();

//app.MapStaticAssets();



//app.MapControllerRoute(
//    name: "MyArea",
//    pattern: "{area:exists}/{controller:exists}/{action=Index}/{id?}");

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=csharp}/{action=introduction}/{id?}")
//    .WithStaticAssets();
//app.MapHub<CompilerHub>("/compilerHub");

//app.Run();





using CIITEdge.Hubs;
using CIITEdge.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ICodeRunnerService, CodeRunnerService>();
builder.Services
    .AddControllersWithViews()
    .AddRazorRuntimeCompilation();

builder.Services.AddSignalR();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();



app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller:exists}/{action=Index}/{id?}");



// https://localhost:7172/


//app.MapControllerRoute(
//    name: "csharp-home",
//    pattern: "",
//    defaults: new
//    {
//        area = "CSharp",
//        controller = "Introduction",
//        action = "Index"
//    });



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


 
app.MapHub<CompilerHub>("/compilerHub"); // <-- Add this line

app.Run();