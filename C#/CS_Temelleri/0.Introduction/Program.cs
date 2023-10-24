/****************************** Giriş: Değişkenler ve Dönüşümler ******************************/

Console.WriteLine("Hello, World!"); // write sadece yazar, writeline yazar ve satır atlar.
Console.ReadKey(); // program VS içinden çalıştırıldığında bir problem yok fakat
// .exe dosyası çalıştırılacaksa, iş bitince kapanmaması için ReadKey() eklenir.
/// \DotNetTemelleri\1.Project\bin\Debug\net6.0\1.Project.exe

float kusuratSayi1 = 3.14F; // float tanımlarken sayının sonuna F yazman gerek.
// daha büyük hanelere sahip sayılar için double kullanılır.
double kusuratli2 = 2.56; // double'da gerek yok, küsüratlı sayılarda varsayılan double'dır.
// daha da büyüğü gerekirse decimal
decimal kusuratli3 = 1.2M; // D harfi double'a tanımlı olduğu için bunda M koyuyoruz.
bool truefalse = false; // boolen değerin varsayılanı false'dur.

//enum MyEnum
//{
//    a = 10, b = 15, c, d
//}
/* değer atamazsan sıralı gider. c=16 d=17.
(hiç değer atamadan da kullanılabilir.) */
//myEnum.a; // 10


Random rastgele = new Random(); // rastgele bir değer üretir
int randomSayi1 = rastgele.Next(100); // Next metodu 0'dan belirtilen sayıya kadar int değer üretir.
int randomSayi2 = rastgele.Next(5, 15); // 5 ile 15 arasında int değer üretir.
double randomSayi3 = rastgele.NextDouble(); // 0 ile sıfır arasında küsüratlı bir değer üretir.


string sayiString = "54";
int sayiToInt = Convert.ToInt32(sayiString);
int sayiParse = int.Parse(sayiString); // Parse metodu sadece stringden dönüşüm sağlar
bool tf = bool.Parse("false"); // boolen değer olan False 'e çevirir.
string sayiToString = sayiToInt.ToString();

Console.WriteLine(sayiString + 3, sayiToInt + 3, sayiParse + 3, sayiToString + 3); // 543, 57
Console.ReadKey();

int integerSayi = 54;
string stringSayi = "54";
Console.WriteLine(integerSayi + 3); // 57 sonuca ekrana yazdırılırken aslında arkaplanda stringe döner.
Console.WriteLine(stringSayi + 3); // 3 sayısı otomatik olarak stringe çevirilir. 
//* Implicit dönüşüm: (.ToString) metodu kullanıldı ama Implicit şekilde.
//* Dönüşümü biz elle yaparsak (.Parse gibi) bu kullanıma Explicit deniyor.


int secim;
string secimStr = Console.ReadLine();
bool girdi = int.TryParse(secimStr, out secim);
// secimStr dönüştürülmek istenen değer, eğer dönüşebilirse onu "out" ile belirtilen değere atar.
// sonucunda dönüşürse true döner dönüşmezse false. bunu da bir değişkene atadık ve döngüyü sağladık.
// TryParse metodu sayesinde integer harici değer girilip programın patlamasına önlem almış olduk.
Console.WriteLine(girdi);


object obj; // null
obj = "abc";
obj = 10; // içine yazmaya devam etmez, override eder.
// Console.WriteLine(obj + 5); // objeyi diğer ifadelerle direkt toplayamazsın dönüşüm işlemi gerekli.
Console.WriteLine(obj.ToString() + 5); // 105
Console.WriteLine(Convert.ToInt32(obj) + 5); // 15
// unboxing
// Convert yerine Casting metodu ile de istediğimiz değişkeni obje içerisinden çıkarabiliriz.
int cikan = (int)obj; // 10
// unboxing için genelde Casting yöntemi kullanılır, Convert pek tercih edilmez.


Console.Write("Bölünecek sayıyı girin: ");
string strSayi1 = Console.ReadLine(); // girdiyi değişkene aldık. girdi string olmak zorunda
int bolunen = int.Parse(strSayi1); // girilen değeri integer değere dönüştürdük.

Console.Write("Böleni girin: ");
string strSayi2 = Console.ReadLine();
int bolen = int.Parse(strSayi2);


/****************************** Döngüler ******************************/

int sc = 2;
switch (sc)
{
    case 1:     // birden fazla case için aynı sonuç dönecekse bu şekilde birlikte kullanılabilir.
    case 2:
        Console.WriteLine("sayı 1 veya 2");
        break;
    case 3:
        Console.WriteLine("sayı 3");
        break;
    default:
        Console.WriteLine("sayı bilinmiyor.");
        break;
}


