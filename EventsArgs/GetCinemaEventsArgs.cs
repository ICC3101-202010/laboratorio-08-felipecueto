using Lab8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.EventsArgs
{
   public class GetCinemaEventsArgs:EventArgs
    {
        public List<Cinema> cinemas { get; set; }
    }
}
