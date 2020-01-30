using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using SkillerGame.ViewModels;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SkillerGame
{
    /// <summary>
    /// Logika interakcji dla klasy SecondLevel.xaml
    /// </summary>
    public partial class SecondLevel : Page
    {
        public SecondLevel()
        {
            InitializeComponent();
        }


        private void Play_Clicked(object sender, RoutedEventArgs e)
        {
            var startMenu = DataContext as StartMenuViewModel;
            startMenu.StartNewGame(categoryBox.SelectedIndex);
        }
    }
}
