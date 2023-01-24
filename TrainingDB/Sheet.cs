using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrainingDB;

public class Sheet
{
    public int Id { get; private set; }
    public static int _Count { get; private set; } = 1;
    public string FullName { get; set; }
    //public IEnumerable<Shift> shifts { get; private set; }
    public List<Shift> Shifts { get; private set; }
    Shift shift = new Shift();


    public Sheet(string fullName)
    {
        FullName = fullName;
        Id = _Count++;
    }

    public void ListOfSheets()
    {
        while (true)
        {
            Console.Write("Введите количество отработанных часов: ");
            double hours = Convert.ToInt32(Console.ReadLine());
            if (hours == 0) return;
            NewShift(hours);
        }
    }

    public void NewShift(double duration)
    {
        shift = new Shift(duration);
        //Shifts.Add(shift);
    }

    public void ShowShifts()
    {
        Console.WriteLine($"№{shift.Id}");
        Console.WriteLine($"ФИО: {shift.ShiftDuration}");

        //foreach (var item in shifts)
        //{

        //    Console.WriteLine($"№{Id}");
        //    Console.WriteLine($"ФИО: {FullName}");
        //    Console.WriteLine($"№ смены: {item.Id}");
        //    Console.WriteLine($"Смена часов: {item.ShiftDuration}");
        //}
    }
}

