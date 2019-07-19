# JwtTokenApi
.Net Core 2.1 Web Api Sample with Jwt Token

.Net Core Web Api ve JWT(Json Web Token) kullanımını gösteren basit bir örnek.

Uygulamanın mantığı, üyelerin postlara ulaşması. Facebook, Instagram gibi uygulamalarda olduğu gibi üyeler web servisine
istekte bulunup postları çekmek istiyor.(Bu uygulamada post bulunmamaktadır, sadece jwt ile web servislerine istek gönderme ve 
bu isteğe cevap alma bulunmaktadır.)

2 adet controller var. Biri AuthController diğeri PostController.
AuthController: Token yaratmayı sağlar. Admin veya User olmak üzere 2 farklı rolde token yaratır.
PostController: AuthController'da yaratılan token ile istekte bulunursak postları döndürür.

Rolü user olan token yaratma işlemi

![getusertoken](https://user-images.githubusercontent.com/46047252/61532861-e1ceef00-aa33-11e9-9ec6-9eb88b989b41.png)

Eğer token kullanmadan istek yollarsak 401 Unauthorized hatası alırız

![getposts401](https://user-images.githubusercontent.com/46047252/61533163-ae409480-aa34-11e9-8d8e-d0bddf433059.png)

401 Unauthorized hatası almamak için servise istekte bulunurken Token'ınımızı yazıyoruz

![getpoststoken](https://user-images.githubusercontent.com/46047252/61533219-df20c980-aa34-11e9-94da-4093d98a701d.png)

Sadece rolü user olanların cevap alabileceği servise istek yolluyoruz

![getpostsuser](https://user-images.githubusercontent.com/46047252/61533027-56099280-aa34-11e9-91f1-ce2cba11928f.png)

Hem user hem de adminin görebileceği servise istek yolluyoruz

![getposts](https://user-images.githubusercontent.com/46047252/61533060-6c175300-aa34-11e9-9636-440c979fb9cf.png)

Sadece adminlerin cevap alabileceği servise user rolüyle istekte bulunursak alacağımız cevap 403 Forbidden olur

![getposts403](https://user-images.githubusercontent.com/46047252/61533254-feb7f200-aa34-11e9-9750-e5f30bb00417.png)







