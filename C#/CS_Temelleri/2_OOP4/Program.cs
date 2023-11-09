using _2_OOP4;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

BasvuruManager basvuruManager  = new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManager);

Console.WriteLine("*********************************");

List<IKrediManager> krediler = new List<IKrediManager>() { tasitKrediManager, konutKrediManager };
basvuruManager.KrediOnBilgilendirmesiYap(krediler);


// Bir Not: "Interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız."
// Interface'lerle ilgili kaynak: https://www.youtube.com/live/MU_YQtgdkKA?t=4330&si=yzD1sck7IK5N2fEU