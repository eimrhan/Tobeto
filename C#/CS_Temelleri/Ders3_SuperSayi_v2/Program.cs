// ilk 10 süper sayı:

int sayac = 0;
int k = 2;

while (sayac < 10)
{
    bool asal = true;

    for (int j = 2; j < k; j++)
    {
        if (k % j == 0)
        {
            asal = false;
            break;
        }
    }

    if (asal)
    {
        Double mukemmelsayi = (Math.Pow(2, k - 1)) * (Math.Pow(2, k) - 1);
        decimal sayi = (decimal)mukemmelsayi;
        Console.WriteLine(sayi.ToString());
        sayac++;
    }

    k++;
}


// ilk 10 süper sayı: (4'e kadar buluyor, sonrası için işlem saatler sürecek gibi, kötü yöntem)

//int sayac = 0;
//decimal k = 2;

//while (sayac < 10)
//{
//    decimal summ = 0;
//    for (int j = 1; j < k; j++)
//        if (k % j == 0)
//            summ += j;

//    if (k == summ)
//    {
//        Console.WriteLine(k);
//        sayac++;
//    }

//    k++;
//}