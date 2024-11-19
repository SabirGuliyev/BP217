var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

var app = builder.Build();


//app.MapControllerRoute(
//    "Corporative",
//    "korporativ-satislar",
//    new { controller = "home", action = "corporativesales" }

//    );
app.MapControllerRoute(
    "default",
    "{controller=home}/{action=index}/{id?}"
    
    );

app.Run();
