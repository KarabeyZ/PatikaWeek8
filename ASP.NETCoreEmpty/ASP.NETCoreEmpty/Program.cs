var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

//Controller : Model ve view arasýndaki iþlemlerin kontrol edildiði katmandýr Client'tan gelen requestler yönetilir.
//Action : Controllerin içinde tanýmlanýr client'lardan gelen istekleri karþýlar.
//Model : model-view-controller arasýnda veri transferini saðlar ayrýca veri tabaný ile iletiþim kurar uygulamanýn veri yapýsýný temsil eder.
//view : view kullanýcýn göreceði içeriði sunar. Controllerden aldýðý verileri dinamik þekilde oluþturulan sayfalarý temsil eder. View kullanýcý arayüzünün nasýl görüneceðini belirler.
//Razor : HTML ile c# kodlarýný birleþtirir, dinamik HTML içeriði oluþturmak için kullanýlýr
//RazorView: Razor þablonlarýyla dinamik HTML içeriði oluþturur.
//wwwroot : statik dosyalarý (css,jscript,resimler vb) depolandýðý yerdir.
//builder.Build(): Uygulama yapýlandýrmalarýnýn tamamlanmasýnýn ardýndan uygulama nesnesinin oluþturulmasýný saðlar. Genellikle Program.cs dosyasýnda bulunur ve uygulamanýn yapýlandýrma adýmlarýnýn son aþamasýný temsil eder.
//app.Run(): Uygulamanýn çalýþtýrýlmasýný baþlatýr. builder.Build() sonrasýnda çaðrýlýr ve web uygulamasýnýn gelen HTTP isteklerini dinlemeye baþlamasýný saðlar.