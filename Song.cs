using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Che.Songs
{


    public class Song
    {
        public String name { get; set; }
        public String artist { get; set; }
        public int copiesSold { get; set; }

        public Song(String name, String artist, int copiesSold)
        {
            this.name = name;
            this.artist = artist;
            this.copiesSold = copiesSold;
            GetCertification(); 
        }


        public string GetArtist()
        {
            return artist;
        }
        public string GetDetails()
        {            
            string details = $"Name: {name} Artist: {artist} Copies Sold: {copiesSold}";
            return details;
        }
        public string GetCertification()
        {
            if (copiesSold < 200000)
            {
                return null;
            }
            else if (copiesSold >= 200000 && copiesSold < 400000)
            {
                return "Silver";
            }
            else if (copiesSold >= 400000 && copiesSold < 600000)
            {
                return "Gold";
            }
            else if (copiesSold >= 600000)
            {
                return "Platinum";
            }
            else
            {
                return string.Empty;
            }




        }
    }
}
