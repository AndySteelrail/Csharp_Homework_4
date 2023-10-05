using System;
                    
public class Program
{
    public static void Main()
    {
        double GetInputNumber()
        {
            Console.Write("Введите возводимое в степень число: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введено число: {number}");
            
            return number;
        }
        
        int GetInputPower()
        {
            Console.Write("Введите натуральную степень, в которую возводится число: ");
            int power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введена (приведена до целой) степень: {power}");
            
            return power;
        }
        
        bool CheckPower(int power)
        {
            if (power > 0) return true;
            else
            {
                Console.WriteLine($"Введённая степень: {power} - ненатуральное число!");
                return false;
            }
                
        }
        
        double GetNumberInPower(double number, int power)
        {
            double numberInPower = 1;
            for (int i = 1; i <= power; i++)
            {
                numberInPower *= number;
            }
            
            return numberInPower;
        }
 
        void Output()
        {
            double number = GetInputNumber();
            int power = GetInputPower();
            
            if (CheckPower(power) == true)
            {
                Console.WriteLine($"Число {number} в степени {power} - {GetNumberInPower(number, power)}");
            }
        }
 
        Output();
 
    }
}