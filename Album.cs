class Album
{
    private List<Song> songs = new List<Song>();
    public string Name { get; set; }

    public int TotalDurationInMinutes => songs.Sum(s => s.Duration) / 60;

    public void AddSong(Song song)
    {
        songs.Add(song);
    }

    public void ShowSongs()
    {
        Console.WriteLine($"Lista de músicas do álbum: {Name}");
        foreach (var song in songs)
        {
            Console.WriteLine($"Música : {song.Name}");
        }
        Console.WriteLine($"Duração total do álbum: {TotalDurationInMinutes} minutos");
    }
}