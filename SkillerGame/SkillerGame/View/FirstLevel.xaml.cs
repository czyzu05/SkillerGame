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

namespace SkillerGame
{
    /// <summary>
    /// Logika interakcji dla klasy FirstLevel.xaml
    /// </summary>
    public partial class FirstLevel : Page
    {
        public FirstLevel()
        {
            InitializeComponent();
            Awake();

            MessageBox.Show("Znajdź i kliknij na liczbę 1");
        }

        public void Awake()
        {
            //Tworzenie instancji ViewModel w codebehind zamiast w XAMLU
            FirstLevelVM vm = new FirstLevelVM(this);

            // zrobienie Bindingu w CodeBehind
            Binding binding = new Binding("ChangePageCommand");
            binding.Source = vm;
            menuButton.SetBinding(Button.CommandProperty, binding);
        }

        public void StartTimer(object o, RoutedEventArgs sender)
        {
            System.Windows.Threading.DispatcherTimer myDispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            myDispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            myDispatcherTimer.Tick += new EventHandler(Each_Tick);
            myDispatcherTimer.Start();
        }

        // A variable to count.
        int i = 0;

        // Fires every 1000 miliseconds while the DispatcherTimer is active.
        public void Each_Tick(object o, EventArgs sender)
        {
            time.Text = "Count up: " + i++.ToString();
            if (i > 15) outOfTime();
        }

        private void generateNumbersWithOneOther(object sender, RoutedEventArgs e)
        {
            int position = Convert.ToInt32(((Button)sender).Tag);
            Button newbtn = new Button();
            Random rnd = new Random();
            int number = rnd.Next(1, 85);
            if (position == number)
                newbtn.Content = 1;
            else
                newbtn.Content = 7;

            ((Button)sender).Content = newbtn.Content;

        }

        private void checkNumber(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int choose = Convert.ToInt32((btn.Content));
            if (choose == 1)
            {
                MessageBox.Show("Wygrałeś");
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                wrongNumber();
        }

        private void wrongNumber()
        {
            MessageBox.Show("Zła liczba, przegrałeś :(");
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void outOfTime()
        {
            MessageBox.Show("Upłynął czas, przegrałeś :(");
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

    }
}
