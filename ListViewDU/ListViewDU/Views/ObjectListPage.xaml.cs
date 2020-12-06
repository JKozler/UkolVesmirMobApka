using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using ListViewDU.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewDU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObjectListPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ObjectListPage()
        {
            InitializeComponent();
            CurrentObjects telesa = new CurrentObjects();
            BindingContext = telesa;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            Page p = new ObjectPage((((ListView)sender).SelectedItem) as Telesa, (BindingContext as CurrentObjects).AllObjects);
            NavigationPage np = new NavigationPage(p);
            await Application.Current.MainPage.Navigation.PushAsync(np);

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
