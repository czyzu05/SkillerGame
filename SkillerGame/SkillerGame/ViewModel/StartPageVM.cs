using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillerGame
{
    public class StartPageVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;



        public StartPage StartPage { get; set; }



        public ChangePageCommand ChangePageCommand { get; set; }




        public StartPageVM(StartPage startPage)
        {
            StartPage = startPage;


            ChangePageCommand = new ChangePageCommand(this);
        }

    }
}
