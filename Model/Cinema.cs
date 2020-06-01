using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Model
{
    public class Cinema
    {
        private string onwerName;
        private string id;
        private string attentionHour;
        private string nRooms;

        public Cinema(string onwerName, string id, string attentionHour, string nRooms )
        {
            this.onwerName = onwerName;
            this.id = id;
            this.attentionHour = attentionHour;
            this.nRooms = nRooms;
        }

        public string OnwerName { get => onwerName; set => onwerName = value; }
        public string Id { get => id; set => id = value; }
        public string AttentionHour { get => attentionHour; set => attentionHour = value; }
        public string NRooms { get => nRooms; set => nRooms = value; }
    }
}
