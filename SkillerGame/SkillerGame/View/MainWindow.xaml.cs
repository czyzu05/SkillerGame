using System;
using System.Collections.Generic;
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

//To DO list :Dawid
//1. Aby zrobic sprawdzenie czy nacisnieto poprawwny Buttona , można zrrobic porównanie Listy numerów , z lista buttonów ale property Content(czyli np: buttons[i].Content)
//1.1 i to bedzie metoda w ViewModel(albo w helpers), ZAŚ za zmiane stanu gry(w sensie ze jak kilkne poprawnie na np button3 ktorego Content = "1" to wtedy porgram bedzie 
//wymagal aby kilknac button z Content = "2" a potem kolejny z "3" itd.) bedzie odpowiadać inna Metoda(lub Command)
//1.2 Mozna zmienic to ze te buttony jako COmmand Parameter przesylaja Caly obiekt Buttona zamiast tylko Property Content
//2 Aby zrobic to ze np Poziom [1](LevelType.FirstLevel) , Poziom [2](LevelType.SecondLevel) to wystarczy zrobic 2 TextBlocki w StackPanelu , 1 TextBlock odpowiada za 
//wyswietlanie "Poziom" a drugi bedzie Zbindowany do Properties , zas StacPanel bedzie mial ustawione Orientation na Horizontal
//3 Mozna stworzyc ThirdLevelDataProperty w ViewModelu 
//4 Zrobic cos takiego , stworzyc ENUM z value: OutOfTime , WrongNumber , GoodNumber , Koniec , nastepnie stpwrzyc 1 metode ktora bedzie rozpatrzala te 4 ENUMY , te ENYM Value beda ustawiane 
// w metoddzie CheckNumber



namespace SkillerGame
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// Standardowy Konstruktor inicjujący komponenty z xamla i ustawiający Content domyślny Frame na StartPage
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new StartPage();
            
        }

        
    }
}
