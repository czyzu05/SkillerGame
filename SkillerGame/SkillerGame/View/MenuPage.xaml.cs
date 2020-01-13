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
    /// Logika interakcji dla klasy MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {

        /// <summary>
        /// Standardowy Konstruktor inicjujący komponenty z xamla i inicjujący Binding
        /// </summary>
        public MenuPage()
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
            MenuPageVM vm = new MenuPageVM(this);

            // zrobienie Bindingu w CodeBehind
            Binding binding = new Binding("ChangePageCommand");
            binding.Source = vm;
            startButton.SetBinding(Button.CommandProperty, binding);


            //Bindowanie przycisku Next w CodeBehind
            Binding binding2 = new Binding("ChangeCurrentLevelCommand");
            binding2.Source = vm;
            forwardButton.SetBinding(Button.CommandProperty, binding2);
            //CommandParameter dla  przycisku Next
            //Binding buttonTypeBinding = new Binding("ButtonType");
            //StaticResourceExtension staticResource = new StaticResourceExtension(ButtonType.NextButton);

            
            


            //Bindowanie przycisku Cofinij w CodeBehind
            Binding binding3 = new Binding("ChangeCurrentLevelCommand");
            binding3.Source = vm;
            backWardButton.SetBinding(Button.CommandProperty, binding3);
            //CommandParameter dla  przycisku Cofinij
            //Binding buttonTypeBinding2 = new Binding("ButtonType");
            //backWardButton.SetBinding(Button.CommandParameterProperty, buttonTypeBinding2);


            //Bindowanie TextBlocka odpowiedzalnego za wyswietlanie informacjii o aktualnym poziomie
            Binding binding4 = new Binding("CurrentPage");
            binding4.Source = vm;
            levelInfo.SetBinding(TextBlock.TextProperty, binding4);


            //Bindowanie Property Source dla Image odpowiedzalanego za wyswietlanie image dla kazdego poziomu
            Binding binding5 = new Binding("CurrentImage");
            binding5.Source = vm;
            imageLevel.SetBinding(Image.SourceProperty, binding5);





        }

        

        
    }
}
