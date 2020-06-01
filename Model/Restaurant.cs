using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Model
{
    public class Restaurant
    {
        private string onwerName;
        private string id;
        private string attentionHour;
        private string exclusiveTables;
        public Restaurant(string onwerName, string id, string attentionHour, string exclusiveTables)
        {
            this.onwerName = onwerName;
            this.id = id;
            this.attentionHour = attentionHour;
            this.exclusiveTables = exclusiveTables;
        }

        public string OnwerName { get => onwerName; set => onwerName = value; }
        public string Id { get => id; set => id = value; }
        public string AttentionHour { get => attentionHour; set => attentionHour = value; }
        public string ExclusiveTables { get => exclusiveTables; set => exclusiveTables = value; }
    }
}
