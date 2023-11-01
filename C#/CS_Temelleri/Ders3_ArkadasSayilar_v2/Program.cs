// İlk iki dost çifti bulan bir C# programı yazınız. (Çıktı: 1-> 220-284 2: 1184-1210)

int numberTwoTotal = 0;
int numberOneTotal = 0;
int[] array = new int[4];
int friendNumberCount = 0;

for (int q = 1; q <= 1210; q++)
    for (int w = 1; w <= 1210; w++)
    {
        numberOneTotal = 0;
        numberTwoTotal = 0;
        for (int i = 1; i < q; i++)
            if (q % i == 0)
                numberOneTotal += i;

        for (int i = 1; i < w; i++)
            if (w % i == 0)
                numberTwoTotal += i;

        if (q == numberTwoTotal && w == numberOneTotal)
            if (q != w)
            {
                array[friendNumberCount] = q;
                friendNumberCount++;
            }
    }


int[,] dizi2 = new int[2, 2];

for (int i = 0; i < 2; i++)
    for (int j = 0; j < 2; j++)
        dizi2[i, j] = array[i * 2 + j];


for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
        Console.Write(dizi2[i, j] + " ");

    Console.WriteLine();
}