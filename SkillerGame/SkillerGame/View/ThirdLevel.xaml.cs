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
    /// Logika interakcji dla klasy ThirdLevel.xaml
    /// </summary>
    public partial class ThirdLevel : Page
    {
        public ThirdLevel()
        {
            InitializeComponent();
            CodeBehindBinding();
        }

        /// <summary>
        /// Metoda odpowiedzialna za code behind Binding 
        /// </summary>
        public void CodeBehindBinding()
        {
            //Tworzenie instancji ViewModel w codebehind zamiast w XAMLU
            ThirdLevelVM vm = new ThirdLevelVM(this);

            // zrobienie Bindingu w CodeBehind
            Binding binding = new Binding("ChangePageCommand");
            binding.Source = vm;
            menuButton.SetBinding(Button.CommandProperty, binding);


        }

    }
}
