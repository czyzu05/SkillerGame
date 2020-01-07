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

//TO DO List:Dawid
//1. Zmiana Page przy uzyciu Command nie Eventu Click /DONE
// 1.1 Pobawić się EventHandler CanExecuteChanged w ChangePageCommand
// 1.2 Poszukać w necie info o przkazywaniu argumentu typu DependencyObject do konstruktora ViewModel
// 1.3 Zastanowic sie nad wprowadzeniem biblioteki MVVM Light ? dzieki czemu bede mogl skorzystac z klasy Messanger aby moc przekazac argument do konstruktora ViewModel
// 1.4 Mozna zrobic tak ze cialo funkji ChangePage bedzie sie znajdiwalo w NavigateHelper nie w ViewModels , zas w Exectue bedzie Swiotch ktory bedzie wywolywal Funkcje ChangePage i w Case bedzie okreslone
// typy ViewModel np case 1 MenuPageVm , case 2 FirstLevelVM
//2. Dodanie Buttona w FirstLevel do zmany Page na MenuPage /DONE
//3. w MenuPage dodać zmiane Leveli (2 i 3 Level) 
//  3.1 Sprobowac zrobic cos takiego ze gdy klikne przcisk zmiany w MenuPage to wtedy Poziom 1 zmienia sie na Poziom 2 i zrobic konwerter ktory pobiera sobie Value Poziom 2 i nastepnie w jakis sposob Command
//to obsluguje ze zmienia ChangePage(..., FirstLevel) na ChangePage(..., SecondLevel)
//  3.2 Zrobic cos takiego ze np Poziom 1 zostanie skonwertowany na FirstLevel.xaml Poziom 2 na SecondLevel.xaml itd..
//  3.3 VisualTreeHelper moze sie przydac 




namespace SkillerGame
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new StartPage();
            
        }

        /*
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //zmiana Z MainWindow na MenuPage
            //MenuPage menuPage = new MenuPage();
            // this.Content = menuPage;
            //Main.Navigate(typeof(MenuPage));
            Main.Content = new MenuPage();
            
        }
        */
    }
}
