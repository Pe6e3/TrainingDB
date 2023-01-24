
class Program
{
    public static void Main()
    {
        Box box= new Box();
        box.PutStone();
        box.PutStone();
        box.ShowStonesInBox();
    }
}

public class Box
{
    string BoxName { get; set; }


    public List<Stone> Stones { get; set; } = new List<Stone>();

    public void PutStone()
    {

        Console.WriteLine("Введите цвет камня");
        string? color = Console.ReadLine();

        Console.WriteLine("Введите вес камня");
        int weight = Convert.ToInt32(Console.ReadLine());

        Stone stone = new Stone(color,weight);
        Stones.Append(stone);
    }

    public void ShowStonesInBox()
    {
        Console.WriteLine("Камни в Коробке:");
        foreach (var item in Stones)
        {
            
            Console.WriteLine($"{item}");
        }
    }
}


public class Stone
{
    string StoneColor { get; set; }
    int StoneWeight { get; set; }

    public Stone(string color, int weight)
    {
        Console.WriteLine($"Вы положили в ящик камень {color} цвета и весом {weight} ");
    }

    
}