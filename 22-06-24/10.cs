using System;

public class Hello
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number in digits: ");
        string digit = Console.ReadLine();
        int num = Convert.ToInt32(digit); // 12345
        
        if (num == 0)
        {
            Console.WriteLine("Zero");
            return;
        }

        Console.WriteLine(NumberToWords(num));
    }

    public static string NumberToWords(int num)
    {
        if (num == 0)
            return "Zero";

        string[] unitsMap = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        string[] tensMap = { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        string[] teensMap = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        string words = ""; // empty initialy

        if ((num / 1000) > 0)  
        {
            words += NumberToWords(num / 1000) + " Thousand ";   
            num %= 1000;
        }

        if ((num / 100) > 0)
        {
            words += NumberToWords(num / 100) + " Hundred ";
            num %= 100;
        }

        if (num > 0)
        {
            if (words != "")
                words += "and ";

            if (num < 10)
                words += unitsMap[num];
            else if (num < 20)
                words += teensMap[num - 10];
            else
            {
                words += tensMap[num / 10];
                if ((num % 10) > 0)
                    words += "-" + unitsMap[num % 10];
            }
        }

        return words.Trim();
    }
}
