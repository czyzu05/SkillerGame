using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SkillerGame
{
    /// <summary>
    /// Komenda odpowiedzialna za sprawdzenie czy kliknięto poprawny przycisk w celu kontynuacji gry lub nie
    /// </summary>
    public class CheckNumberCommand : ICommand
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
        /// Properties przechowuje ThirdLevelPage ViewModel
        /// </summary>
        private ThirdLevelVM VMThirdLevel { get; set; }

        /// <summary>
        /// Konstruktor który incijuje ThirdLevelViewModel 
        /// </summary>
        /// <param name="vm"></param>
        public CheckNumberCommand(ThirdLevelVM vm)
        {
            VMThirdLevel = vm;
        }
        /// <summary>
        ///  Metoda odpowiedzialna za sprawdzenie czy w danym czasie metoda Execute może zostać wywołana
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }
        /// <summary>
        /// Metoda która pobiera z View aktualnie naciśnięty przycisk po czym przekazuje go do wywołanej metody która sprawdza , czy naciśnięto poprawny przycisk
        /// </summary>
        /// <param name="parameter">Przycisk odpowiedzialny za działanie gry pobrany z ThirdLevelPage</param>
        public void Execute(object parameter)
        {
            try
            {
                var button = parameter as Button;

                VMThirdLevel.CheckNumber(button);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show($"Błąd:Argument musi być typu Button");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
