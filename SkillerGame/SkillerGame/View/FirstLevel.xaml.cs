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
        /// <summary>
        /// Standardowy Konstruktor inicjujący komponenty z xamla i inicjujący Binding
        /// </summary>
        public FirstLevel()
        {
            InitializeComponent();
            CodeBehindBinding();

            MessageBox.Show("Znajdź i kliknij na liczbę 1");
        }

        /// <summary>
        /// Metoda odpowiedzialna za code behind Binding 
        /// </summary>
        public void CodeBehindBinding()
        {
            //Tworzenie instancji ViewModel w codebehind zamiast w XAMLU
            FirstLevelVM vm = new FirstLevelVM(this);

            // zrobienie Bindingu w CodeBehind
            Binding binding = new Binding("ChangePageCommand");
            binding.Source = vm;
            menuButton.SetBinding(Button.CommandProperty, binding);


            Binding binding2 = new Binding("CurrentSecond");
            binding2.Source = vm;
            SecondsInfo.SetBinding(TextBlock.TextProperty, binding2);



            //1 wiersz

            Binding bindingButton1 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton1);

            Binding bindingButton2 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton2);

            Binding bindingButton3 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton3);

            Binding bindingButton4 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton4);

            Binding bindingButton5 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton5);

            Binding bindingButton6 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton6);

            Binding bindingButton7 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton7);

            //2 wiersz
            Binding bindingButton8 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton8);

            Binding bindingButton9 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton9);

            Binding bindingButton10 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton10);

            Binding bindingButton11 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton11);

            Binding bindingButton12 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton12);

            Binding bindingButton13 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton13);

            Binding bindingButton14 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton14);

            //3 wiersz
            Binding bindingButton15= new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton15);

            Binding bindingButton16 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton16);

            Binding bindingButton17 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton17);

            Binding bindingButton18 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton18);

            Binding bindingButton19 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton19);

            Binding bindingButton20 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton20);

            Binding bindingButton21 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton21);

            //4 wiersz

            Binding bindingButton22 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton22);

            Binding bindingButton23 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton23);

            Binding bindingButton24 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton24);

            Binding bindingButton25 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton25);

            Binding bindingButton26 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton26);

            Binding bindingButton27 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton27);

            Binding bindingButton28 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton28);

            //5 wiersz

            Binding bindingButton29 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton29);

            Binding bindingButton30 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton30);

            Binding bindingButton31 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton31);

            Binding bindingButton32 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton32);

            Binding bindingButton33 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton33);

            Binding bindingButton34 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton34);

            Binding bindingButton35 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton35);

            //6 wiersz

            Binding bindingButton36 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton36);

            Binding bindingButton37 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton37);

            Binding bindingButton38 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton38);

            Binding bindingButton39 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton39);

            Binding bindingButton40 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton40);

            Binding bindingButton41 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton41);

            Binding bindingButton42 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton42);

            //7 wiersz

            Binding bindingButton43 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton43);

            Binding bindingButton44 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton44);

            Binding bindingButton45 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton45);

            Binding bindingButton46 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton46);

            Binding bindingButton47 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton47);

            Binding bindingButton48 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton48);

            Binding bindingButton49 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton49);

            //8 wiersz

            Binding bindingButton50 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton50);

            Binding bindingButton51 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton51);

            Binding bindingButton52 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton52);

            Binding bindingButton53 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton53);

            Binding bindingButton54 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton54);

            Binding bindingButton55 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton55);

            Binding bindingButton56 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton56);

            //9 wiersz

            Binding bindingButton57 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton57);

            Binding bindingButton58 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton58);

            Binding bindingButton59 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton59);

            Binding bindingButton60 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton60);

            Binding bindingButton61 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton61);

            Binding bindingButton62 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton62);

            Binding bindingButton63 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton63);

            //10 wiersz

            Binding bindingButton64 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton64);

            Binding bindingButton65 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton65);

            Binding bindingButton66 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton66);

            Binding bindingButton67 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton67);

            Binding bindingButton68 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton68);

            Binding bindingButton69 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton69);

            Binding bindingButton70 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton70);

            //11 wiersz

            Binding bindingButton71 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton71);

            Binding bindingButton72 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton72);

            Binding bindingButton73 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton73);

            Binding bindingButton74 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton74);

            Binding bindingButton75 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton75);

            Binding bindingButton76 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton76);

            Binding bindingButton77 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton77);

            //12 wiersz

            Binding bindingButton78 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton78);

            Binding bindingButton79 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton79);

            Binding bindingButton80 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton80);

            Binding bindingButton81 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton81);

            Binding bindingButton82 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton82);

            Binding bindingButton83 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton83);

            Binding bindingButton84 = new Binding("CheckNumberCommand");
            bindingButton1.Source = vm;
            button1.SetBinding(Button.CommandProperty, bindingButton84);





        }



    }
}
