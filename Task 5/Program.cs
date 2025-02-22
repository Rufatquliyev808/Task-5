using System;
using System.Linq;
using System.Globalization;



///// Tapsiriq 5.1.1 Sozleri tersine cevirir ve hamisini boyukle yazir


//Console.WriteLine("Cumle daxil et: ");
//string input = Console.ReadLine();

//string reversedSentence = string.Join(" ", input.Split (' ').Select(word => new string(word.Reverse().ToArray())). Select(word => word.ToUpper()));

//Console.WriteLine("Netice:" + reversedSentence);


////////////////////////// Tapsiriq 5.1.2 Sozlerin yerini deyisir ve hamisini boyukle yazir


//Console.WriteLine("Cumle daxil et: ");
//string input = Console.ReadLine();

//string reversedSentence = string.Join(" ", input.Split(' ').Reverse().Select(word => word.ToUpper()));

//Console.WriteLine("Netice:" + reversedSentence);

///////////////////////////// Tapsiriq 5.1.3 Sozlerin yerini deyisir ve yalniz birinci herfleri boyukle yazir


//Console.WriteLine("Cumle daxil et: ");
//string input = Console.ReadLine();

//TextInfo textInfo = new CultureInfo("az-Latn-AZ", false).TextInfo;
//string reversedSentence = string.Join(" ", input.Split(' ').Reverse().Select(word => textInfo.ToTitleCase(word.ToLower())));


//Console.WriteLine("Netice:" + reversedSentence);

/////////////////////////// Tapsiriq 5.2 Bosluq olan sozleri vergulle ayirir ve boyuk herfe cevirir


//Console.Write("Sozleri daxil et (Bosluqla ayir): ");
//string input = Console.ReadLine();
//string result = string.Join(", ", input.Split(' ')).ToUpper();

//Console.WriteLine("Netice: " + result);

////////////////////////  Tapsiriq 5.3

//Console.Write("Sozu daxil et: ");
//string input = Console.ReadLine();

//string reversed = new string(input.Reverse().ToArray());

//bool isPalindrome = string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase);

//Console.WriteLine("Tersine cevrilmis versiya: "+ reversed);
//Console.WriteLine("Soz Palindromdur? " +(isPalindrome ? "Beli" : "Xeyir"));


////////////////// Tapsiriq 5.4


//Console.WriteLine("Cumleni daxil et: ");
//string input = Console.ReadLine();
//string[] words = input.Split (new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
//string longestWords = words.OrderByDescending (word => word.Length).First ();
//string shortestWord = words.OrderBy (word => word.Length).First ();
//Console.WriteLine ("En uzun soz: " + longestWords);
//Console.WriteLine("En qisa soz: " + shortestWord);


////////////// Tapsiriq 5.5

//int[] numbers = { 3, 7, 12, 5, 9, 15, 20, 8 };
//double average = numbers.Average ();
//int integerPart = (int)average;

//int[] modifiedNumbers = numbers.Select(num=> num +integerPart).ToArray ();

//int[] evenNumbers = modifiedNumbers.Where(numbers=> numbers %2 == 0).ToArray ();


///////////////////////////////




