using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Reservoir> reservoirs = new List<Reservoir>
        {
            new Reservoir { Name = "Reservoir1", Capacity = 1000, Department = "Department1", Factory = "Factory1" },
            new Reservoir { Name = "Reservoir2", Capacity = 1500, Department = "Department2", Factory = "Factory2" },
            new Reservoir { Name = "Reservoir3", Capacity = 2000, Department = "Department3", Factory = "Factory1" }
        };

        // Далее реализуем функции и операции над объектами
        // Например, вывод всех резервуаров в консоль
        foreach (var reservoir in reservoirs)
        {
            Console.WriteLine($"Reservoir: {reservoir.Name}, Department: {reservoir.Department}, Factory: {reservoir.Factory}");
        }

        // Вычисление общей суммы загрузки всех резервуаров
        int totalCapacity = 0;
        foreach (var reservoir in reservoirs)
        {
            totalCapacity += reservoir.Capacity;
        }
        Console.WriteLine($"Total capacity of all reservoirs: {totalCapacity}");

        // Поиск по наименованию в коллекции
        Console.WriteLine("Enter the name to search:");
        string searchName = Console.ReadLine();
        Reservoir foundReservoir = reservoirs.Find(r => r.Name == searchName);
        if (foundReservoir != null)
        {
            Console.WriteLine($"Reservoir found - Name: {foundReservoir.Name}, Department: {foundReservoir.Department}, Factory: {foundReservoir.Factory}");
        }
        else
        {
            Console.WriteLine("Reservoir not found.");
        }
    }
}
