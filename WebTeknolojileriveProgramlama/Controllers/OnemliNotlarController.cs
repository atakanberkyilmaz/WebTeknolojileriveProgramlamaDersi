//http port: 80 http error 404: clientte bulamadı   443 portu : HTTPS (SSL)
//localhost: div 

#region[Önemli Kısımlar]
//Home klasöründe da Privacy ve index var ve view döndürürler

//appsettings yerine webconfix.xaml vardı artık appsetings.json var
//buraya entegrasyon kodlarını(sql, facebook vb.) yazıyorsun

//.net server olarak kestrel kullanıyo

//getemptyresult(); sadece boş sayfa göndermek istersek kullanılıyo

//veri taşıma için viewdata -> key-value tarzında tutuyo
//viewbag-> dynamic tutuyo direkt model gönderilebilir

//IActionResult -> ActionResult, kullanıcı ile veri iletişimini sağladığı için kullanıcıya gönderilecek veri sayfası Controller ismiyle aynı olan klasörün içerisinde metot ismi ile aynı isimde sayfa olarak bulunmalıdır.
//wwwroot jquery, css ,js gibi yazılım dillerini tutar

// RenderBody: kullandığımız cshtml dosyasındaki yazıları h1.... kullanmamıza yarar

// Html Helper ve Tag Helperın değişimi

//DTO-> Data transfer object 

//builder.Services.AddSingleton -> 2 tane instance oluşsun 2 tane olmasın diye singleton kullanılır
//builder.Services.AddTransient-> 

//Ef Core -> hafif genişletilebilir ve open source olan veri erişim teknolojisi
//Avantajlar-> Veritabanı ile tip güveli bir şekilde çalışmamızı sağlar
//Veritabanı ile ilgili tüm süreci soyutlar
//Kodun Okunabilirliğini artırır
//Veritabanı ile ilgili tüm süreci soyutladığından dolayı biraz yavaştır
#endregion