using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            Binding binding2 = new Binding("CurrentSecond");
            binding2.Source = vm;
            SecondsInfo.SetBinding(TextBlock.TextProperty, binding2);
         

            //1 wiersz

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton1 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton1);

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton2 = new Binding("CheckNumberCommand");
            bindingButton2.Source = vm;
            button2.SetBinding(Button.CommandProperty, bindingButton2);

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton3 = new Binding("CheckNumberCommand");
            bindingButton3.Source = vm;
            button3.SetBinding(Button.CommandProperty, bindingButton3);

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton4 = new Binding("CheckNumberCommand");
            bindingButton4.Source = vm;
            button4.SetBinding(Button.CommandProperty, bindingButton4);

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton5 = new Binding("CheckNumberCommand");
            bindingButton5.Source = vm;
            button5.SetBinding(Button.CommandProperty, bindingButton5);



            //2 wiersz 

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton6 = new Binding("CheckNumberCommand");
            bindingButton6.Source = vm;
            button6.SetBinding(Button.CommandProperty, bindingButton6);

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton7 = new Binding("CheckNumberCommand");
            bindingButton7.Source = vm;
            button7.SetBinding(Button.CommandProperty, bindingButton7);

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton8 = new Binding("CheckNumberCommand");
            bindingButton8.Source = vm;
            button8.SetBinding(Button.CommandProperty, bindingButton8);

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton9 = new Binding("CheckNumberCommand");
            bindingButton9.Source = vm;
            button9.SetBinding(Button.CommandProperty, bindingButton9);

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton10 = new Binding("CheckNumberCommand");
            bindingButton10.Source = vm;
            button10.SetBinding(Button.CommandProperty, bindingButton10);


            //3 wiersz 


            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton11 = new Binding("CheckNumberCommand");
            bindingButton11.Source = vm;
            button11.SetBinding(Button.CommandProperty, bindingButton11);

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton12 = new Binding("CheckNumberCommand");
            bindingButton12.Source = vm;
            button12.SetBinding(Button.CommandProperty, bindingButton12);

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton13 = new Binding("CheckNumberCommand");
            bindingButton13.Source = vm;
            button13.SetBinding(Button.CommandProperty, bindingButton13);

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton14 = new Binding("CheckNumberCommand");
            bindingButton14.Source = vm;
            button14.SetBinding(Button.CommandProperty, bindingButton14);

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton15 = new Binding("CheckNumberCommand");
            bindingButton15.Source = vm;
            button15.SetBinding(Button.CommandProperty, bindingButton15);


            //4 wiersz


            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton16 = new Binding("CheckNumberCommand");
            bindingButton16.Source = vm;
            button16.SetBinding(Button.CommandProperty, bindingButton16);

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton17 = new Binding("CheckNumberCommand");
            bindingButton17.Source = vm;
            button17.SetBinding(Button.CommandProperty, bindingButton17);

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton18 = new Binding("CheckNumberCommand");
            bindingButton18.Source = vm;
            button18.SetBinding(Button.CommandProperty, bindingButton18);

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton19 = new Binding("CheckNumberCommand");
            bindingButton19.Source = vm;
            button19.SetBinding(Button.CommandProperty, bindingButton19);

            //Bindowanie Buttona1 do Command ChangeStateOfThirdLevelCommand
            Binding bindingButton20 = new Binding("CheckNumberCommand");
            bindingButton20.Source = vm;
            button20.SetBinding(Button.CommandProperty, bindingButton20);






        }
        

       
    }
}
