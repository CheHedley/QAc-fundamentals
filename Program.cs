using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Che.Songs
{
    public class Program
    {
        static void Main(string[] args)
        {
             InputSongDetails();
            Song[] Array_Of_Songs = (new Song[4]);

            
            for(int i = 0; i < 4; i++)
            {
                Array_Of_Songs[i] = InputSongDetails();
            }
            Console.WriteLine("Enter an artists name, or press return for all artists");
            var artistSelection = Console.ReadLine();

            for(int i = 0; i < Array_Of_Songs.Length; i++)
            {
                if(artistSelection==Array_Of_Songs[i].GetArtist)
                {

                }
            }
        }
        static Song InputSongDetails()
        {
            Console.WriteLine("Please enter the name of the song:");
            string nameOfSong = Console.ReadLine();
            Console.WriteLine("Please enter the name of the artist:");
            string nameOfArtist = Console.ReadLine();
            Console.WriteLine("Please enter the quantity of copies sold:");
            var quantityCopiesSold = Console.ReadLine();
            var isValidCopiesSold = int.TryParse(quantityCopiesSold, out int parsedQuantityCopiesSold);

            do
            {
                if (!isValidCopiesSold)
                {
                    Console.WriteLine("The quantity of copies sold is not valid. Please enter a valid amount.");
                    quantityCopiesSold = Console.ReadLine();
                    isValidCopiesSold = int.TryParse(quantityCopiesSold, out parsedQuantityCopiesSold);
                }
            }
            while (!(isValidCopiesSold&&parsedQuantityCopiesSold >= 0));

            return new Song(nameOfSong, nameOfArtist, parsedQuantityCopiesSold);            
        }

    }
}
