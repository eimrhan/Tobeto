// Arkadaş Sayı Bulma

Console.Write("sayi 1'i gir: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("sayi 2'yi gir: ");
int num2 = int.Parse(Console.ReadLine());

int sum1 = 0;
int sum2 = 0;

for (int i = 1; i < num1; i++)
    if (num1 % i == 0)
        sum1 += i;

for (int i = 1; i < num2; i++)
    if (num2 % i == 0)
        sum2 += i;

if (sum1 == num2 && sum2 == num1)
    Console.WriteLine(num1 + " ve " + num2 + " sayıları arkadaşlar");
else
    Console.WriteLine(num1 + " ve " + num2 + " sayıları arkadaş değiller.");

Console.ReadKey();