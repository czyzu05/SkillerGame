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

        public MenuPageVM VMMenuPage { get; set; }

        public StartPageVM VMStartPage { get; set; }

        public FirstLevelVM VMFirstLevel { get; set; }

        // public Action<object> VM;

        public ChangePageCommand(object vm)
        {
            //MenuPageVM
            VMMenuPage = vm as MenuPageVM;

            //StartPageVM
            VMStartPage = vm as StartPageVM;

            //FirstLevelVM
            VMFirstLevel = vm as FirstLevelVM;

        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {


            //VM.ChangePage(VM.MenuPage, "FirstLevel.xaml");
            if (VMStartPage != null)
                NavigateHelper.ChangePage(VMStartPage.StartPage, "MenuPage.xaml");

            if (VMMenuPage != null)
                NavigateHelper.ChangePage(VMMenuPage.MenuPage, "FirstLevel.xaml");

            if (VMFirstLevel != null)
                NavigateHelper.ChangePage(VMFirstLevel.FirstLevelPage, "MenuPage.xaml");


        }
    }
}
