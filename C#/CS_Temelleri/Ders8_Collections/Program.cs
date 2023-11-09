using Ders8_Collections;

string[] names = new string[] { "Emir", "Han" };
// 2 elemanlı bir string dizisi.

//names[2] = "isim"; // 3. elemanı atayamazsın, uygulama patlar.
//Console.WriteLine(names[2]);

names = new string[3]; // aynı isimle 3 elemanlı yeni bir string dizisi oluştu
names[2] = "isim"; // 3. elemana veriyi atar fakat
Console.WriteLine(names[2]); // bu artık yeni bir adresi işaret ettiği için eski verileri kaybettik
Console.WriteLine(names[1]); // boş döner.


Console.WriteLine("******************************************");
//* İşte burada Listeler devreye giriyor.

//List<string> names2 = new List<string>();
List<string> names2 = new List<string> { "Emir", "Han" };

names2.Add("isim");
Console.WriteLine(names2[2]); // şimdi sıkıntı çıkmadı işte.


Console.WriteLine("******************************************");
//* Listeler olmasaydı bu generic yapıyı kendimiz nasıl oluştururduk:
//** Generics - (MyList.cs dosyasına göz at.)

MyList<string> names3 = new MyList<string>();

names3.Add("Emir");
Console.WriteLine(names3.Length);
names3.Add("Han");
Console.WriteLine(names3.Length);

foreach (string name in names3.Items)
{
    Console.WriteLine(name);
}