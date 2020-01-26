using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SkillerGame
{
    /// <summary>
    /// Komenda odpowiedzialna za zmiane aktualnego Page na inny Page
    /// </summary>
    public class ChangePageCommand : ICommand
    {
        /// <summary>
        /// Event odpowiedzialny za sprawdzanie czy można wywołać metodę Execute , a dokładniej nasłuchuje czy w wyniku działania aplikacji nastąpiła zmiana wartości 
        /// zwracanej przez przez metodę CanExecute
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }

        }

        /// <summary>
        /// Properties przechowuje MenuPage ViewModel
        /// </summary>
        private MenuPageVM VMMenuPage { get; set; }

        /// <summary>
        /// Properties przechowuje Startpage ViewModel
        /// </summary>
        private StartPageVM VMStartPage { get; set; }

        /// <summary>
        /// Properties przechowuje FirstLevelPage ViewModel
        /// </summary>
        private FirstLevelVM VMFirstLevel { get; set; }

        /// <summary>
        /// Properties przechowuje ThirdLevelPage ViewModel
        /// </summary>
        private ThirdLevelVM VMThirdLevel { get; set; }



        /// <summary>
        /// Konstruktor który inicjuje aktualnie pobrany ViewModel
        /// </summary>
        /// <param name="vm">Aktualnie pobrany ViewModel</param>
        public ChangePageCommand(object vm)
        {
            if (vm is MenuPageVM)
            {
                //MenuPageVM
                VMMenuPage = vm as MenuPageVM;
            }
            else if (vm is StartPageVM)
            {
                //StartPageVM
                VMStartPage = vm as StartPageVM;
            }
            else if (vm is FirstLevelVM)
            {
                //FirstLevelVM
                VMFirstLevel = vm as FirstLevelVM;
            }
            else if (vm is ThirdLevelVM)
            {

                //ThirdLevelVM
                VMThirdLevel = vm as ThirdLevelVM;
            }
            else
                throw new ArgumentException("Parametr Komendy musi być zadeklarowanym ViewModel");


        }

        /// <summary>
        /// Metoda odpowiedzialna za sprawdzenie czy w danym czasie metoda Execute może zostać wywołana
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Metoda odpowiedzalna za zmiane danego Page na inny Page w zależności od ViewModelu który aktualnie jest obsługiwany przez UI
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {


            //Zmiana Page z StartPage na MenuPage
            if (VMStartPage != null)
                NavigateHelper.ChangePage(VMStartPage.StartPage, "MenuPage.xaml");

            //Zmiana Page z MenuPage na FirstLevelPage
            else if (VMMenuPage != null && VMMenuPage.LevelType == LevelType.FirstLevel)
                NavigateHelper.ChangePage(VMMenuPage.MenuPage, "FirstLevel.xaml");

            //Zmiana Page z MenuPage na SecondLevelPage
            else if (VMMenuPage != null && VMMenuPage.LevelType == LevelType.SecondLevel)
                NavigateHelper.ChangePage(VMMenuPage.MenuPage, "SecondLevel.xaml");

            //Zmiana Page z MenuPage na ThirdLevelPage
            else if (VMMenuPage != null && VMMenuPage.LevelType == LevelType.ThirdLevel)
                NavigateHelper.ChangePage(VMMenuPage.MenuPage, "ThirdLevel.xaml");

            //Zmiana Page z FirstLevelPage na MenuPage
            else if (VMFirstLevel != null)
                NavigateHelper.ChangePage(VMFirstLevel.FirstLevelPage, "MenuPage.xaml");

            //Zmiana Page z ThirdLevelPage na MenuPage
            else if (VMThirdLevel != null)
            {
                VMThirdLevel.Timer.Stop();
                NavigateHelper.ChangePage(VMThirdLevel.ThirdLevelPage, "MenuPage.xaml");
            }
            else
                throw new ArgumentOutOfRangeException("Nie zdefiniowano zmiany Page dla tego przypadku , niezdefiniowany ViewModel");




        }
    }
}
