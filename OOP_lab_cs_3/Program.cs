using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        // Operations on string type
        Console.WriteLine("\nOperations on string type:");
        Console.WriteLine($"Length of string1: {str1.Length}");
        Console.WriteLine($"Length of string2: {str2.Length}");
        Console.WriteLine($"str1 == str2: {str1 == str2}");
        Console.WriteLine($"str1.Equals(str2): {str1.Equals(str2)}");
        Console.WriteLine($"ReferenceEquals(str1, str2): {ReferenceEquals(str1, str2)}");
        string str3 = str1 + str2;
        Console.WriteLine($"Concatenated string: {str3}");

        Console.WriteLine("\nOperations on StringBuilder type:");
        StringBuilder sb1 = new StringBuilder(str1);
        StringBuilder sb2 = new StringBuilder(str2);
        Console.WriteLine($"Length of sb1: {sb1.Length}");
        Console.WriteLine($"Length of sb2: {sb2.Length}");
        Console.WriteLine($"sb1 == sb2: {sb1.ToString() == sb2.ToString()}");
        Console.WriteLine($"sb1.Equals(sb2): {sb1.Equals(sb2)}");
        Console.WriteLine($"ReferenceEquals(sb1, sb2): {ReferenceEquals(sb1, sb2)}");
        StringBuilder sb3 = sb1.Append(sb2);
        Console.WriteLine($"Concatenated string: {sb3}");

        // Operations on string1
        Console.WriteLine("\nOperations on string1:");
        Console.WriteLine($"String contains 'OGO' or 'AGA': {str1.Contains("OGO") || str1.Contains("AGA")}");
        string str1Modified = ModifyString(str1);
        Console.WriteLine($"Modified string: {str1Modified}");

        // Operations on string2
        Console.WriteLine("\nOperations on string2:");
        int count = CountWordsStartingWith(str2, 'o');
        Console.WriteLine($"Number of words starting with 'o': {count}");
    }

    static string ModifyString(string str)
    {
        string result = str.Replace("OGO", "**").Replace("AGA", "**");
        return result;
    }

    static int CountWordsStartingWith(string str, char c)
    {
        int count = 0;
        string[] words = str.Split(' ');
        foreach (string word in words)
        {
            if (word.StartsWith(c.ToString()))
            {
                count++;
            }
        }
        return count;
    }
}
