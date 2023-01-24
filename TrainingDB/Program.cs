using TrainingDB;

class Program
{
    public static void Main()
    {
        Sheet sheet = new Sheet("Иванов И.И.");

        sheet.ListOfSheets();
        sheet.ShowShifts();
    }
}