using System.Collections.ObjectModel;

namespace SmartHomeUI;

public sealed partial class MainPage : Page
{
    public readonly ObservableCollection<People> people;
    public readonly ObservableCollection<Devices> devices;

    public void GenerateInfo()
    {
        // People list
        people.Add(new People() { Name = "Aisha Mitrovikov", Picture = "icon.png" });
        people.Add(new People() { Name = "Jimmy Cameron", Picture = "icon.png" });
        people.Add(new People() { Name = "Janine Sirman", Picture = "icon.png" });

        devices.Add(new Devices() { Name = "Wi-Fi Lamp Smooth", isAvailable = true });
        devices.Add(new Devices() { Name = "Safe Door Smart Lock", isAvailable = true });
        devices.Add(new Devices() { Name = "Smart TV", isAvailable = false });

    }

        public MainPage()
    {
        this.InitializeComponent();
        people = new ObservableCollection<People>();
        devices = new ObservableCollection<Devices>(); 
        GenerateInfo();
    } 
    
}
