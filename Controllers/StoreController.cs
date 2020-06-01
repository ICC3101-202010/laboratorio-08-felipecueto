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
    public class StoreController
    {
        List<Store> stores = new List<Store>();
        Form1 form;
        public StoreController(Form form)
        {
            this.form = form as Form1;
            this.form.CreatStore += OnCreatStore;
            this.form.gotStore += Onshowinfo;

        }
        public void OnCreatStore(object sender, CreatStoreEventArgs e)
        {
            stores.Add(new Store(e.OnwerNameText, e.IdText, e.AttentionHour1Text,e.CategoriesText));
            MessageBox.Show("Tienda creada");
        }

        public bool OnveryfyexistCinema(object sender, VerifyLocalExistEventArgs e)
        {
            foreach (Store cinema in stores)
            {
                if (cinema.OnwerName == e.OnwerNameText)
                {
                    return true;
                }
            }
            return false;
        }
        public List<Store> Onshowinfo(object sender, GetStoreEventsArgs e)
        {
            return stores;
        }
    }
}
