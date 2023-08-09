# setur-personel-girisli-otel-rezervasyon-uygulamasi



Bu uygulama, otel işletmelerinin personel kayıt işlemlerini yönetmelerine ve müşteri rezervasyonlarını takip etmelerine yardımcı olmak amacıyla geliştirilmiş bir uygulamadır. Uygulama, personel bilgilerini kaydetme, müşteri rezervasyonlarını alıp yönetme ve otel odalarının durumunu takip etme gibi temel işlevleri içermektedir.

## Özellikler

- Personel Kaydı: Otel personelinin temel bilgilerini (ad, soyad, pozisyon, iletişim bilgileri vb.) kaydetme ve düzenleme.
- Otel Odaları: Farklı tiplerdeki odaların durumunu ve doluluk durumunu izleme.
- Rezervasyon Yönetimi: Müşteri rezervasyonlarını alarak kaydetme, düzenleme ve iptal etme.
- Raporlama: Personel ve rezervasyonlarla ilgili raporlar oluşturma ve görüntüleme.
- Kullanıcı Yetkilendirmesi: Farklı kullanıcı rolleri (personel, yönetici) ile erişim kontrolü.

## Kullanılan Teknolojiler

- Python: Uygulama mantığını oluşturmak için.
- Flask (veya başka bir web çerçevesi): Kullanıcı arayüzünü oluşturmak ve sunmak için.
- SQLite veya PostgreSQL: Veritabanı yönetimi için.
- HTML, CSS ve JavaScript: Kullanıcı arayüzünün tasarımı ve etkileşimi için.

## Kurulum

1. Bu depoyu klonlayın: `git clone https://github.com/SoftwareFatih/setur-personel-girisli-otel-rezervasyon-uygulamasi.git`
2. Proje dizinine gidin: `cd PersonelOtelUygulamasi`
3. Gerekli bağımlılıkları yüklemek için: `pip install -r requirements.txt`
4. Veritabanını oluşturmak için: `python manage.py db migrate` ve `python manage.py db upgrade`
5. Uygulamayı başlatmak için: `python run.py`
6. Tarayıcıda uygulamayı görüntülemek için: `http://localhost:5000`

## Kullanım

1. Uygulamayı başlattıktan sonra, tarayıcınızda `http://localhost:5000` adresini açın.
2. Personel kayıtları ve otel odalarının durumu gibi temel bilgileri görüntüleyebilirsiniz.
3. Yönetici olarak giriş yaparak personel kayıtları ve rezervasyonları yönetebilirsiniz.
4. Müşteri olarak rezervasyon yapabilir ve mevcut rezervasyonları görüntüleyebilirsiniz.

## Katkı

Katılımınızı memnuniyetle karşılıyoruz! Lütfen eklemek istediğiniz adımları belirtin.Memnuniyetle katkınızı ekleyeceğim.
---

Geliştirici: Fatih Gödel
Proje Linki: https://github.com/SoftwareFatih/setur-personel-girisli-otel-rezervasyon-uygulamasi
