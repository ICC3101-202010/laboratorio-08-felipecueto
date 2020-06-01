using Lab8.EventsArgs;
using Lab8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8.Controllers
{
   public  class CinemaController
    {
        List<Cinema> cinemas = new List<Cinema>();
        Form1 form;
        public CinemaController(Form form)
        {
            this.form = form as Form1;
            this.form.CreatCine += OncreatCinema;
            //this.form.veryfyexist += OnveryfyexistCinema;
            this.form.gotCinema += Onshowinfo;
        }
        public void OncreatCinema(object sender, CreatCinemaEventArgs e)
        {
            cinemas.Add(new Cinema(e.OnwerNameText,e.IdText, e.AttentionHour1Text, e.NRooms));
            MessageBox.Show("Cine creado");
        }
        public bool OnveryfyexistCinema(object sender, VerifyLocalExistEventArgs e)
        {
            foreach (Cinema cinema in cinemas)
            {
                if (cinema.OnwerName == e.OnwerNameText)
                {
                    return true;
                }
            }
            return false;
        }
        public List<Cinema> Onshowinfo(object sender, GetCinemaEventsArgs e)
        {
            return cinemas;
        }
    }
}
