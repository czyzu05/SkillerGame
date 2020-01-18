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
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }

        }


        private MenuPageVM VMMenuPage { get; set; }

        private StartPageVM VMStartPage { get; set; }

        private FirstLevelVM VMFirstLevel { get; set; }

        private ThirdLevelVM VMThirdLevel { get; set; }

        // public Action<object> VM;

        /// <summary>
        /// Konstruktor który inicjuje ViewModel 
        /// </summary>
        /// <param name="vm"></param>
        public ChangePageCommand(object vm)
        {
            //MenuPageVM
            VMMenuPage = vm as MenuPageVM;

            //StartPageVM
            VMStartPage = vm as StartPageVM;

            //FirstLevelVM
            VMFirstLevel = vm as FirstLevelVM;

            //ThirdLevelVM
            VMThirdLevel = vm as ThirdLevelVM;

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




        }
    }
}
