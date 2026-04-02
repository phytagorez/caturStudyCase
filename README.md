# ♟️ Simulasi Aturan Catur - Kelompok 8

Halo! Selamat datang di repositori proyek Kelompok 8. 

Program sederhana ini dibuat menggunakan bahasa C# untuk menyimulasikan bagaimana bidak-bidak catur bergerak dan menyerang. Namun, tujuan utama dari kode ini bukan untuk membuat *game* catur sungguhan, melainkan untuk mendemonstrasikan sebuah "jurus rahasia" dalam dunia pemrograman komputer yang disebut **Polimorfisme (Polymorphism)**.

Tenang saja, Anda tidak perlu latar belakang IT untuk memahaminya. Mari kita bedah bersama-sama!

---

## ❓ Apa Itu Polimorfisme?

Secara bahasa, *Polimorfisme* berarti "banyak bentuk". 

Bayangkan Anda adalah seorang jenderal pasukan (pemain catur). Anda memiliki banyak prajurit: Kuda, Benteng, Pion, dan Menteri. Sebagai jenderal, Anda cukup memberi satu perintah sederhana: **"Pasukan, Bergerak!"**

Anda tidak perlu mengajari mereka *cara* bergerak satu per satu setiap kali memberi perintah. 
* Ketika mendengar perintah "Bergerak", sang **Kuda** otomatis melompat membentuk huruf 'L'.
* Ketika mendengar perintah "Bergerak", sang **Benteng** otomatis melaju lurus.
* Ketika mendengar perintah "Bergerak", sang **Pion** otomatis maju 1 atau 2 langkah.

Satu perintah yang sama ("Bergerak"), tetapi menghasilkan tindakan (bentuk) yang berbeda-beda tergantung siapa yang mendengarnya. **Inilah yang disebut Polimorfisme.**



[Image of polymorphism in object oriented programming diagram]


---

## ⚙️ Bagaimana Program Ini Bekerja?

Di dalam kode program ini, kita menerapkan logika sang jenderal di atas ke dalam komputer. Berikut adalah 3 tahapan utamanya:

### 1. Membuat Kategori Umum (Sang Induk)
Pertama, kita membuat sebuah kategori payung bernama **`BidakCatur`**. Kita memberi tahu komputer, *"Semua bidak catur itu pada dasarnya bisa Bergerak dan Makan lawan."* Ini adalah aturan dasarnya. Di dalam pemrograman, kita membebaskan aturan ini agar nanti bisa diubah oleh masing-masing jenis bidak.

### 2. Membuat Spesialis (Anak Buah)
Selanjutnya, kita membuat jenis-jenis bidak spesifik: **`Pion`**, **`Benteng`**, **`Kuda`**, **`Gajah`**, **`Menteri`**, dan **`Raja`**.
Mereka semua mengakui bahwa mereka adalah bagian dari `BidakCatur`, tetapi mereka "mengganti" (dalam kode disebut *override*) aturan gerak standar dengan gaya mereka sendiri.
* Contoh: Kuda membuat aturan ketat bahwa ia hanya boleh bergerak sejauh 3 petak. Jika tidak 3 petak, ia akan menolak bergerak (muncul pesan: Langkah Tidak Valid).

### 3. Keajaiban Polimorfisme Terjadi!
Di bagian akhir program (menu utama), kita melihat keajaiban ini bekerja:

Kita meminta komputer menyiapkan bidak umum (seolah-olah kita memegang bidak dengan mata tertutup):
> *"Tolong siapkan satu **Bidak Catur**, wujud aslinya adalah seekor **Kuda**."*

Lalu kita memberi perintah:
> *"Bidak, Bergeraklah 3 petak!"*

Komputer tidak kebingungan. Meskipun label luarnya cuma sekadar "Bidak Catur" biasa, komputer bisa mengenali jiwa asli di dalamnya adalah Kuda. Alhasil, ia langsung menerapkan aturan huruf 'L' milik Kuda.

---

## 💡 Mengapa Konsep Ini Sangat Penting?

Tanpa polimorfisme, programmer harus menulis kode yang sangat panjang dan cerewet, seperti:
* *Jika* ini Kuda, geraknya begini.
* *Jika* ini Benteng, geraknya begitu.
* *Jika* ini Pion, geraknya beda lagi.

Dengan polimorfisme, program menjadi sangat ringkas, pintar, dan mandiri. Sang jenderal (program utama) tidak perlu pusing memikirkan cara jalan setiap bidak. Masing-masing bidak sudah cukup cerdas untuk mengurus dirinya sendiri ketika diberi satu perintah universal!

---
