using Lab8.EventsArgs;
using Lab8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab8.Controllers
{
    public class RestaurantController
    {
        List<Restaurant> restaurants = new List<Restaurant>();
        Form1 form;
        public RestaurantController(Form form)
        {
            this.form = form as Form1;
            this.form.CreatRestaurant += OnCreatRestaurant;
            this.form.gotRestaurant += Onshowinfo;
        }
        public void OnCreatRestaurant(object sender, CreatRestaurantEventArgs e)
        {
            restaurants.Add(new Restaurant(e.OnwerNameText, e.IdText, e.AttentionHour1Text,e.ExclusiveTables));
            MessageBox.Show("Restoran Agregado");

        }

        public bool OnveryfyexistCinema(object sender, VerifyLocalExistEventArgs e)
        {
            foreach (Restaurant cinema in restaurants)
            {
                if (cinema.OnwerName == e.OnwerNameText)
                {
                    return true;
                }
            }
            return false;
        }
        public List<Restaurant> Onshowinfo(object sender,GetRestaurantEventsArgs e) 
        {
            return restaurants;
        }
    }
}
