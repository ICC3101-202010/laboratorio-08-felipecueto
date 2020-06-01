using Lab8.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            RecreationalController recreationalController = new RecreationalController(form1);
            StoreController storeController = new StoreController(form1);
            RestaurantController restaurantController = new RestaurantController(form1);
            CinemaController cinemaController = new CinemaController(form1);
            Application.Run(form1);
        }
    }
}
