using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ListViewDU.Enums;

namespace ListViewDU.Models
{
    public class CurrentObjects
    {
        public ObservableCollection<Telesa> AllObjects { get; set; }
        public CurrentObjects()
        {
            AllObjects = new ObservableCollection<Telesa>();
            AllObjects.Add(new Telesa { Name = "Merkur", Species = Enum.GetName(typeof(SpaceSpecies), 0), Age = 50 });
            AllObjects.Add(new Telesa { Name = "Venuse", Species = Enum.GetName(typeof(SpaceSpecies), 0), Age = 70 });
            AllObjects.Add(new Telesa { Name = "Zeme", Species = Enum.GetName(typeof(SpaceSpecies), 0), Age = 90 });
            AllObjects.Add(new Telesa { Name = "Mars", Species = Enum.GetName(typeof(SpaceSpecies), 0), Age = 10 });
            AllObjects.Add(new Telesa { Name = "Jupiter", Species = Enum.GetName(typeof(SpaceSpecies), 0), Age = 20 });
            AllObjects.Add(new Telesa { Name = "Saturn", Species = Enum.GetName(typeof(SpaceSpecies), 0), Age = 70 });
            AllObjects.Add(new Telesa { Name = "Uran", Species = Enum.GetName(typeof(SpaceSpecies), 0), Age = 30 });
            AllObjects.Add(new Telesa { Name = "Neptun", Species = Enum.GetName(typeof(SpaceSpecies), 0), Age = 40 });
        }
    }
}
