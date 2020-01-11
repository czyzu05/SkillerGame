using SkillerGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClassLibrary
{
    /// <summary>
    /// Komenda odpowiedzialna za zmiane aktualnie wybranego Poziomu w Menu na inny Poziom
    /// </summary>
    public class ChangeCurrentLevelCommand : ICommand
    {
        /// <summary>
        /// Event odpowiedzialny sprawdzanie czy można wywołać metodę Execute
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }

        }


        private MenuPageVM VMMenuPage { get; }
        

        /// <summary>
        /// Konstruktor który inicjuje pobrany z ViewModel MenuPageVM 
        /// </summary>
        /// <param name="vm"></param>
        public ChangeCurrentLevelCommand(MenuPageVM vm)
        {

            VMMenuPage = vm;

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
        /// Metoda odpowiedzialna wywołuje metodę ChangeCurrentLevel która odpowiada za zmiane wartości Properties CurrentPage i LevelType 
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {

            NavigateHelper.ChangeCurrentLevel(VMMenuPage);


        }
    }
}
