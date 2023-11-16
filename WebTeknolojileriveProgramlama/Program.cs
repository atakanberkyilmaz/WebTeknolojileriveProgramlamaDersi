using WebTeknolojileriveProgramlama.IOCIcin;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllersWithViews();

//builder.Services.AddScoped
//builder.Services.AddTransient
//builder.Services.AddSingleton -> 2 tane instance olu�sun 2 tane olmas�n diye singleton kullan�l�r

builder.Services.AddSingleton<IDeneme, Deneme>(); //Birisi senden IDeneme isterse deneme s�n�f�n� ver demek

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
