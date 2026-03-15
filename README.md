# Interactive-3D-Book-Diary-System
Interactive 3D Book & Diary System
Bu modül, oyuncunun toplayabildiği ve menü üzerinden 3D sayfa çevirme hissiyle (Page Curl Effect) etkileşime girebildiği bir günlük sistemidir.

Özellikler:

Gerçekçi Sayfa Çevirme (Book.cs): Mouse sürüklemesi ile sayfanın köşelerinden tutulup kıvrılması, gölge hesaplamaları (Trigonometrik RectTransform manipülasyonu).

Otomatik Çevirme (AutoFlip.cs): Butonlar aracılığıyla sayfaların pürüzsüz bir animasyonla (Coroutine ile) çevrilmesi.

Merkezi UI Yönetimi (DiaryCanvasController): Modüler CanvasManager ile tam uyum. Günlük açıldığında arka plan otomatik bulanıklaşır ve oyuncu hareketleri durdurulur; ekstra bir bağımlılığa ihtiyaç duymaz.

Kurulum:

DiaryCanvas objesini sahnenize ekleyin ve UI katmanında ayarlayın.

Book.cs scriptine çevrilecek sayfaların Sprite'larını (bookPages) atayın.

Dünyadaki 3D objenize Diary.cs scriptini verin. Obje toplandığında veya okunduğunda Canvas otomatik olarak ekrana gelecektir.
