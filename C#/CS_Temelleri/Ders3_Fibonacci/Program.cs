// ilk 100 fibonacci sayısı:

decimal a = 0, b = 1, c = 0;

for (int i = 2; i < 100; i++)
{
    c = a + b;
    Console.WriteLine(" {0}, ", c);
    a = b;
    b = c;
}