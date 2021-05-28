using System;

namespace App1
{
    delegate double Average(int x, int y, int z);
    
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            try
            {
                Console.Write("Введите х: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите y: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите z: ");
                z = Convert.ToInt32(Console.ReadLine());
                Average avg = delegate(int x, int y, int z) { return (double)(x + y + z) / 3d; };
                Console.WriteLine($"\nСреднее арифметическое чисел {x},{y},{z} = {avg(x,y,z)}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Что-то пошло не так,проверьте правильность введённых данных\n{ex.Message}");
            }
        }
    }
}
