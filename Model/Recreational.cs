using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Model
{
    public class Recreational
    {
        private string onwerName;
        private string id;
        private string attentionHour;

        public Recreational(string onwerName, string id, string attentionHour)
        {
            this.onwerName = onwerName;
            this.id = id;
            this.attentionHour = attentionHour;
        }
        public string OnwerName { get => onwerName; set => onwerName = value; }
        public string Id { get => id; set => id = value; }
        public string AttentionHour { get => attentionHour; set => attentionHour = value; }
    }
}
