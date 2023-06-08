public class Song
{
    public string Name { get; set; }

    public string Artist { get; set; }

    public int Duration { get; set; }

    public bool Available { get; set; }

    public string SongDescription => $"A música {Name} pertence à banda {Artist}";

    public string Genre { get; set; }

    public void DetailedDescription()
    {
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Artista: {Artist}");
        Console.WriteLine($"Duração: {Duration}");
        Console.WriteLine($"Disponível: {Available}");
    }
}