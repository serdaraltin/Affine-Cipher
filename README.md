# Doğrusal Şifreleme (Affine-Cipher)
**Doğrusal Şireleme Algoritması ile hazırlanmış şifreleme yazılımı.**

------------



- [YOUTUBE](https://www.youtube.com/channel/UCltJlvbcFATfBm0qHttpZNg?view_as=subscriber "YOUTUBE") kanalında verilen eğitime katkıda bulunması amacıyla hazırlanmıştır.
- **VISUAL STUDIO 2015** editörü kullanılarak hazırlanan uygulama görsel bir arayüze sahiptir.


------------



### Yazan: Şadi Evren ŞEKER


Bu şifreleme yöntemindeki amaç geometride doğrunun denklemi olarak bilinen y=ax+b doğrusal fonksiyonunu şifreleme işleminde kullanmaktır. Buna göre x, şifrelenecek mesajı (plain text), y şifrelenmiş mesajı (cipher text) ifade etmekte olup a ve b ikilisi anahtarı oluşturmaktadır.

Örnek mesaj:

    baba dede

Anahtar: **(3,2)** yani **a=3**, **b=2** olarak verilmiş<br>
Şifreli mesajın oluşuturulması: <br>
**b** harfi için **2**. harf olduğu kabul edilirse,
**3×2 + 2 = 8** olarak bulunur yani karşılığı allfabenin **8.** harfidir. <br>
Bu harf ‘**h**’ harfidir. Diğer harflerde benzer şekilde hesaplanır. <br>
Örneğin ‘**e**’ harfine karşılık gelen harf için** 3×5 +2 = 17** yani ‘**q**’ harfi bulunur. <br>

Şifreli mesaj:

    hehe nqnq

Bu şifreleme yönteminin aslında bir yerine koyma şifrelemesi (substitution cipher) olduğu söylenebilir. Buna göre sadece hangi karakterin hangi karakter yerine konulacağı bir formüle bağlanmıştır.

Bu şifreleme yöntemine saldırı için frekans analizi yöntemi kullanılabilir.


------------
### [Meyta - Kriptoloji 4 - Doğrusal Şifreleme(Affine Cipher)](https://www.youtube.com/watch?v=tFLuU_gBk3k "Kriptoloji 4 - Doğrusal Şifreleme(Affine Cipher)")
![Meyta - Kriptoloji 2 - Sezar Şifreleme](https://github.com/serdaraltin/Affine-Cipher/blob/master/Dogrusal%20Sifreleme/bin/Debug/On%20Izleme.jpg)

------------

**Tasarım - Form1.Designer.cs**

![Form1](https://github.com/serdaraltin/Affine-Cipher/blob/master/Dogrusal%20Sifreleme/bin/Debug/ScreenShot.PNG)

------------



**Kod - Form1.cs**

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dogrusal_Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sifrele_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tx_a.Text); // a degeri
            int b = Convert.ToInt32(tx_b.Text); // b degeri
            
            for (int i = 0; i < tx_acikmesaj.TextLength; i++)
            {
                int ascii_degeri = tx_acikmesaj.Text[i] - 96;
                int y = (a * ascii_degeri) + b;

                while (y > 26)
                {
                    y = y - 26;
                }

                char sifrelenmis_harf = (char)(y + 96);

                tx_sifrelimesaj.Text += sifrelenmis_harf;
            }
        }
    }
}
```

**Powered By DeadSound**
