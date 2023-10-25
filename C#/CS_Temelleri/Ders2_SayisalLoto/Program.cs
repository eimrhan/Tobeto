int columnCount;
bool isValid;
do
{
    Console.Write("(1-8 arası) Kolon Sayısı Gir: ");
    isValid = int.TryParse(Console.ReadLine(), out columnCount);
    if (columnCount < 1 || columnCount > 8)
    {
        isValid = false;
    }
} while (!isValid);


for (int j = 0; j < columnCount; j++)
{
    Console.Write("{0}. kolon : ", j + 1);

    Random randomNum = new Random();

    int arrayLength = 6;
    int minValue = 1;
    int maxValue = 49;

    int[] randomArray = new int[arrayLength];

    for (int i = 0; i < arrayLength; i++)
    {
        int temp = randomNum.Next(minValue, maxValue);
        while (randomArray.Contains(temp))
        {
            temp = randomNum.Next(minValue, maxValue);
        }
        randomArray[i] = temp;
    }

    foreach (var loto in randomArray)
    {
        Console.Write(loto + " ");
    }
    Console.WriteLine();
}