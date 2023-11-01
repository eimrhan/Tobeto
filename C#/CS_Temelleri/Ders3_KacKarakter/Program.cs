// Bir string içindeki karakter sayılarını veren bir C# programı yazınız:
// Ör: Tobeto -> t:2, o:2, b:1, e:1 

string s = "tobeto";
string s2 = "";

foreach (char c in s)
    if (!s2.Contains(c))
        s2 = s2 + c;

foreach (char c in s2)
{
    int result = s.Split(c).Length - 1;
    Console.WriteLine(c + ": " + result);
}