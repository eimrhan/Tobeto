// İki String'in birbirinin anagramı olup olmadığı nasıl kontrol edilir?

string s1 = "katip";
string s2 = "kitap";
int count1 = 0;
int count2 = 0;

foreach (char c in s1)
{
    if (s2.Contains(c))
    {
        Console.WriteLine(c);
        count1++;
    }
}
foreach (char c in s2)
{
    if (s1.Contains(c))
    {
        Console.WriteLine(c);
        count2++;
    }
}

if (s1.Length == s2.Length && count1 == count2)
    Console.WriteLine("anagram");
else
    Console.WriteLine("anagram değil");