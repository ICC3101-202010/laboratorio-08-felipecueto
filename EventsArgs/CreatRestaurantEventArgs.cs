﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.EventsArgs
{
    public  class CreatRestaurantEventArgs:EventArgs
    {
        public string OnwerNameText { get; set; }
        public string IdText { get; set; }
        public string AttentionHour1Text { get; set; }
        public string ExclusiveTables { get; set; }
    }
}
