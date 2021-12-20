using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataGrid3P
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        public ObservableCollection<Product> ListaProduktow { get; set; }
        public ObservableCollection<string> ListaMagazynow { get; set; }
        public string sciezka = "pack://application:,,,/Obrazki/";
        
        public MainWindow()
        {
            InitializeComponent();


            ListaProduktow = new ObservableCollection<Product>();
            ListaProduktow.Add(new Product("aa", "komputer", 5, "Katowice_m1",new Uri(sciezka +"IMAG2063.jpg")));
            ListaProduktow.Add(new Product("bb", "klawiatura", 50, "Katowice_m1", new Uri(sciezka + "IMAG2064.jpg")));
            ListaProduktow.Add(new Product("cc", "monitor", 10, "Katowice_m1", new Uri(sciezka + "IMAG2065.jpg")));
            DataContext = this;

            ListaMagazynow = new ObservableCollection<string>()
             {"Katowice_m1","Gliwice_m2", "Zabrze_m3" };
            mag.ItemsSource = ListaMagazynow;
            
        }
    }
}
