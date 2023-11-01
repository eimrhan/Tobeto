// is Number Armstrong? :

int number = int.Parse(Console.ReadLine()); // try 407
string strNumber = number.ToString();
double result = 0;

for (int i = 0; i < strNumber.Length; i++)
{
    int parsedNumber = int.Parse(strNumber[i].ToString());
    result += (Math.Pow(parsedNumber, strNumber.Length));
}

if (number == result)
    Console.WriteLine(number + " sayısı Armstrong sayıdır.");
else
    Console.WriteLine("Armstrong değil.");

Console.ReadLine();