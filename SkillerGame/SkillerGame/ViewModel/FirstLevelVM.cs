using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillerGame
{
    public class FirstLevelVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public FirstLevel FirstLevelPage { get; set; }

        public LevelType levelType { get; set; }


        public ChangePageCommand ChangePageCommand { get; set; }




        public FirstLevelVM(FirstLevel firstLevelPage)
        {
            levelType = LevelType.FirstLevel;

            FirstLevelPage = firstLevelPage;


            ChangePageCommand = new ChangePageCommand(this);
        }







        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
