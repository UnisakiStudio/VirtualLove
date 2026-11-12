# Virtual Love

3 noktalı takipte veya masaüstünde, partnerinizle eşleşen pozların keyfini çıkarmanızı sağlayan bir VRChat avatar aracıdır. Erkek ve kadın tarafı için 22’şer, toplam 44 poz içerir. Ayakta spagat ve Jack-O meydan okuması da yapılabilir.

Bu README, geliştirilmekte olan v3.2.0 içindir. Resmî yayın tarihi henüz belirlenmemiştir. Kurulu sürümü Inspector’ın üstünde görebilirsiniz.

- [BOOTH ürün sayfası](https://yunisaki.booth.pm/items/3641334)
- [Değişiklik geçmişi](CHANGELOG.md)

## Görüntüleme dili ve çevrimdışı belgeler

Inspector’ın üstündeki “Language / 言語” alanından dili seçin. Tek seçim hem Inspector’ı hem oluşturulan VRChat menüsünü etkiler. Oyundaki dili değiştirmek için avatarı yeniden yükleyin.

Dil seçilmemişse bilgisayarın dili, desteklenmeyen dillerde İngilizce kullanılır. Windows, macOS ve Linux desteklenir. Son seçim EditorPrefs’e kaydedilir ve bu bilgisayardaki aynı işletim sistemi kullanıcısının diğer projelerinde de kullanılır. Tüm poz araçları ve avatarlar aynı dili kullanır. Herhangi bir aracın Inspector’ında dili değiştirmek ortak tercihi günceller; avatara özel dil seçimleri dikkate alınmaz. Başka bilgisayarlara eşitlenmez. Lisans saklama yöntemi değişmez. Dil düğmesi, kayıtlı bir dil yoksa yalnızca ilk kurulum onayında görünür. Daha sonraki dil değişiklikleri Inspector’dan yapılır.

README ve değişiklik geçmişi, paketteki [dil listesinden](../index.html) seçilebilir. Inspector’daki “Kılavuz” ve “Değişiklikleri göster” de seçilen dili izler. Pakete dâhil pozların adları ve oyun içi menüdeki kategori adları da seçilen dilde gösterilir. Kullanım koşulları eskisi gibi Japonca olarak pakete dâhildir.

## Kurulum

1. Satın aldığınız dosyalardaki “VirtualLove_Boy.unitypackage” veya “VirtualLove_Girl.unitypackage” dosyasını Unity’ye aktarın. İngilizce sürümde dosyaların adları “VirtualLove_Male_Installer.unitypackage” ve “VirtualLove_Female_Installer.unitypackage” şeklindedir.
2. Paket kaynağını kaydettikten sonra Virtual Love’ı VCC veya ALCOM üzerinden kullanacağınız projeye ekleyebilirsiniz. Unisaki Posing System 3.2.0 gerekir.
3. Hierarchy’de aracı eklemek istediğiniz avatara sağ tıklayıp “Unisaki Studio > Virtual Love (Erkek) ekle” veya “Unisaki Studio > Virtual Love (Kadın) ekle”yi seçin.
4. Avatarın içine eklenen “三点だいしゅき(男)” veya “三点だいしゅき(女)” nesnesini seçip Inspector’da kullanılacak özellikleri ve pozları ayarlayın.
5. Pozları önizlemeyle kontrol edin ve avatarı her zamanki gibi yükleyin.

Unity 2022.3, VRChat Avatars SDK 3.10.4 veya sonrası, Modular Avatar 1.x serisi 1.15.1 veya sonrası ve NDMF 1.x serisi 1.14.0 veya sonrası gerekir. Gerekli paketleri VCC veya ALCOM ile birlikte güncelleyin.

## Önceki sürümden güncelleme

Ürünü ve Unisaki Posing System’i birlikte güncelleyin. Yerleştirilmiş araçların ayarları korunur. Inspector’da kullanılan özellikleri ve ExpressionParameters maliyetini kontrol edin. Ön oluşturma kullandıysanız yeniden yüklemeden önce Ön oluşturmayı güncelle’ye basın.

## Ayarların konumu

| Sekme | Başlıca ayarlar |
| --- | --- |
| Özellikler | Oyun içi menü eklemeleri, fotoğraf modu, nefes, simge görselleri ve parametre kullanımının kontrolü |
| Pozlar | Kullanılacak pozlar, arama, ekleme, sıralama, önizleme ve animasyon düzeltmesi |
| Avatar Kurulumu | Vücut düzeltmesi, özgün pozların ve kendi hareketlerinizin içe aktarılması, ön ayarlar |

Yüklemeden önce gereken özellikleri açın. “Ayarları aç” bulunan öğelerde ayrıntılı ayarlar hemen altında gösterilebilir.

## Oyundaki temel kullanım

Expressions menüsünü açıp bir Virtual Love pozu seçin. Erkek ve kadın tarafında birbirini tamamlayan pozları seçin, ardından partnerinizle konumunuzu ve yönünüzü hizalayın.

Baş, kol ve ayak kilitlerini açıp kapatarak takibi izlemesini istediğiniz bölümleri ayarlayabilirsiniz. “Ayakları kilitle” ile ayak tarafının pozu korunurken başınızı hareket ettirebilirsiniz. Pozu aynalamak veya yüksekliğini ayarlamak istiyorsanız ilgili özellikleri önceden Unity’de etkinleştirin.

### Fotoğraf modu

Avatarınızı görebileceğiniz bir konuma taşıyıp yönünü ayarlayarak fotoğraf çekebilirsiniz.

1. Unity’de “Özellikler > Menü özellikleri > Fotoğraf modu”nu açın.
2. VRChat’te “Fotoğraf modu”nu açıp “Poz seç” üzerinden kullanmak istediğiniz pozu seçin.
3. “Mesafe” ile avatarı en fazla 3m öne taşıyın. Mesafe 0’dan büyükse avatar size bakar.
4. “Yön” ile döndürün; konum belirlenince gerekirse “Ayakları kilitle”yi açın. Başlangıçta ayaklar otomatik kilitlenmediği için kilitlemeden önce konumu ayarlayabilirsiniz.
5. Çekim bitince “Fotoğraftan çık”a basın. Mesafe ve yön sıfırlanır, ayak kilidi kalkar.

“Jestleri kapat”ı menüye eklediyseniz fotoğraf modunda da el şeklini değiştirebilirsiniz.

Konumu ve yönü yalnızca kendi ekranınızda değiştiriyorsanız fotoğraf modu eşitlenen parametre kullanmaz. Aynı konumu ve yönü başkalarına da göstermek için Unity’de “Özellikler > Kolaylıklar > Fotoğraf modunu eşitle”yi açın.

Kendi başınız yaklaştığında gizlenip çekimi zorlaştırıyorsa “Fotoğraf modunda başı görünür tut”u açın. Çekim sırasında yalnızca kendi ekranınıza uygulanır; çıktıktan sonra normal görünüme dönülür.

### Ayak yüksekliği ve Zemin yüksekliği

Unity’de “Özellikler > Menü özellikleri” altında kullanmak istediğiniz öğeleri açtığınızda bunlar VRChat’teki “Ayarlar” menüsüne eklenir.

- **Ayak yüksekliği**: Başın konumunu koruyarak ayak tarafının yüksekliğini ayarlar. Ayaklar zemine gömüldüğünde veya havada kaldığında ya da partnerinizle yüksekliği eşitlemek istediğinizde kullanın.
- **Zemin yüksekliği**: Baş dâhil tüm vücudu yukarı ve aşağı taşır. 50% özgün yükseklik, 0% 3m aşağısı, 100% 3m yukarısıdır. Eski hâline döndürmek için 50% dolayına getirin.

Fotoğraf moduyla birlikte kullanarak avatarın yüksekliğini, mesafesini ve yönünü ayarlayabilirsiniz. Fotoğraf modunun taşıma ve döndürmesi ile zemin yüksekliği, poz seçilmemişken kullanılan varsayılan ve özel hareketleri de düzeltir. VRChat’teki bakış noktasını ve varsayılan hareketler değiştirildikten sonraki davranışı uygulamada kontrol edin.

### Aynala ve Jestleri kapat

- **Aynala**: “Özellikler > Menü özellikleri > Aynala”yı açın ve VRChat menüsünden pozun sağını ve solunu değiştirin.
- **Jestleri kapat**: “Özellikler > Menü özellikleri > Jestleri kapat”ı açın. VRChat’te etkinleştirdiğinizde, kontrolcüleri sıktığınızda bile pozda ayarlı parmak şekli korunur.

### Nefes

1. “Özellikler > Kolaylıklar > Nefes animasyonu ekle”yi açın.
2. “Ayarları aç” üzerinden her poz kategorisi için “Yok”, “Hafif”, “Orta”, “Güçlü”, “Hızlı” veya “Özel” seçin. Gücü, Virtual Love pozlarına karşılık gelen kategoride ayarlayın. “Özel” ile kendi hazırladığınız nefes animasyonunu atayabilirsiniz.
3. Nefesi oyun içinde de durdurup yeniden başlatmak istiyorsanız “Özellikler > Menü özellikleri > Nefes”i de açın. VRChat’te “Nefes” ile ON/OFF arasında geçiş yapılır.

“VRChat bekleme sallanmasını kapat”ı açtığınızda, beklerken kendiliğinden eklenen varsayılan vücut sallanması bastırılır. Poz aracında ayarladığınız nefes olduğu gibi kullanılmaya devam eder.

### Baş yönünden kaynaklanan poz bozulmasını azaltma

“Özellikler > Kolaylıklar > Baş dönüşünden kaynaklanan poz bozulmasını azalt”ı açın. Baş kilidini kaldırdığınızda baş yönü özgün pozdan farklı olduğu için vücut pozu bozuluyorsa kullanın.

### Dön

Dön, buna uygun bir yatış pozu ve yan yatış animasyonları hazırlanarak kullanılan bir özelliktir.

1. “Özellikler > Menü özellikleri > Dön”ü açın.
2. “Pozlar”da kullanmak istediğiniz pozun “Ayrıntılar” bölümünü açıp “Dönüşü etkinleştir”i açın.
3. “Yan dönüş pozu”na ilgili animasyonları atayın ve gerekirse “Zemin düzeltme gücü”nü ayarlayın.
4. VRChat’te ilgili pozu seçin, baş kilidini kaldırın ve “Dön”ü açın. Başınızı sağa veya sola eğdiğinizde dönersiniz.

Dönüş kullanılan pozlarda normal MotionTime ayarı kullanılamaz. Virtual Love’daki pozlarla birlikte dönüş için yan yatış animasyonu gelmez; kullanmak isterseniz uygun hareketleri kendiniz hazırlayın.

## Parametre kullanımı

Gereksiz özellikleri kapatarak ExpressionParameters kullanımını azaltabilirsiniz.

| Özellik | Ek kullanım |
| --- | --- |
| Aynala | 1 bit |
| Jestleri kapat | 1 bit |
| Ayak yüksekliği | 8 bit |
| Zemin yüksekliği | 8 bit |
| Nefes hareketi | 0 bit |
| Nefesin oyun içi ON/OFF anahtarı | 1 bit |
| Fotoğraf modu (yalnızca kendi ekranınız) | 0 bit |
| Fotoğraf modu eşitlemesi | 16 bit |
| Çekim sırasında başın görünmesi | 0 bit |
| Baş yönünden kaynaklanan poz bozulmasını azaltma | 1 bit (Dön ile ortak) |
| Dön | 10 bit (1 bit’i poz bozulmasını azaltmayla ortak) |

Bunlara poz seçimi gibi kullanımlar eklenir. Toplamı Inspector’da kontrol edin. Birden fazla poz aracı ortak özellikleri kullanıyorsa ortak kısım tekrar sayılmaz. Kıyafetler gibi diğer sistemlerin kullanımı bu toplama dâhil değildir.

## Pozları kontrol etme ve ayarlama

“Pozlar”daki her pozun “Önizleme” düğmesi pozu Scene’de gösterir. “Animasyon Düzeltmesi”ni açarsanız önizleme sırasında vücut yönünü ve eklemleri ayarlayıp kaydedebilirsiniz.

Pakete dâhil pozlar, こよりLab’ın “あのん（Anon）” avatarı temel alınarak hazırlanmıştır. Partnerinizle temas noktaları gibi ayrıntıları vücut yapısına ve kıyafete göre ayarlayın.

“Avatar Kurulumu”ndaki “Avatar düzeltmesini etkinleştir”, referans avatara göre başlangıç eklem açılarındaki ve burulmadaki farkları düzeltir. “Dizin ters bükülmesini önle” ise dizlerin ters yöne bükülmesini engeller. Ayrıntılı ayarları açarak “En küçük diz bükülmesi (derece)” değerini ayarlayabilirsiniz. Düzeltme etkinken görünümü de önizlemeyle kontrol edin.

Poz adlarını arama, birden fazla animasyon ekleme ve sırayı değiştirme de “Pozlar”da yapılır. Gereksiz pozları devre dışı bırakın veya silin.

Hafif önizleme MA ve NDMF derleme işlemini çalıştırmaz; bu yüzden kıyafetler ve diğer sistemler dâhil son durumu avatar derlendikten sonra da kontrol edin.

### Poz simge görselleri

“Özellikler”deki “Poz simgeleri oluştur”u açtığınızda oyun içi menüye poz görselleri eklenir. Görsellerin oluşturulması kadar derleme süresi uzar. Boyutu azaltmak için “Simge boyutunu küçült”ü açın. Android için poz simgesi oluşturulmaz.

### Ön ayarlar

“Avatar Kurulumu”nun en altından bir ön ayar seçebilirsiniz. “Bu ön ayarı uygula” geçerli poz ayarlarının yerini alır; bu yüzden geçmeden önce yaptığınız düzeltmeleri kaydedin.

Animasyon düzeltmesi özelliğiyle oluşturduğunuz düzeltme animasyonu dosyaları ve bunların atandığı ön ayarlar, Unisaki Studio’dan ayrıca izin alınmadan dağıtılabilir ve satılabilir. Örneğin kendi yaptığınız avatarlara yönelik düzeltme verilerini paylaşmak için kullanabilirsiniz.

## Ön oluşturma

“Ön oluşturmayı güncelle” ile menü ve animasyonların oluşturma sonuçlarını kaydederseniz avatar derlenirken bunlar yeniden kullanılır ve işlem hızlanır. Ön oluşturma olmasa da gereken veriler normal derleme sırasında oluşturulur.

Pozları veya özellikleri değiştirdikten sonra Inspector’daki “Ayarları kontrol et” bölümüne bakın ve ön oluşturma kullanıyorsanız güncelleyin. Uyarıyı gizlemek oluşturma sonucunu güncellemez.

## Hediye etme hakkında

Kendiniz kullanmıyorsanız erkek veya kadın sürümünden birini partnerinize hediye edebilirsiniz. Hediyeyi alan kişi aracı yalnızca hediye eden kişiyle birlikte kullanabilir.

## Kullanım notları

- Bu ürün şaka amacıyla hazırlanmıştır. Lütfen taciz amacıyla kullanmayın.
- VRChat kullanım koşullarına ve görgü kurallarına uyarak kullanın.
- Tam vücut takibi sırasında poz kilitleme desteklenmez.
- Avatarın vücut yapısına, kıyafetine ve üzerinde yapılan değişikliklere bağlı olarak elle ayar gerekebilir.
- Poz değiştiren başka sistemlerle birlikte kullanıyorsanız kilitlerin ve poz geçişlerinin nasıl çalıştığını kontrol edin. Bazı durumlarda “Avatar Kurulumu > Takip kilitlerini diğer araçlarla bütünleştir” ile ayarlanabilir.
- Bu aracın kullanımından doğan zararlardan yapımcı sorumlu değildir.

## Kullanım koşulları

Bu ürünü, VN3 lisansıyla hazırlanmış kullanım koşullarını kabul ederek kullanın.

[Virtual Love kullanım koşulları](https://drive.google.com/file/d/1Uu8y4z-G-P0btDCdY-ahQsTJInCNbxyD/view?usp=sharing)
