using Lab8.EventsArgs;
using Lab8.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public event EventHandler<CreatCinemaEventArgs> CreatCine;
        public event EventHandler<CreatRestaurantEventArgs> CreatRestaurant;
        public event EventHandler<CreatRecreationalEventArgs> CreatRecreatinal;
        public event EventHandler<CreatStoreEventArgs> CreatStore;
        public delegate List<Restaurant> GetRestaurantEventHandler(object source, GetRestaurantEventsArgs args);
        public event GetRestaurantEventHandler gotRestaurant;
        public delegate List<Recreational> GetRecreationalEventHandler(object source, GetRecreationalEventArgs args);
        public event GetRecreationalEventHandler GotRecreational;
        public delegate List<Cinema> GetCinemaEventHandler(object source, GetCinemaEventsArgs args);
        public event GetCinemaEventHandler gotCinema;
        public delegate List<Store> GetStoreEventHandler(object source, GetStoreEventsArgs args);
        public event GetStoreEventHandler gotStore;
        List<string> idList = new List<string>() { "00000000" };

        public Form1()
        {
            InitializeComponent();
            VerLocalesPanel.Visible = false;
           

        }

        private void CrearLocalButton_Click(object sender, EventArgs e)
        {
            bool idnotexist = true;
            string exclusiveTables = "";
            string textbox = "";
            string attentionHour;
            string ownerName = NombreDueñoInput.Text;
            string openHouse = HoraAperturaInput.Text;
            string closehouse = HoraCierreInput.Text;
            string id = IdTextbox.Text;
            if (id.Length < 8)
            {
                MessageBox.Show("ID debe tener 8 caracteres");
                idnotexist = false;
            }
            else
            {
                foreach (string i in idList)
                {
                    if (id == i)
                    {
                        MessageBox.Show("Este Id ya existe");
                        idnotexist = false;
                    }
                }
            }
            if (idnotexist)
            {
                idList.Add(id);
            }
            attentionHour = openHouse + "-" + closehouse;
            string localType = TipodelocalcomboBox.SelectedItem.ToString();
            if (localType == "Restaurante")
            {
                exclusiveTables = MesasExclusivasComboBox.SelectedItem.ToString();
            }
            if (localType == "Cine" || localType == "Tienda")
            {
                textbox = textBoxCrearlocal.Text;
            }
            if (ownerName=="" || openHouse==""||closehouse==""|| localType=="---Selecione un tipo---"|| id=="")
            {
                MessageBox.Show("Debe rellenar todos los campos");
            }
            else
            {
                if (idnotexist)
                {

                    if (localType == "Cine")
                    {
                        textBoxCrearlocal.ResetText();
                        DefaultLabel.Text = "Numero de salas";
                        DefaultLabel.Visible = true;
                        textBoxCrearlocal.Visible = true;
                        MesasExclusivasComboBox.Visible = false;
                        if (CreatCine != null)
                        {
                            CreatCine(this, new CreatCinemaEventArgs() { OnwerNameText = ownerName, IdText = id, AttentionHour1Text = attentionHour, NRooms = textbox });
                        }

                    }
                    if (localType == "Restaurante")
                    {
                        DefaultLabel.Visible = false;
                        MesasExclusivasComboBox.Visible = true;
                        MesasExclusivasComboBox.SelectedIndex = 0;
                        textBoxCrearlocal.Visible = false;
                        textBoxCrearlocal.ResetText();
                        if (CreatRestaurant != null)
                        {
                            CreatRestaurant(this, new CreatRestaurantEventArgs() { OnwerNameText = ownerName, IdText = id, AttentionHour1Text = attentionHour, ExclusiveTables = exclusiveTables });
                        }



                    }
                    if (localType == "Tienda")
                    {
                        textBoxCrearlocal.ResetText();
                        DefaultLabel.Text = "Ingrse la Categoria";
                        DefaultLabel.Visible = true;
                        textBoxCrearlocal.Visible = true;
                        MesasExclusivasComboBox.Visible = false;
                        string categories = textBoxCrearlocal.Text;
                        if (CreatStore != null)
                        {
                            CreatStore(this, new CreatStoreEventArgs() { OnwerNameText = ownerName, IdText = id, AttentionHour1Text = attentionHour, CategoriesText = textbox });

                        }

                    }
                    if (localType == "Recreacional")
                    {
                        if (CreatRecreatinal != null)
                        {
                            CreatRecreatinal(this, new CreatRecreationalEventArgs() { OnwerNameText = ownerName, IdText = id, AttentionHour1Text = attentionHour });

                        }


                    }
                    NombreDueñoInput.ResetText();
                    HoraAperturaInput.ResetText();
                    HoraCierreInput.ResetText();
                    IdTextbox.ResetText();
                    textBoxCrearlocal.ResetText();
                    textBoxCrearlocal.ResetText();
                    TipodelocalcomboBox.SelectedIndex = 0;
                    VerificarLocalButton.Visible = false;
                    HoraAperturaInput.Visible = false;
                    HoraAperturaLabel.Visible = false;
                    HoraCierreInput.Visible = false;
                    HoraCierreLabel.Visible = false;
                    CrearLocalDueñoLabel.Visible = false;
                    NombreDueñoInput.Visible = false;
                    IdTextbox.Visible = false;
                    IdLabel.Visible = false;
                    MesasExclusivasComboBox.Visible = false;
                    textBoxCrearlocal.Visible = false;
                    DefaultLabel.Visible = false;

                }

            }
        }
        public string GenerateID()
        {
            string number="";
            bool idExist = true;
            while (idExist)
            {
                long i = 1;

                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }

                number = String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);
                foreach (string id in idList)
                {
                    if (id == number)
                    {
                        idExist = true;
                    }
                    else
                    {
                        idExist = false;
                    }
                    
                }
                
            }
            return number;
        }

        private void AgregarLocalButton_Click(object sender, EventArgs e)
        {
            VerLocalesPanel.Visible = false;
            RevisarLocalPanel.Visible = false;
            if (AgregarLocalPanel.Visible)
            {
                AgregarLocalPanel.Visible = false;
            }
            else
            {
                AgregarLocalPanel.Visible = true; 
            }
            NombreDueñoInput.ResetText();
            HoraAperturaInput.ResetText();
            HoraCierreInput.ResetText();
            TipodelocalcomboBox.SelectedIndex = 0;
            DefaultLabel.Visible = false;
            DefaultLabel.Visible = false;
            textBoxCrearlocal.Visible = false;
            textBoxCrearlocal.ResetText();
            IdTextbox.ResetText();
            VerificarLocalButton.Visible = false;
            HoraAperturaInput.Visible = false;
            HoraAperturaLabel.Visible = false;
            HoraCierreInput.Visible = false;
            HoraCierreLabel.Visible = false;
            CrearLocalDueñoLabel.Visible = false;
            NombreDueñoInput.Visible = false;
            IdTextbox.Visible = false;
            IdLabel.Visible = false;
            MesasExclusivasComboBox.Visible = false;
        }

        private void SeeAllLocalButton_Click(object sender, EventArgs e)
        {
            RevisarLocalPanel.Visible = false;
            AgregarLocalPanel.Visible = false;
            VerLocalesListListBox.Items.Clear();
            if (VerLocalesPanel.Visible)
            {
                VerLocalesPanel.Visible = false;
               

            }
            else
            {
                VerLocalesPanel.Visible = true;
                

            }
            if (gotRestaurant != null)
            {
                List<Restaurant> restaurants = gotRestaurant(this, new GetRestaurantEventsArgs() { });
                VerLocalesListListBox.Items.Add("Restoranes");
                foreach (Restaurant restaurant in restaurants)
                {
                    VerLocalesListListBox.Items.Add("Dueño: " + restaurant.OnwerName);
                    VerLocalesListListBox.Items.Add("Id: " + restaurant.Id);
                    VerLocalesListListBox.Items.Add("Horario Atencion: " + restaurant.AttentionHour);
                    VerLocalesListListBox.Items.Add("Mesas Exlusivas: " + restaurant.ExclusiveTables);
                    VerLocalesListListBox.Items.Add("");

                }
            }
            if (GotRecreational != null)
            {
                List<Recreational> recreationals = GotRecreational(this, new GetRecreationalEventArgs() { });
                VerLocalesListListBox.Items.Add("Locales Recreacionales");
                foreach (Recreational recreational in recreationals)
                {
                    VerLocalesListListBox.Items.Add("Dueño: " + recreational.OnwerName);
                    VerLocalesListListBox.Items.Add("Id: " + recreational.Id);
                    VerLocalesListListBox.Items.Add("Horario Atencion: " + recreational.AttentionHour);
                    VerLocalesListListBox.Items.Add("");
                }
            }
            if (gotCinema != null)
            {
                List<Cinema> cinemas = gotCinema(this, new GetCinemaEventsArgs() { });
                VerLocalesListListBox.Items.Add("Cines");
                foreach (Cinema cinema in cinemas)
                {
                    VerLocalesListListBox.Items.Add("Dueño: " + cinema.OnwerName);
                    VerLocalesListListBox.Items.Add("Id: " + cinema.Id);
                    VerLocalesListListBox.Items.Add("Horario Atencion: " + cinema.AttentionHour);
                    VerLocalesListListBox.Items.Add("Numero de salas: " + cinema.NRooms);
                    VerLocalesListListBox.Items.Add("");

                }
            }
            if (gotStore != null)
            {
                List<Store> stores = gotStore(this, new GetStoreEventsArgs() { });
                VerLocalesListListBox.Items.Add("Tiendas");
                foreach (Store store in stores)
                {
                    VerLocalesListListBox.Items.Add("Dueño: " + store.OnwerName);
                    VerLocalesListListBox.Items.Add("Id: " + store.Id);
                    VerLocalesListListBox.Items.Add("Horario Atencion: " + store.AttentionHour);
                    VerLocalesListListBox.Items.Add("Categoria: " + store.Categories);
                    VerLocalesListListBox.Items.Add("");

                }
            }
        }
    
        private void BuscarBuston_Click(object sender, EventArgs e)
        {
            bool id = false;
            string idSearch = SearchTextBox.Text;
            RevisarLocalListbox.Items.Clear();
            foreach (string i in idList)
            {
                if (idSearch == i)
                {
                    id = true;
                    
                }
                
            }
            if (id)
            {
                RevisarLocalListbox.Visible = true;
                if (gotRestaurant != null)
                {
                    List<Restaurant> restaurants = gotRestaurant(this, new GetRestaurantEventsArgs() { });
                    foreach (Restaurant restaurant in restaurants)
                    {
                        if (idSearch == restaurant.Id)
                        {
                            RevisarLocalListbox.Items.Add("Restoran Encontrado:");
                            RevisarLocalListbox.Items.Add("");
                            RevisarLocalListbox.Items.Add("Dueño: " + restaurant.OnwerName);
                            RevisarLocalListbox.Items.Add("Id: " + restaurant.Id);
                            RevisarLocalListbox.Items.Add("Horario Atencion: " + restaurant.AttentionHour);
                            RevisarLocalListbox.Items.Add("Mesas Exlusivas: " + restaurant.ExclusiveTables);
                           
                        }

                    }
                }

                if (GotRecreational != null)
                {
                    List<Recreational> recreationals = GotRecreational(this, new GetRecreationalEventArgs() { });
                    foreach (Recreational recreational in recreationals)
                    {
                        if (recreational.Id == idSearch) 
                        {
                            RevisarLocalListbox.Items.Add("Local Recreacional encontrado:");
                            RevisarLocalListbox.Items.Add("");
                            RevisarLocalListbox.Items.Add("Dueño: " + recreational.OnwerName);
                            RevisarLocalListbox.Items.Add("Id: " + recreational.Id);
                            RevisarLocalListbox.Items.Add("Horario Atencion: " + recreational.AttentionHour);
                            
                        }
                    }
                }
                if (gotCinema != null)
                {
                    List<Cinema> cinemas = gotCinema(this, new GetCinemaEventsArgs() { });
                    foreach (Cinema cinema in cinemas)
                    {
                        if (cinema.Id == idSearch)
                        {
                            RevisarLocalListbox.Items.Add("Cine encontrado");
                            RevisarLocalListbox.Items.Add("");
                            RevisarLocalListbox.Items.Add("Dueño: " + cinema.OnwerName);
                            RevisarLocalListbox.Items.Add("Id: " + cinema.Id);
                            RevisarLocalListbox.Items.Add("Horario Atencion: " + cinema.AttentionHour);
                            RevisarLocalListbox.Items.Add("Numero de salas: " + cinema.NRooms);
                            
                        }

                    }
                }
                if (gotStore != null)
                {
                    List<Store> stores = gotStore(this, new GetStoreEventsArgs() { });
                    foreach (Store store in stores)
                    {
                        if (idSearch == store.Id)
                        {
                            RevisarLocalListbox.Items.Add("Tienda encontrada:");
                            RevisarLocalListbox.Items.Add("");
                            RevisarLocalListbox.Items.Add("Dueño: " + store.OnwerName);
                            RevisarLocalListbox.Items.Add("Id: " + store.Id);
                            RevisarLocalListbox.Items.Add("Horario Atencion: " + store.AttentionHour);
                            RevisarLocalListbox.Items.Add("Categoria: " + store.Categories);
                            
                        }

                    }

                }
            }
            else
            {
                MessageBox.Show("Id no encontrado");
                SearchTextBox.ResetText();
                RevisarLocalListbox.Visible = false;
            }
        }

        private void CheckLocalButton_Click(object sender, EventArgs e)
        {
            VerLocalesPanel.Visible = false;
            AgregarLocalPanel.Visible = false;
            RevisarLocalListbox.Visible = false;
            SearchTextBox.ResetText();
            if (RevisarLocalPanel.Visible)
            {
                RevisarLocalPanel.Visible = false;
            }
            else
            {
                RevisarLocalPanel.Visible = true;
            }
            RevisarLocalListbox.Items.Clear();

        }

        private void Tipodelocal_Click(object sender, EventArgs e)
        {
            VerificarLocalButton.Visible = true;
            HoraAperturaInput.Visible = true;
            HoraAperturaLabel.Visible = true;
            HoraCierreInput.Visible = true;
            HoraCierreLabel.Visible = true;
            CrearLocalDueñoLabel.Visible = true;
            NombreDueñoInput.Visible = true;
            IdTextbox.Visible = true;
            IdLabel.Visible = true;
            NombreDueñoInput.ResetText();
            HoraAperturaInput.ResetText();
            HoraCierreInput.ResetText();
            IdTextbox.ResetText();
            textBoxCrearlocal.ResetText();
            string localType = TipodelocalcomboBox.SelectedItem.ToString();

            if (localType == "Cine")
            {
                textBoxCrearlocal.ResetText();
                DefaultLabel.Text = "Numero de salas";
                DefaultLabel.Visible = true;
                textBoxCrearlocal.Visible = true;
                MesasExclusivasComboBox.Visible = false;

            }
            if (localType == "Restaurante")
            {
                DefaultLabel.Visible = false;
                MesasExclusivasComboBox.Visible = true;
                MesasExclusivasComboBox.SelectedIndex = 0;
                textBoxCrearlocal.Visible = false;
                textBoxCrearlocal.ResetText();
  
            }
            if (localType == "Tienda")
            {
                textBoxCrearlocal.ResetText();
                DefaultLabel.Text = "Ingrse la Categoria";
                DefaultLabel.Visible = true;
                textBoxCrearlocal.Visible = true;
                MesasExclusivasComboBox.Visible = false;
            }
            if (localType == "Recreacional")
            {
                DefaultLabel.Visible = false;
                textBoxCrearlocal.Visible = false;
                MesasExclusivasComboBox.Visible = false;


            }


        }

       
    }
}
