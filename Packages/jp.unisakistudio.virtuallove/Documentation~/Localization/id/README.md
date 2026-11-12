# Virtual Love

Alat untuk avatar VRChat yang memungkinkan Anda menikmati pose berpasangan bersama pasangan dalam pelacakan 3 titik atau mode desktop. Tersedia 22 pose untuk masing-masing sisi pria dan wanita, 44 pose secara keseluruhan. Split berdiri dan tantangan Jack-O juga dapat dilakukan.

README ini ditujukan untuk v3.2.0 yang sedang dikembangkan. Tanggal rilis resmi belum ditentukan. Versi terpasang dapat diperiksa di bagian atas Inspector.

- [Halaman produk BOOTH](https://yunisaki.booth.pm/items/3641334)
- [Riwayat perubahan](CHANGELOG.md)

## Bahasa tampilan dan dokumen offline

Pilih bahasa melalui “Language / 言語” di bagian atas Inspector. Satu pilihan berlaku untuk Inspector dan menu VRChat yang dibuat. Unggah ulang avatar untuk mengubah bahasa di dalam gim.

Jika belum dipilih, bahasa komputer digunakan; bahasa yang tidak didukung memakai bahasa Inggris. Windows, macOS, dan Linux didukung. Pilihan terakhir disimpan di EditorPrefs dan digunakan di proyek lain milik pengguna OS yang sama pada komputer ini. Semua alat pose dan avatar menggunakan bahasa yang sama. Mengubahnya di Inspector alat mana pun memperbarui preferensi bersama; pilihan bahasa per avatar diabaikan. Pilihan tidak disinkronkan ke komputer lain. Cara penyimpanan lisensi tidak berubah. Tombol bahasa hanya muncul pada konfirmasi pemasangan awal jika belum ada bahasa yang disimpan. Perubahan bahasa berikutnya dilakukan di Inspector.

README dan riwayat perubahan dapat dipilih melalui [daftar bahasa](../index.html) yang disertakan. “Panduan” dan “Lihat perubahan” di Inspector juga mengikuti bahasa pilihan. Nama pose yang disertakan dan nama kategori menu dalam permainan juga ditampilkan dalam bahasa pilihan. Ketentuan penggunaan tetap disertakan dalam bahasa Jepang seperti sebelumnya.

## Cara pemasangan

1. Impor “VirtualLove_Boy.unitypackage” atau “VirtualLove_Girl.unitypackage” yang disertakan dalam berkas pembelian ke Unity.
2. Setelah sumber paket didaftarkan, Anda dapat menambahkan Virtual Love ke proyek yang digunakan melalui VCC atau ALCOM. Unisaki Posing System 3.2.0 diperlukan.
3. Di Hierarchy, klik kanan avatar yang ingin dipasangi alat ini, lalu pilih “Unisaki Studio > Tambahkan Virtual Love (Pria)” atau “Unisaki Studio > Tambahkan Virtual Love (Wanita)”.
4. Pilih “三点だいしゅき(男)” atau “三点だいしゅき(女)” yang ditambahkan di dalam avatar, lalu atur fitur dan pose yang digunakan di Inspector.
5. Periksa pose dengan pratinjau, lalu unggah avatar seperti biasa.

Persyaratan: Unity 2022.3, VRChat Avatars SDK 3.10.4 atau lebih baru, Modular Avatar seri 1.x versi 1.15.1 atau lebih baru, dan NDMF seri 1.x versi 1.14.0 atau lebih baru. Perbarui juga paket yang diperlukan melalui VCC atau ALCOM.

## Memperbarui dari versi sebelumnya

Perbarui produk ini bersama Unisaki Posing System. Pengaturan alat yang sudah ditempatkan tetap dipertahankan. Periksa fitur yang digunakan dan penggunaan ExpressionParameters di Inspector. Jika sebelumnya menggunakan prabuild, tekan “Perbarui prabuild” sebelum mengunggah ulang.

## Lokasi pengaturan

| Tab | Pengaturan utama |
| --- | --- |
| Fitur | Penambahan menu dalam permainan, mode foto, napas, gambar ikon, dan pemeriksaan penggunaan parameter |
| Pose | Pose yang digunakan, pencarian, penambahan, pengurutan, pratinjau, dan penyesuaian animasi |
| Pengaturan Avatar | Koreksi tubuh, impor pose asli dan gerakan buatan sendiri, serta prasetel |

Aktifkan fitur yang diperlukan sebelum mengunggah. Item yang memiliki “Buka pengaturan” dapat menampilkan pengaturan terperinci di bawahnya.

## Kontrol dasar dalam permainan

Buka menu Expressions dan pilih pose Virtual Love. Pilih pose yang berpasangan antara sisi pria dan wanita, lalu sesuaikan posisi dan arah Anda dengan pasangan.

Anda dapat mengalihkan kunci kepala, lengan, dan kaki untuk mengatur bagian tubuh yang mengikuti pelacakan. Dengan “Kunci kaki”, Anda dapat menggerakkan kepala sambil mempertahankan pose bagian kaki. Jika ingin mencerminkan pose atau menyesuaikan tingginya, aktifkan fitur yang sesuai di Unity terlebih dahulu.

### Mode foto

Anda dapat memindahkan avatar sendiri ke posisi yang terlihat, menyesuaikan arahnya, lalu memotret.

1. Aktifkan “Fitur > Fitur menu > Mode foto” di Unity.
2. Buka “Mode foto” di VRChat dan pilih pose yang diinginkan melalui “Pilih pose”.
3. Gunakan “Jarak” untuk memindahkan avatar hingga 3m ke depan. Saat jarak lebih besar dari 0, avatar menghadap Anda.
4. Putar dengan “Arah”, lalu setelah posisinya pas, aktifkan “Kunci kaki” bila perlu. Kaki tidak dikunci otomatis di awal, sehingga posisi dapat disesuaikan sebelum dikunci.
5. Setelah selesai memotret, tekan “Keluar foto”. Jarak dan arah dikembalikan, dan kunci kaki dilepas.

Jika “Gestur mati” ditambahkan ke menu, bentuk tangan juga dapat diganti di dalam mode foto.

Jika posisi dan arah hanya diubah di layar Anda sendiri, mode foto tidak menggunakan parameter tersinkron. Untuk memperlihatkan posisi dan arah yang sama kepada orang lain, aktifkan “Fitur > Kemudahan > Sinkronkan mode foto” di Unity.

Jika kepala Anda sendiri menghilang saat mendekat sehingga sulit memotret, aktifkan “Tetap tampilkan kepala dalam mode foto”. Pengaturan ini berlaku pada layar Anda sendiri selama pemotretan dan kembali ke tampilan biasa setelah selesai.

### Tinggi kaki dan Tinggi lantai

Aktifkan item yang ingin digunakan pada “Fitur > Fitur menu” di Unity untuk menambahkannya ke menu “Pengaturan” di VRChat.

- **Tinggi kaki**: menyesuaikan tinggi bagian kaki sambil mempertahankan posisi kepala. Gunakan saat kaki tenggelam ke lantai atau melayang, atau saat ingin menyamakan tinggi dengan pasangan.
- **Tinggi lantai**: menggerakkan seluruh tubuh, termasuk kepala, ke atas dan ke bawah. 50% adalah tinggi asli, 0% berarti 3m lebih rendah, dan 100% berarti 3m lebih tinggi. Untuk mengembalikannya, setel kembali ke sekitar 50%.

Dipadukan dengan mode foto, fitur ini memungkinkan Anda menyesuaikan tinggi, jarak, dan arah avatar. Perpindahan dan rotasi mode foto serta tinggi lantai juga mengoreksi gerakan bawaan dan gerakan khusus saat tidak ada pose yang dipilih. Periksa sudut pandang di dalam VRChat dan perilaku setelah gerakan bawaan diganti pada perangkat sebenarnya.

### Cerminkan dan Gestur mati

- **Cerminkan**: aktifkan “Fitur > Fitur menu > Cerminkan”, lalu tukar sisi kiri dan kanan pose melalui menu VRChat.
- **Gestur mati**: aktifkan “Fitur > Fitur menu > Gestur mati”. Saat diaktifkan di VRChat, bentuk jari yang diatur pada pose tetap dipertahankan meskipun Anda menggenggam pengontrol.

### Napas

1. Aktifkan “Fitur > Kemudahan > Animasikan napas”.
2. Melalui “Buka pengaturan”, pilih “Tidak ada, Lemah, Sedang, Kuat, Cepat, Khusus” untuk setiap kategori pose. Sesuaikan kekuatannya pada kategori yang sesuai dengan pose Virtual Love. Dengan “Khusus”, Anda dapat menentukan animasi napas buatan sendiri.
3. Jika ingin menghentikan dan melanjutkan napas di dalam permainan juga, aktifkan pula “Fitur > Fitur menu > Napas”. Di VRChat, gunakan “Napas” untuk beralih ON/OFF.

Aktifkan “Nonaktifkan goyangan diam VRChat” untuk meredam goyangan tubuh bawaan yang otomatis muncul saat diam. Napas yang diatur di alat pose tetap dapat digunakan.

### Mengurangi perubahan pose akibat arah kepala

Aktifkan “Fitur > Kemudahan > Kurangi perubahan pose akibat rotasi kepala”. Gunakan jika pose tubuh menjadi rusak saat kunci kepala dilepas karena arah kepala berbeda dari pose aslinya.

### Berguling

Berguling adalah fitur yang digunakan dengan menyiapkan pose berbaring yang sesuai beserta animasi menyamping.

1. Aktifkan “Fitur > Fitur menu > Berguling”.
2. Di “Pose”, buka “Rincian” pada pose yang ingin digunakan, lalu aktifkan “Aktifkan berguling”.
3. Tetapkan animasi yang sesuai pada “Pose berguling samping”, dan sesuaikan “Kekuatan koreksi lantai” bila perlu.
4. Di VRChat, pilih pose yang sesuai, lepas kunci kepala, lalu aktifkan “Berguling”. Miringkan kepala ke kiri atau kanan untuk berguling.

Pose yang menggunakan berguling tidak dapat memakai pengaturan MotionTime biasa. Pose yang disertakan dalam Virtual Love tidak dilengkapi animasi menyamping untuk berguling, jadi siapkan gerakan yang sesuai jika ingin menggunakannya.

## Penggunaan parameter

Menonaktifkan fitur yang tidak diperlukan mengurangi penggunaan ExpressionParameters.

| Fitur | Penggunaan tambahan |
| --- | --- |
| Cerminkan | 1 bit |
| Gestur mati | 1 bit |
| Tinggi kaki | 8 bit |
| Tinggi lantai | 8 bit |
| Animasi napas | 0 bit |
| ON/OFF napas dalam permainan | 1 bit |
| Mode foto (hanya layar sendiri) | 0 bit |
| Sinkronisasi mode foto | 16 bit |
| Tampilan kepala saat pemotretan | 0 bit |
| Pengurangan perubahan pose akibat arah kepala | 1 bit (dipakai bersama Berguling) |
| Berguling | 10 bit (1 bit di antaranya dipakai bersama pengurangan perubahan pose) |

Penggunaan untuk pemilihan pose dan lainnya ditambahkan pada angka-angka ini. Periksa totalnya di Inspector. Jika beberapa alat pose menggunakan fitur bersama, bagian yang dipakai bersama tidak dihitung berulang. Penggunaan oleh alat lain, seperti pakaian, tidak termasuk dalam total ini.

## Memeriksa dan menyesuaikan pose

“Pratinjau” pada setiap pose di “Pose” menampilkan pose tersebut di Scene. Buka “Penyesuaian Animasi” untuk menyesuaikan arah tubuh dan sendi sambil melihat pratinjau, lalu menyimpannya.

Pose yang disertakan dibuat berdasarkan “あのん（Anon）” karya こよりLab. Sesuaikan titik sentuh dengan pasangan dan hal serupa menurut proporsi tubuh dan pakaian.

“Aktifkan koreksi avatar” pada “Pengaturan Avatar” mengoreksi perbedaan sudut awal sendi dan puntiran dari avatar acuan. “Cegah lutut menekuk terbalik” meredam lutut yang menekuk ke arah terbalik. Buka pengaturan terperinci untuk menyesuaikan “Tekukan lutut minimum (derajat)”. Periksa juga tampilan saat koreksi aktif dengan pratinjau.

Pencarian nama pose, penambahan beberapa animasi, dan pengubahan urutan juga dilakukan di “Pose”. Nonaktifkan atau hapus pose yang tidak diperlukan.

Pratinjau sederhana tidak menjalankan proses build MA dan NDMF, jadi periksa juga hasil akhir, termasuk pakaian dan alat lain, setelah build avatar.

### Gambar ikon pose

Aktifkan “Buat ikon pose” pada “Fitur” untuk menambahkan gambar pose ke menu dalam permainan. Build memerlukan waktu lebih lama sesuai waktu pembuatan gambar. Untuk menghemat ukuran, aktifkan “Kurangi ukuran ikon”. Ikon pose tidak dibuat untuk Android.

### Prasetel

Prasetel dapat dipilih di bagian paling bawah “Pengaturan Avatar”. “Terapkan prasetel ini” menggantikan pengaturan pose saat ini, jadi simpan hasil penyesuaian Anda sebelum beralih.

Berkas animasi penyesuaian yang dibuat dengan fitur penyesuaian animasi, beserta prasetel yang menggunakannya, boleh didistribusikan dan dijual tanpa izin tersendiri dari Unisaki Studio. Manfaatkan misalnya untuk berbagi data penyesuaian bagi avatar buatan sendiri.

## Prabuild

“Perbarui prabuild” menyimpan hasil pembuatan menu dan animasi sehingga dapat digunakan kembali saat build avatar dan mempercepat prosesnya. Tanpa prabuild pun, data yang diperlukan dibuat saat build biasa.

Setelah mengubah pose atau fitur, lihat “Periksa pengaturan” di Inspector dan perbarui prabuild jika Anda menggunakannya. Menyembunyikan peringatan tidak memperbarui hasil yang dibuat.

## Tentang hadiah

Jika tidak menggunakannya sendiri, Anda boleh menghadiahkan salah satu edisi, pria atau wanita, kepada pasangan Anda. Penerima hadiah hanya boleh menggunakannya bersama orang yang memberikannya.

## Catatan penggunaan

- Produk ini dibuat untuk tujuan candaan. Mohon tidak menggunakannya untuk pelecehan.
- Gunakan dengan mematuhi ketentuan layanan dan etika VRChat.
- Penguncian pose selama pelacakan seluruh tubuh tidak didukung.
- Bergantung pada proporsi tubuh, pakaian, dan modifikasi avatar, penyesuaian manual mungkin diperlukan.
- Jika digunakan bersama alat pengubah pose lain, periksa cara kerja penguncian dan peralihan pose. Dalam beberapa kasus, hal ini dapat disesuaikan melalui “Pengaturan Avatar > Integrasikan kunci pelacakan dengan alat lain”.
- Pembuat tidak bertanggung jawab atas kerugian yang timbul akibat penggunaan alat ini.

## Ketentuan penggunaan

Gunakan produk ini setelah menyetujui ketentuan penggunaan yang disusun dengan lisensi VN3.

[Ketentuan penggunaan Virtual Love](https://drive.google.com/file/d/1Uu8y4z-G-P0btDCdY-ahQsTJInCNbxyD/view?usp=sharing)
