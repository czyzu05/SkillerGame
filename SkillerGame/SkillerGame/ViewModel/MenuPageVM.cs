using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillerGame
{
    public class MenuPageVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MenuPage MenuPage { get; set; }

        public string CurrentPage { get; set; } = "Poziom 1";

        public LevelType LevelType { get; set; }

        public ChangePageCommand ChangePageCommand { get; set; }

        public ChangeCurrentLevelCommand ChangeCurrentLevelCommand { get; set; }

        public MenuPageVM()
        {
            LevelType = LevelType.FirstLevel;


            ChangeCurrentLevelCommand = new ChangeCurrentLevelCommand();

        }


        public MenuPageVM(MenuPage menuPage)
        {


            MenuPage = menuPage;


            ChangePageCommand = new ChangePageCommand(this);
        }




        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
