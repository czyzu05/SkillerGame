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


        private  string currentPage;

        public  string CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;
                OnPropertyChanged(nameof(CurrentPage));
            }
        }


        private  LevelType levelType;

        public  LevelType LevelType
        {
            get { return levelType; }
            set
            {
                levelType = value;
                OnPropertyChanged(nameof(LevelType));
            }
        }


        public ChangePageCommand ChangePageCommand { get; set; }

        public ChangeCurrentLevelCommand ChangeCurrentLevelCommand { get; set; }

        


        public MenuPageVM(MenuPage menuPage)
        {
            LevelType = LevelType.FirstLevel;
            CurrentPage = "Poziom 1";
            MenuPage = menuPage;


            ChangePageCommand = new ChangePageCommand(this);

            ChangeCurrentLevelCommand = new ChangeCurrentLevelCommand(this);
        }




        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
