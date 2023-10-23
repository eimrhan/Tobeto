int secim;

do
{
    Menu();

    bool girdi;
    do
    {
        Console.Write("Seçiminiz: ");
        string secimStr = Console.ReadLine();
        girdi = int.TryParse(secimStr, out secim);
        // secimStr dönüştürülmek istenen değer, eğer dönüşebilirse onu "out" ile belirtilen değere atar.
        // sonucunda dönüşürse true döner dönüşmezse false. bunu da bir değişkene atadık ve döngüyü sağladık.
        // TryParse metodu sayesinde integer harici değer girilip programın patlamasına önlem almış olduk.

    } while (!girdi);

    SecimYap(secim);

} while (secim != 0);


static void Menu()
{
    Console.Clear();
    BaslikAt("Alan Hesaplama Uygulaması");

    Console.WriteLine("1 -> Kare Alanı Hesapla");
    Console.WriteLine("2 -> Dikdörtgen Alanı Hesapla");
    Console.WriteLine("3 -> Üçgen Alanı Hesapla");
    Console.WriteLine("0 -> ÇIKIŞ");
    Console.WriteLine();
}

static void SecimYap(int secim)
{
    switch (secim)
    {
        case 1:
            KareHesapla();
            break;
        case 2:
            DikdörtgenHesapla();
            break;
        case 3:
            UcgenHesapla();
            break;
    }
}
static void BaslikAt(string baslik)
{
    Console.WriteLine(baslik);

    for (int i = 0; i < baslik.Length; i++)
        Console.Write("-");

    Console.WriteLine();
}

static void KareHesapla()
{
    Console.Clear();
    BaslikAt("Kare Alanı Hesapla");

    Console.Write("Karenin kenar uzunluğunu (cm) girin: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Karenin Alanı = " + a * a);

    DevamUyarisi();
}

static void DikdörtgenHesapla()
{
    Console.Clear();
    BaslikAt("Dikdörtgen Alanı Hesapla");

    Console.Write("Dikdörtgenin kısa kenar uzunluğunu (cm) girin: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Dikdörtgenin uzun kenar uzunluğunu (cm) girin: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Dikdörtgenin Alanı = " + a * b);

    DevamUyarisi();
}

static void UcgenHesapla()
{
    Console.Clear();
    BaslikAt("Üçgen Alanı Hesapla");

    Console.Write("Üçgenin taban uzunluğunu (cm) girin: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Üçgenin yüksekliğini (cm) girin: ");
    int h = int.Parse(Console.ReadLine());
    double alan = Convert.ToDouble(a) * Convert.ToDouble(h) / 2d;
    Console.WriteLine("Üçgenin Alanı = " + alan);

    DevamUyarisi();
}

static void DevamUyarisi()
{
    Console.WriteLine();
    Console.Write("Devam etmek için bir tuşa basın...");
    Console.ReadKey();
}