/****************************** Debugging ******************************/

try
{
    if (bolen == 0)
    {
        throw new Exception("Bölen sıfır olamaz. Programı yeniden başlatın.");
    }   // "throw" ile kendimiz bir hata fırlatıp programı sonlandırabiliriz.

    decimal sonuc = bolunen / bolen;
    Console.WriteLine(sonuc);
}
catch (Exception e) // Exception'ı catch'de yakalarsak program kırılmaz, 
{
    Console.WriteLine("İşlem sırasında hata oluştu");
    Console.WriteLine(e.Message); // hatayı yakalayıp yazdırdık.
}   // bundan sonraki aşama girdiyi tekrar istemek.
finally
{
    Console.WriteLine("Burası her halükarda çalışır");
}

/****************************** Diziler ******************************/

string[] strDizi = new string[2]; // 2 elemanlı string bir dizi tanımlama.
strDizi[0] = "abc";
strDizi[1] = "cba";

int[] sayilar = new int[3] { 1, 2, 3 }; // ilk oluşturmada bu şekilde tanımlanabilir.

int[] sayilar2 = (int[])sayilar.Clone(); // Clone metodu nesne döner. (int[]) ile casting ettik.

int[] sayilar3 = new int[sayilar.Length];
sayilar.CopyTo(sayilar3, 0); // sayilar dizisini sayilar3 dizisine 0. indexten itibaren kopyala.

Array.Sort(sayilar3); // int değerleri küçükten büyüğe, string ifadeleri alfabetik sıralar.
DiziyiEkranaYaz(sayilar3);

Array.Reverse(sayilar3); // sıralanmış ifadeyi tersine çevirdi. (mevcut sıralamayı çevirir.)
DiziyiEkranaYaz(sayilar3);

Array.Resize(ref sayilar, sayilar.Length + 1); // sayilar dizisinin boyutunu 1 büyüttük.
sayilar[sayilar.Length - 1] = 4; // index 0'dan başlar. (son karakter length-1)
// küçültme işleminde son elemanları kaybedeceğini unutma (eğer varsa).

int index = Array.IndexOf(strDizi, "abc"); // 0 döner. (0. indexte)
int index2 = Array.IndexOf(strDizi, "bca"); // bulamadığı veri -1 döner.



/****************************** Metodlar ******************************/

static void DiziyiEkranaYaz(int[] dizi) // void tipli metodlar geriye değer döndürmez.
{
    foreach (int i in dizi)
        Console.WriteLine(i);
}

int toplam1 = Topla(2, 4); // 6 - son değer opsiyonel (varsayılan değeri atanmış) olduğu için hata vermedi.
int toplam2 = Topla(1, 4, 5); // 10
// int toplam22 = Topla(2, 4, 6, 8); // bu sefer overload edildi, 4 parametre alan fonksiyonu çağırır.

// bir parametreye varsayılan değer atanması, o değerin opsiyonel olduğunu ifade eder.
// eğer o parametreye değer gönderilirse override eder, gönderilmezse default değer neyse onu kullanır.
// dipnot: opsiyonel (varsayılan değerli) parametreler sona yazılır, yoksa hata verir.
static int Topla(int say1, int say2, int say3 = 0) // int değer döndüren bir metod.
{
    return say1 + say2 + say3;
}

/*** Overloading ***/
/*
static int Topla(int say1, int say2, int say3, int say4) // imzaları farklı, aynı isimle metod tanımlanabilir.
{
    return say1 + say2 + say3 + say4;
}
// normalde bu şekilde overload edilebiliyor fakat .net core 7.0'da hata verdi, değişmiş olabilir. gerekirse bakılır.
*/

/// kaç parametre girileceği belli olmadığı durumda sonsuz overload metod yazmak imkansız ve gereksiz.
/// bu durumda devreye params giriyor:
/*** Params ***/

int toplam3 = Topla2(0, sayilar2); // params kullanılmadan dizi metoduna sadece dizi gönderebilirsin.
int toplam4 = Topla2(3, 5, 7, 8, 9); // params metodu kullandıldığında istediğin boyutta sayıyı gönderebilirsin.
// params esneklik sağlar, gönderdiğin değerleri dizi olarak alır ve döngüye tabi tutularak işlemler gerçekleşir.
static int Topla2(int sayi, params int[] sayilar) // eğer params harici başa parametre de alacaksa, params en sonda olmalı.
{                                                 // ve params 1 metodda sadece 1 adet olabilir.
    int toplam = 0;
    foreach (int i in sayilar)
        toplam += i;
    return sayi + toplam;

    // ya da
    // sayi + sayilar.Sum();
}


