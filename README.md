# 🚀 CloudPOS Kiosk - Yemekpos MVP

Bu proje, geleneksel (Windows tabanlı) POS ve Kiosk sistemlerinin modern bulut mimarisine (Cloud) taşınma vizyonunu simüle eden bir **Minimum Geçerli Ürün (MVP)** çalışmasıdır. 

Sistem, dokunmatik ekranlara tam uyumlu modern bir ön yüz ve mikroservis mimarisine uygun olarak tasarlanmış sağlam bir arka plan API'sinden oluşmaktadır. En büyük özelliği ise, saha koşulları göz önüne alınarak geliştirilen **Çevrimdışı (Offline-First)** çalışma mantığıdır.

## 🏗️ Sistem Mimarisi ve Teknolojiler

Proje iki ana bileşenden oluşmaktadır:

### 1. Frontend (Müşteri Ekranı)
Geleneksel hantal ekranların yerini alan, hızlı ve modern web arayüzü.
* **Teknoloji:** Next.js (App Router), React, Tailwind CSS
* **Özellikler:** * Dokunmatik ekranlara (Tablet/Kiosk) özel büyük butonlu UX/UI tasarımı.
  * Kategori bazlı ürün listeleme ve dinamik sepet yönetimi.
  * ⚡ **Offline-First (Çevrimdışı Çalışma):** İnternet kesintisi durumunda sistem çökmez. Siparişler tarayıcının yerel hafızasına (`localStorage`) kaydedilir ve bağlantı sağlandığında arka planda buluta senkronize edilir.

### 2. Backend (Bulut Sipariş API'si)
Yerel veritabanı bağımlılığını ortadan kaldıran merkezi sipariş yönetim servisi.
* **Teknoloji:** C# .NET Core Web API
* **Özellikler:**
  * Clean Code ve Dependency Injection prensiplerine uygun mimari.
  * Kiosk'lardan gelen siparişleri asenkron olarak karşılayan RESTful `OrdersController`.
  * Merkezi loglama ve CORS yönetimi.

---

## ⚙️ Projeyi Yerelde Çalıştırma (Kurulum)

Projeyi kendi bilgisayarınızda test etmek için aşağıdaki adımları izleyebilirsiniz.

### Backend (C# API) Kurulumu
1. Terminalde `Yemekpos.Siparis.API` klasörüne gidin.
2. API'yi ayağa kaldırın:
   ```bash
   dotnet run

   Frontend (Next.js) Kurulumu
Yeni bir terminal açın ve kiosk-frontend klasörüne gidin.

Gerekli kütüphaneleri yükleyin:

Bash
npm install
Arayüzü başlatın:

Bash
npm run dev
(Tarayıcınızdan http://localhost:3000 adresine giderek Kiosk ekranını görüntüleyebilirsiniz.)

🎯 Gelecek Vizyonu (V2 Yol Haritası)
[ ] Yapay Zeka Destekli Çapraz Satış: Sepete eklenen ürünlere göre anlık olarak "Bunun yanına büyük boy patates ister misiniz?" tarzı akıllı AI öneri sistemi (Ai.API).

[ ] Background Sync: Çevrimdışı kaydedilen siparişlerin internet geldiği an Background Worker ile otomatik buluta itilmesi.

[ ] Real-time Bildirim: Sipariş mutfağa düştüğünde SignalR/WebSocket ile anlık durum güncellemeleri.