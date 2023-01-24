using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrainingDB;

public class Shift
{
    public int Id { get; private set; }
    public static int _Count { get; private set; } = 1;
    public double ShiftDuration { get; set; }

    public Shift() { }
    public Shift(double shiftDuration)
    {
        Id = _Count++;
        ShiftDuration = shiftDuration;
    }

}
