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

//Controller : Model ve view aras�ndaki i�lemlerin kontrol edildi�i katmand�r Client'tan gelen requestler y�netilir.
//Action : Controllerin i�inde tan�mlan�r client'lardan gelen istekleri kar��lar.
//Model : model-view-controller aras�nda veri transferini sa�lar ayr�ca veri taban� ile ileti�im kurar uygulaman�n veri yap�s�n� temsil eder.
//view : view kullan�c�n g�rece�i i�eri�i sunar. Controllerden ald��� verileri dinamik �ekilde olu�turulan sayfalar� temsil eder. View kullan�c� aray�z�n�n nas�l g�r�nece�ini belirler.
//Razor : HTML ile c# kodlar�n� birle�tirir, dinamik HTML i�eri�i olu�turmak i�in kullan�l�r
//RazorView: Razor �ablonlar�yla dinamik HTML i�eri�i olu�turur.
//wwwroot : statik dosyalar� (css,jscript,resimler vb) depoland��� yerdir.
//builder.Build(): Uygulama yap�land�rmalar�n�n tamamlanmas�n�n ard�ndan uygulama nesnesinin olu�turulmas�n� sa�lar. Genellikle Program.cs dosyas�nda bulunur ve uygulaman�n yap�land�rma ad�mlar�n�n son a�amas�n� temsil eder.
//app.Run(): Uygulaman�n �al��t�r�lmas�n� ba�lat�r. builder.Build() sonras�nda �a�r�l�r ve web uygulamas�n�n gelen HTTP isteklerini dinlemeye ba�lamas�n� sa�lar.