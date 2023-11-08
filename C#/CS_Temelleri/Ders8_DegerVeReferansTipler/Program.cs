int sayi1 = 10;
int sayi2 = 20;

sayi1 = sayi2;
sayi2 = 30;

Console.WriteLine(sayi1); // 20

//////////////////////////////////

int[] sayilar1 = new int[] { 1, 2, 3, 4, 5 };
int[] sayilar2 = new int[] { 10, 20, 30, 40, 50 };
// new ile bellekte (heap) yeni bir alan oluşturur.

sayilar1 = sayilar2; // sayilar1 artık sayilar2'nin adresini tutuyor. (referans veri tipi)
sayilar2[0] = 99;

Console.WriteLine(sayilar1[0]); // 99

// grafiksel anlatım: https://i.imgur.com/ecuzRlK.jpeg