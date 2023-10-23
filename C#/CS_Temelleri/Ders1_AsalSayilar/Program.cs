// 2-100 arası asal sayılar:

for (int i=2; i<100; i++)
{
    bool asal = true;

    for (int j=2; j<i; j++)
    {
        if (i % j == 0)
        {
            asal = false;
            break;
        }
    }

    if(asal)
        Console.WriteLine(i);
}