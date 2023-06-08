Album DreamTheaterAlbum = new()
{
    Name = "Train of Thought",
};

Song musica1 = new()
{
    Name = "This Dying Soul",
    Duration = 600,
};

Song musica2 = new()
{
    Name = "Stream of Consciousness",
    Duration= 600,
};

DreamTheaterAlbum.AddSong(musica1);
DreamTheaterAlbum.AddSong(musica2);

DreamTheaterAlbum.ShowSongs();
