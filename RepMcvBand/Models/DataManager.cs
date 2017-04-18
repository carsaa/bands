using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepMcvBand.Models
{

    public static class DataManager
    {
        static List<Band> bands = new List<Band>
        {
            new Band {Id = 1, Name = "Coldplay", Description = "British pop band with lead singer Chris Martin"},
            new Band {Id = 2, Name = "Frank Ocean", Description = "American rapper known for his album Orange"},
            new Band {Id = 3, Name = "Joshua Radin", Description = "Singer-songwriter from America"}
        };

        public static Band GetBandById(int id)
        {
            return bands[id];     
        }

        public static Band[] GetAllBands()
        {
            return bands.ToArray();  
        }

    }

}