/*** Ref Keywordu: ***/
int refSay1 = 10;
int refSay2 = 20;

Topla3(ref refSay1, refSay2);
static int Topla3(ref int say1, int say2)
{
    say1 = 30;
    return say1+say2; // 40
}
Console.WriteLine(refSay1); // normalde farklı scope üzerinde değişim yapıldığı için global scope'a etki etmemesi lazım fakat
// ref keywordu ile gönderdiğimiz için global scope değeri de değişti refSay1 değeri 30 oldu.

/*** Out Farkı: **/
/* ref'te değişkenin değeri başta başta verilmiş olmalı, out'da böyle bir zorunluluk yok.
    fark 2: out'ta o değikeni parametre olarak gönderdiğin yerde değiştirmek zorundasın. */
int outSay1;
int outSay2 = 20;

Topla4(out outSay1, outSay2);
static int Topla4(out int say1, int say2)
{
    say1 = 30;  // bu değişimi ref'te yapmak zorunlu olmamasına karşın out'ta zorunlu.
    return say1 + say2; // 40
}
Console.WriteLine(refSay1);


/***** String Metodlar *****/

string str = "Bu cümle düzenlenecek. ";
Console.WriteLine("-" + str + "-");

// Trim -- baştaki ve sondaki fazlalık boşlukları siler.
Console.WriteLine("-" + str.Trim() + "-");

// SubString
Console.WriteLine("-" + str.Substring(3, 5) + "-");
// 3. indexten itibaren 5 haneli substring.

// Reverse
char[] chars = str.ToCharArray();       // önce her bir karakteri bölüp diziye attık
Array.Reverse(chars);                   // sonra ters çevirdik
string reversed = new string(chars);    // son olarak char dizisini string değişkenine atınca kendiliğinden birleşmiş oldu.
Console.WriteLine("-" + reversed + "-");

// IndexOf
Console.WriteLine("-" + str.IndexOf('ü') + "-");    // ilk bulduğunun indexini döner. - 4
// sonrakileri de bulmak istersen paranteze bi virgül atar, bulunan index+1 'den itibaren aratmaya devam edersin.
// Console.WriteLine("-" + str.IndexOf('ü', ilkbulunan+1) + "-"); // tabi bunun için ilk bulunanı bir değişkene atmak gerek.
Console.WriteLine("-" + str.IndexOf("cümle") + "-"); // girilen değerin başlangıç indexini döner. - 3

// Remove
string removed = str.Remove(2, 6); // 2. indexten itibaren 6 karakter siler.
Console.WriteLine("-" + removed + "-");

// Contains
Console.WriteLine(str.Contains("cümle")); // true döner.

// Replace
string replaced = str.Replace("bu", "şu");
Console.WriteLine("-" + replaced + "-");
// string replaced = str.Replace(" ", ""); // Replace metodu boşlukları silmek için de kullanılabilir.

// Split
string[] splitted = str.Split(' '); // boşlukları referans alarak bölüp diziye atar, yani tüm kelimeleri.
Console.WriteLine("-" + string.Join(' ', splitted) + "-"); // kelime dizisini aralarına boşluk koyarak birleştirip bir string ifadeye çevirdi.


/***** Math Metodları *****/

double val = 3.46;

// Round
Console.WriteLine(Math.Round(val, 1)); // virgülden sonra kaç hane sonra yuvarlama yapılacağını seçebilir veya belirtmeyebilirsin. (default: 0) -> 3,5
// Floor aşağı, Ceiling yukarı yuvarlar. (küsürat ne olursa olsun)


/*** DateTime Metodları ***/

Console.WriteLine(DateTime.Now); // şimdiyi verir.
Console.WriteLine(DateTime.Now.Day); // bugünü verir.
Console.WriteLine(DateTime.Now.Year); // mevcut yılı verir.
// dahası da var gerektiğinde alınır.

Console.WriteLine(DateTime.Now.AddDays(10)); // şu anın tarihine 10 gün ekler
// gün ay yıl saat saniye dakika ... ne istersen var. hepsini yazmaya gerek yok.
// geriye gitmek içinse parametreyi negatif (-) vermek yeterli.

Console.WriteLine(DateTime.Now.ToShortDateString); // 27.09.2023
Console.WriteLine(DateTime.Now.ToLongDateString); // 27 Eylül 2023 Çarşamba
Console.WriteLine(DateTime.Now.ToShortTimeString); // 22:16
Console.WriteLine(DateTime.Now.ToLongTimeString); // 22:16:48

DateTime tarih = new DateTime(1996, 11, 21, 03, 30, 50);
Console.WriteLine(tarih.ToString()); // 21.11.1996 03:30:50
