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

// ReaderBody: kullandığımız cshtml dosyasındaki yazıları h1.... kullanmamıza yarar
#endregion