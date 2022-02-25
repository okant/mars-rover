# Mars Rover Case

### Kullanılan Teknoloji

    . Net 6.0

### Çözüm Yaklaşımı

    . State Design Pattern

Bu projede Davranışsal Tasarım Kalıplarından biri olan State Design Pattern kullanılmıştır.
Bu tasarım kalıbının kullanılmasındaki amaç ise Rover nesnesinin
özellikle yön durumundaki değişiklikleri yakalayıp ona göre davranışlar
sergilemesidir.

Kullanıcıdan ilk önce keşfedilecek bölgenin koordinatları alınır.
Daha sonrasında yine kullanıcıdan bu bölge içerisinde olacak şekilde X ve Y koordinatı ile
yön bilgisi alınır ve Rover sınıfından türeyen nesne bu bölge içerisine konumlandırılır.

Son olarak da kullanıcıdan Rover nesnesini yönlendirmesi için yön komutları 
girmesi beklenir. 

Bu aşamadan sonra kurulan yapı sayesinde Rover nesnesi
hangi yöne döneceğini ya da ileri doğru hareket edip etmeyeceğini
kullanıcının talimatlarına göre yerine getirecektir. Bu görevleri
yerine getirirken de 

* NorthDirection
* EastDirection
* WestDirection
* SouthDirection

sınıflarının bilgilerine gerek duymadan sadece IRoverDirectives arayüzünde yer alan 
direktifleri kullanarak yönlendirecektir.

### Hata Durumları

Hatalı kullanıcı girdilerinde, sistem hata fırlatacak şekilde aksiyon almaktadır.

Örneğin,

* Kullanıcıdan keşif yapılacak alanın bilgisini girmesi beklenmektedir.
Girmediği taktirde hata fırlatılacaktır.
* Keşif yapılacak alanın X ve Y düzlemlerinde başlangıç noktası 0'dan küçük olması
durumunda hata fırlatılacaktır.
* Yine keşif yapılacak alan için numeric olmayan değer girildiğinde hata fırlatılacaktır.
* Rover nesnesi konumlandırılırken, keşif yapılacak alanın içerinde 
bir noktaya konumlandırılması gerekecektir. Aksi halde hata fırlatılacaktır.
* Rover nesnesi konumlandırılırken 4 yönü belirten konum direktifleri
kullanılması beklenmektedir. Bu konumlar haricinde bir bilgi girilmesi dahilinde 
sistem hata fırlatacaktır.
    
    . N -> North

    . E -> East

    . W -> West

    . S -> South

### Diğer Notlar

Bu projede Magic Number kullanmamaya özen gösterilmiştir.
Kullanımı gereken alanlar için de const tanımlar yapılmış ve
bu sayede kodda 0, 1 gibi rakamlar yerine bu const tanımlamalar yer almıştır.

Clean code yaklaşımına uygun olarak hiçbir method 25 satırı aşmamış,
hiçbir sınıf başka bir sınıfa bağımlı bırakılmamış, method isimleri
sade yazılmış ve içerikleri de isme uygun davranacak şekilde oluşturulmuştur. 







