using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ListViewDU.Enums;
using ListViewDU.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;

namespace ListViewDU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public class PageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string myName;
        public string Name
        {
            get { return myName; }
            set
            {
                myName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }
        private int myAge;
        public int Age
        {
            get { return myAge; }
            set
            {
                myAge = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age"));
            }
        }
        private string mySpecies;
        public string Species
        {
            get { return mySpecies; }
            set
            {
                mySpecies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Species"));
            }
        }

        public PageViewModel(Telesa tl)
        {
            Name = tl.Name;
            Age = tl.Age;
            Species = tl.Species;
        }

        public Telesa ToTelesa()
        {
            Telesa clovek = new Telesa { Name = this.Name, Species = this.Species, Age = this.Age };
            return clovek;
        }
    }
    public partial class ObjectPage : ContentPage
    {
        ObservableCollection<Telesa> cCollection;
        public ObjectPage(ObservableCollection<Telesa> telesas)
        {
            InitializeComponent();
            LoadValuesToPicker();
            cCollection = telesas;
        }

        public ObjectPage(Telesa tl, ObservableCollection<Telesa> telesas)
        {
            InitializeComponent();
            LoadValuesToPicker();
            PageViewModel pgm = new PageViewModel(tl);
            nameTxt.Text = pgm.Name;
            ageTxt.Text = pgm.Age.ToString();
            typeObject.SelectedItem = pgm.Species;
            cCollection = telesas;
        }

        private void Submit_Clicked(object sender, EventArgs e)
        {
            cCollection.Add(new Telesa { Name = nameTxt.Text, Age = Convert.ToInt32(ageTxt.Text), Species = typeObject.SelectedItem.ToString() });
            Application.Current.MainPage.Navigation.PopAsync();
        }

        public void LoadValuesToPicker()
        {
            for (int i = 0; i < Enum.GetValues(typeof(SpaceSpecies)).Length; i++)
            {
                typeObject.Items.Add(Enum.GetName(typeof(SpaceSpecies), i));
            }
        }
    }
}