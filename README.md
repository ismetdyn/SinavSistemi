# SinavSistemi

Hazırladığımız Sınav Sistemi Otomasyonu Öğrenci ve Öğretmenler için bir Sınav Sistemini simüle etmeye yöneliktir.

Sınav Sistemi Otomasyonumuz SQL SERVER MANAGEMENT STUDİO kullanılarak geliştirilmiş olup gerçek zamanlı Soru ekleme ve Sınav Yapma işlemlerini Yapabilmektedir.

Sınav Otomasyonu Projemizi Geliştirken Görsellik açısından daha zengin bir proje yaratmak için DevExpress Componentleri Kullanılmıştır.

Dilerseniz Ekran Görüntüleri üzerinden anlatıma başlayalım.

(![1](https://user-images.githubusercontent.com/58293202/169197157-30382b2e-9123-4f6d-ada1-b4e22403700c.png)
)

Projemizi İlk Çalıştırdığımızda Yukaarıdaki gibi bir Login Formu geliyor karşımıza. 
Kullanıcı burdan daha önceden sisteme kayıt olduğu bilgilerle giriş yapabiliyor.

![2](https://user-images.githubusercontent.com/58293202/169197907-946afb05-4fba-4385-9c9f-1ad3cdfbbdf3.png)

Login ekranımızda görüldüğü gibi Koyu tema-Açık tema desteği de bulunmaktadır.

Daha sonrasında da Eğer kullanıcı Kayıt yapmamışsa Şöyle bir ekran onu karşılayacak.


![10](https://user-images.githubusercontent.com/58293202/169198637-290629ba-7b66-4378-9763-473946cb2ddd.png)

Görüldüğü gibi Kullanıcıdan bazı bilgiler isteniyor. Kullanıcı bu bilgileri girerek Email'ini de yazarak sisteme kayıt yapabiliyor.
Otomasyonumuz kullanıcının girdiği bilgilerde Verification ve Validation işlemleri yapıyor.
O yüzden veritabanında aynı isimli , aynı E-posta'lı birisi varsa ekrana Bir bilgi gönderecek ve Kullanıcı tekrardan bilgileri yazması beklenecek.

![11](https://user-images.githubusercontent.com/58293202/169199082-f733cdf1-8a59-427e-a75a-35704d2748ef.png)

Şifremi Unuttum ekranı için de şöyle bir ekran bizi karşılıyor. Baktığımızda öncelikle kullanıcıdan bir email isteiyor.

![12](https://user-images.githubusercontent.com/58293202/169199170-50946d4a-e808-4ff6-b181-bf3d3e6c2bea.png)

Kullanıcı sisteme kayıt olurken ki kullanığı E-mail'i ekrana yazdığında Kullanıcı E-poste'sına Yukarıda gösterildiği gibi 3 haneli bir kod geliyor.
Kullanıcıdan bu kodu ilgili alana yazmasını bekliyoruz.

![13](https://user-images.githubusercontent.com/58293202/169199348-a682166c-62ff-40d8-b6b0-6db84b791898.png)

Daha sonrasında ise şifrenin güncellenebileceği ekran karşımıza geliyor.

Eğer öğrenci olarak giriş yaparsak Login formundan  : 
![5](https://user-images.githubusercontent.com/58293202/169199528-fda3e84f-1387-4486-82e6-1b0152f097f2.png)
Şöyle bir ekran bizi karşılıyor .

Anasayfa Ekranının hemen sağ altında **Sınava Gir** Butonumuz bulunuyor.
Öğrenci bu butona bastığında Sınava katılabiliyor.

![7](https://user-images.githubusercontent.com/58293202/169202267-45f5fea6-6302-483d-b7cd-ab4dda49d2bf.png)

Öğrenci sisteme giriş yapar yapmaz Sorular ekrana gelmeye başlıyor. Görüldüğü gibi öğrenci Her soru için bir şık seçip , bir önceki veya bir sonraki soruya geçiş yapabiliyor.
Öğrenci soruları cevaplandırabilir isterse Boşta bırakabilir.

![8](https://user-images.githubusercontent.com/58293202/169202450-43f38d56-199d-42c3-97a7-18ae8fa3ab2b.png)
Öğrenci Sonraki butonuna bastığında yeni bir soru ekrana geliyor ve Öğrenci görülüdüğü gibi şöle bir şekilde cevabı seçebiliyor.

Dikkat edilmesi Gereken bir husus var ki **zaman kavramı**. Kullanıcının zamana karşı sınavını tamamlaması gerekiyor.


Kullanıcı ekranını tasarlarken User Control'lerden faydalanıp UI tasarımını gerçekleştirdik.
Kullanıcıyı Direkt ANASAYFA ile karşılıyoruz. 

![Ekran görüntüsü 2022-05-19 064409](https://user-images.githubusercontent.com/58293202/169200251-d2b0a2a1-b557-44f5-861b-8d64694c5301.png)
Kullanıcının Sınav Sonuçlarını ekrana basıyoruz.

![22](https://user-images.githubusercontent.com/58293202/169200359-51b0cfc6-78fc-4283-bbd7-95eab502945e.png)
Kullanıcı hesabına ait bilgileri görüp Bunları istediği zaman güncelleyebilir ve Eğer isterse Kendi Resmini sisteme ekleyebilir.

![23](https://user-images.githubusercontent.com/58293202/169200498-f732611f-1cd4-4efc-a6ce-2a8eb0cc86c0.png)
Raporlama bölümünde kullanıcı kendisi için oluşturulan Analiz raporunu çıkartabilecek.

![24](https://user-images.githubusercontent.com/58293202/169200592-6e2849a6-9280-4b86-8060-eaad0e1d69a0.png)

Kullanıcıya Gösterilecek Sınav modülünde kullanıcının bildiği soruların hangi sıklıkla kendisine sınavlarda gösterileceğini Ayarlayabiliyor.

![25](https://user-images.githubusercontent.com/58293202/169200747-9100a2f7-090a-400a-89d0-a920632fe9c7.png)

Sistemden çıkış yapmak için çıkış butonuna basıldığında ekrana gösterilen bilgi ekranında evet'e bastığında sistemden kullanıcının çıkış yapması sağlanıyor.


![4](https://user-images.githubusercontent.com/58293202/169201007-011ffc88-73da-4d18-b82f-307add17aadb.png)

Sınav otomasyonuna eğer Öğretmen olarak giriş yapılırsa gösterilecek ekran yukarıdaki gibidir.

Öğretmenimiz burdan öğrenciler için  soru metni , soru şıkları ve doğru cevabı girerek Sorular hazırlayabiliyor. 
Öğretmenimiz gerekli alanları doldurduktan sonra **Soruyu Gönder** butonuna bastığında sorumuz **Binary dizisine Serilize edilerek** veritabanına kaydediliyor.

![3](https://user-images.githubusercontent.com/58293202/169201628-fe82dca2-e57f-4da8-9c25-8990ae3d4c38.png)

Bu da Soru ekleme ekranımızın Koyu tema Hali.



