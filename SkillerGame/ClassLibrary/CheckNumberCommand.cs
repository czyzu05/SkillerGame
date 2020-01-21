using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;


namespace ClassLibrary
{
    public class CheckNumberCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public ThirdLevelVM VMThirdLevel { get; set; }

        public CheckNumberCommand(ThirdLevelVM vm)
        {
            VMThirdLevel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var button = parameter as Button;

            VMThirdLevel.CheckNumber(button);
        }
    }
}
