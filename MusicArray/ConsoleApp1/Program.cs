using System;
using static System.Console;

namespace funWithMusic
{
    class Program
    {
        enum Genre { Rap, Metal, Electronic, Classical, KPop }
        struct Music
        {
            public string Title;
            public string Artist;
            public string Album;
            public int Length;
            public Genre Genre;

            public Music(string title, string artist, string album, int length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }

            public void displaySongs()
            {
                WriteLine($"Title: {Title} Artist: {Artist} Album: {Album} Legnth: {Length} minutes Genre: {Genre}");
            }

            public void setTitle(string title) { Title = title; }
            public void setLength(int length) { Length = length; }
            public void setAlbum(string album) { Album = album; }
            public void setArtist(string artist) { Artist = artist; }
            public void setGenre(Genre genre) { Genre = genre; }

        }
        static void Main(string[] args)
        {
            WriteLine("How many songs would you like to enter: ");
            int arraySize = int.Parse(Console.ReadLine());
            Music[] songs = new Music[arraySize];
            try
            {
                for (int i = 0; i < arraySize; i++)
                {
                    WriteLine("Please enter the song title: ");
                    songs[i].setTitle(ReadLine());
                    WriteLine("Please enter the song artist: ");
                    songs[i].setArtist(ReadLine());
                    WriteLine("Please enter the song album: ");
                    songs[i].setAlbum(ReadLine());
                    WriteLine("Please enter the song length: ");
                    songs[i].setLength(int.Parse(ReadLine()));
                    WriteLine("Please enter the song genre:R for Rap, M for Metal, E for Electronic, C for Classical or K for Kpop ");
                    string tempGenre = ReadLine();
                    tempGenre.ToUpper();
                    switch (tempGenre)
                    {
                        case "R":
                            songs[1].setGenre(Genre.Rap);
                            break;
                        case "M":
                            songs[i].setGenre(Genre.Metal);
                            break;
                        case "E":
                            songs[i].setGenre(Genre.Electronic);
                            break;
                        case "C":
                            songs[i].setGenre(Genre.Classical);
                            break;
                        case "K":
                            songs[i].setGenre(Genre.KPop);
                            break;
                    }
                }
            }
            catch (ArgumentException e)
            {
                WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                WriteLine(e.Message);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
            finally
            {
                for (int x = 0; x < songs.Length; x++)
                {
                    songs[x].displaySongs();
                }
            }
        }
    }
}