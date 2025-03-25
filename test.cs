using System;

class Program
{
    static void Main()
    {
        Console.Write("?? Matn kiriting: ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        Console.WriteLine($"?? Teskari matn: {reversed}");
    }
}
