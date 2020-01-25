using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SkillerGame
{
    /// <summary>
    /// Komenda odpowiedzialna za zmiane aktualnie wybranego Poziomu w Menu na inny Poziom
    /// </summary>
    public class ChangeCurrentLevelCommand : ICommand
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
        private MenuPageVM VMMenuPage { get; }

        /// <summary>
        /// Konstruktor który inicjuje pobrany z ViewModel MenuPageVM 
        /// </summary>
        /// <param name="vm">ViewModel dla MenuPage</param>
        public ChangeCurrentLevelCommand(MenuPageVM vm)
        {

            VMMenuPage = vm;

        }

        /// <summary>
        /// Metoda odpowiedzialna za sprawdzenie czy w danym czasie metoda Execute może zostać wywołana
        /// </summary>
        /// <param name="parameter">Przycisk nawigacji pomiędzy dostępnymi poziomami pobrany z MenuPage</param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            var buttonType = (ButtonType)Enum.Parse(typeof(ButtonType), parameter.ToString());

            if ((VMMenuPage.LevelType == LevelType.ThirdLevel && buttonType == ButtonType.NextButton) || (VMMenuPage.LevelType == LevelType.FirstLevel && buttonType == ButtonType.PreviousButton))
                return false;

            return true;
        }

        /// <summary>
        /// Metoda odpowiedzialna wywołuje metodę ChangeCurrentLevel która odpowiada za zmiane wartości Properties CurrentPage i LevelType 
        /// </summary>
        /// <param name="parameter">Przycisk nawigacji pomiędzy dostępnymi poziomami pobrany z MenuPage</param>
        public void Execute(object parameter)
        {

            var buttonType = (ButtonType)Enum.Parse(typeof(ButtonType), parameter.ToString());

            NavigateHelper.ChangeCurrentLevel(VMMenuPage, buttonType);


        }
    }
}
