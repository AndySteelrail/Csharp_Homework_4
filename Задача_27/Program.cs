using System;
                    
public class Program
{
    public static void Main()
    {
        int GetInput()
        {
            Console.Write("Введите число, сумму цифр которого нужно получить: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введено число: {number}");
            
            return number;
        }
            
        int GetSumOfNumbers(int number)
        {
            int div = number;
            int residue = 0;
            int sumOfNumbers = 0;
            while (div > 0)
            {
                residue = div % 10;
                sumOfNumbers += residue;
                div /= 10;
            }
            
            return sumOfNumbers;
        }
 
        void Output()
        {
            int number = GetInput();
            Console.WriteLine($"Сумма цифр числа {number}: {GetSumOfNumbers(number)}");
        }
 
        Output();
    }
}