using CoreMvcCodeFirst_1.Models.ContextClasses;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//Asagıdaki kodda veritabanı baglantı sisteminizi ayarlıyorsunuz

builder.Services.AddDbContext<MyContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection"))); //BUradaki ifademiz projemizin servislerine veritabanı sınıfımızı (MyContext'i) SqlServer teknolojisi kullanıp verdigimiz adresi hedef alarak bir ayarlama ekliyor...

//BU yukarıdaki kod ifadesini middleware'e yazdıktan sonra Migration kodlarımızı yazabiliriz...

//Terminale yazacagımız kodlar :
//add-migration Mig1






var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
