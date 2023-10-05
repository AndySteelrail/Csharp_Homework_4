using System;
                    
public class Program
{
    public static void Main()
    {
        int GetInput(string messageHello, string messageBye)
        {
            Console.WriteLine(messageHello);
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{messageBye}: {number}");
            
            return number;
        }
            
        int[] GetArray(int length, int minNumber, int maxNumber)
        {
            int[] array = new int[length];
            for(int i = 0; i < length; i++)
            {
                array[i] = new Random().Next(minNumber, maxNumber + 1);
            }
            
            return array;
        }
 
        void Output()
        {
            int length = GetInput("Введите размерность массива", "Размерность массива: ");
            int minNumber = GetInput("Введите минимально возможный элемент массив", "Минимум массива: ");
            int maxNumber = GetInput("Введите максимально возможный элемент массив", "Максимум массива: ");
            int[] array = GetArray(length, minNumber, maxNumber);
            
            Console.WriteLine("Случайный массив, полученный по входным параметрам:");
            Console.Write("[");
            for(int i = 0; i < length; i++)
            {
                Console.Write(array[i]);
                if (i != length - 1) Console.Write(", ");
            }
            Console.Write("]");
        }
 
        Output();
    }
}