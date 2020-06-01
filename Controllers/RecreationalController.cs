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
    public class RecreationalController
    {
        List<Recreational> recreationals = new List<Recreational>();
        Form1 form;

        public RecreationalController(Form form)
        {
            this.form = form as Form1;
            this.form.CreatRecreatinal += OncreatRecreational;
            this.form.GotRecreational += Onshowinfo;
        }
        public void OncreatRecreational(object sender, CreatRecreationalEventArgs e)
        {

            recreationals.Add(new Recreational(e.OnwerNameText, e.IdText, e.AttentionHour1Text));
            MessageBox.Show("Local Recreacional Agregado");
       }

        public bool OnveryfyexistCinema(object sender, VerifyLocalExistEventArgs e)
        {
            foreach (Recreational cinema in recreationals)
            {
                if (cinema.OnwerName == e.OnwerNameText)
                {
                    return true;
                }
            }
            return false;
        }
        public List<Recreational> Onshowinfo(object sender, GetRecreationalEventArgs e)
        {
            return recreationals;
        }
    }
}
