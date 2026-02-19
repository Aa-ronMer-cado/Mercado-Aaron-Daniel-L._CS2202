using System;

class Song
{
    public string Title{get;set;}
    public string Artist{get;set;}
    public double Duration{get;set;}

    public Song(string title, string artist, double duration)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
    }

    public Song(string title, string artist) : this(title, artist, 0) {}

    public Song(string title) : this(title, "Unknown Artist", 0) {}

    public Song() : this("Unknown Title", "Unknown Artist", 0) {}

    public static void DisplaySong(Song song)
    {
        Console.Write($"{song.Title,-30}");
        Console.Write($"{song.Artist,-25}");
        Console.Write($"{song.Duration,-10}");
    }
}

    class MusicPlaylistOrganizer
{
    public static void Main()
    {
        Console.Write("Songs to add: ");
        int numberOfSongs = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Song[] playlist = new Song[numberOfSongs];

        for (int i = 0; i < numberOfSongs; i++)
        {
            Console.WriteLine($"Song #{i+1}");

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Artist: ");
            string artist = Console.ReadLine();

            Console.Write("Duration (in minutes): ");
            double duration = double.Parse(Console.ReadLine());

            playlist[i] = new Song(title, artist, duration);
            Console.WriteLine();

        }

        Console.WriteLine("=== || MY PLAYLIST || ===");
        Console.WriteLine($"{"Title",-30}{"Artist",-25}{"Time",-10}");
        Console.WriteLine("-------------------------------------------------------------");
        foreach (Song song in playlist)
        {
            Song.DisplaySong(song);
            Console.WriteLine();
        }

        double CalculateTotalDuration(Song[] songs)
        {
            double totalDuration = 0;
            foreach (Song song in songs)
            {
                totalDuration += song.Duration;
            }
            return totalDuration;
        }

        double CalculateAverageDuration(Song[] songs)
        {
            if (songs.Length == 0) return 0;
            return CalculateTotalDuration(songs) / songs.Length;
        }

        Console.WriteLine();
        Console.WriteLine($"Total Duration: {CalculateTotalDuration(playlist):F2} mins");
        Console.WriteLine($"Average Duration: {CalculateAverageDuration(playlist):F2} mins");
    }
}

