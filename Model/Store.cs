using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Model
{
    public class Store
    {
        private string onwerName;
        private string id;
        private string attentionHour;
        private string categories;

        public Store(string onwerName, string id, string attentionHour,string categories)
        {
            this.onwerName = onwerName;
            this.id = id;
            this.attentionHour = attentionHour;
            this.categories = categories;
        }

        public string OnwerName { get => onwerName; set => onwerName = value; }
        public string Id { get => id; set => id = value; }
        public string AttentionHour { get => attentionHour; set => attentionHour = value; }
        public string Categories { get => categories; set => categories = value; }
    }
}
