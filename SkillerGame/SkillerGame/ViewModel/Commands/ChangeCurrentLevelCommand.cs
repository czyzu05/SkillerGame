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
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }

        }

        public MenuPageVM MenuPage { get; set; }

        public ChangeCurrentLevelCommand()
        {



        }

        public bool CanExecute(object parameter)
        {
            return false;
        }

        public void Execute(object parameter)
        {
            //KOD

        }
    }
}
