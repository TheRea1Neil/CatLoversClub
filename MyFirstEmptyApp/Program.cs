var builder = WebApplication.CreateBuilder(args);
//set up services
builder.Services.AddControllersWithViews();

var app = builder.Build();
//inlude the files in the wwwroot folder
//app.UseDefaultFiles();

//if the user types in http then redirect them to https
app.UseHttpsRedirection();

app.UseStaticFiles();
//makes the routing system intuitive and automatic so you don't have to list out every possible route. .Net can figure out where you are starting from and where you want to go
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
