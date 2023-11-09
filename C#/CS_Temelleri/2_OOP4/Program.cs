using _2_OOP4;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

BasvuruManager basvuruManager  = new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());
// yukarıda instance oluşturmayıp bu şekilde de direkt newleyip gönderebilirsin. ↵

Console.WriteLine("*********************************");

// birden fazla loglama yapmak istediğimiz bir senaryoda ise:
ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

List<ILoggerService> loggerServices = new List<ILoggerService> { fileLoggerService, databaseLoggerService };

basvuruManager.BasvuruYap(konutKrediManager, loggerServices);

Console.WriteLine("*********************************");


List<IKrediManager> krediler = new List<IKrediManager>() { tasitKrediManager, konutKrediManager };
basvuruManager.KrediOnBilgilendirmesiYap(krediler);


// Bir Not: "Interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız."
// Interface'lerle ilgili kaynak: https://www.youtube.com/live/MU_YQtgdkKA?t=4330&si=yzD1sck7IK5N2fEU

// Bu örnekte yeni bir alternatif, yani yeni bir kredi veya log türü eklenmek istendiğinde, yeni bir interface eklenmesi yeterlidir.
// bu sayede projeye ekleme yaparken kodlar arasında kaybolmadan, temiz bir yapı oluşturulmuş olur.