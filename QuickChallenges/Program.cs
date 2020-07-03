using System;

namespace QuickChallenges
{
    class Program
    {
        static void Main(string[] args)
        {

            string palindrom = "Anna";
            Console.WriteLine($"IsPalindrom: {palindrom}: {palindrom.IsPalindrom(true)}");

            string palindromCaseSensitive = "anna";
            Console.WriteLine($"IsPalindrom: {palindromCaseSensitive}: {palindromCaseSensitive.IsPalindrom(true)}");


            string palindromNumber = "121";
            Console.WriteLine($"IsPalindrom: {palindromNumber}: {palindromNumber.IsPalindrom()}");

            string noPalindrom = "Markus";
            Console.WriteLine($"IsPalindrom: {noPalindrom}: {noPalindrom.IsPalindrom()}");

            Console.WriteLine();

            string charactersOnly = "Hello";
            Console.WriteLine($"IsNumber: {charactersOnly}: {charactersOnly.IsNumber()}");

            string digitsOnly = "123";
            Console.WriteLine($"IsNumber: {digitsOnly}: {digitsOnly.IsNumber()}");

            string digitsAndCharacters = "1a23";
            Console.WriteLine($"IsNumber: {digitsAndCharacters}: {digitsAndCharacters.IsNumber()}");

            Console.WriteLine();

            int[] numbers = new int[5] { 1, 13, 300, 42, 5 };
            var second = Numbers.FindSecondLargestNumber(numbers);
            Console.WriteLine($"Second largest number: {second}");

            string palindromMatches = "AnnannAnn";
            var countMatches = palindromMatches.CountMatches("nn");
            Console.WriteLine($"CountMatches - {palindromMatches} - 'nn': {countMatches}");

        }
    }
}
