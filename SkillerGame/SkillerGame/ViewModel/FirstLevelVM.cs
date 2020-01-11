using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillerGame
{

    /// <summary>
    /// ViewModel dla Pierwszej gry 
    /// </summary>
    public class FirstLevelVM : INotifyPropertyChanged
    {

        /// <summary>
        /// Standardowy event z interfejsu INotifyPropertyChanged 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Propierties która ma za zadanie przechowywać Page pobrany z View 
        /// </summary>
        public FirstLevel FirstLevelPage { get; }

        /// <summary>
        /// Properties przechowuje typ poziomu
        /// </summary>
        public LevelType levelType { get; }

        /// <summary>
        /// Properties przechowuje Komęde do zmiany Page
        /// </summary>
        public ChangePageCommand ChangePageCommand { get;  }



        /// <summary>
        /// Konstruktor który inicjuje pobrany z View FirstLevel oraz kilka zmiennych
        /// </summary>
        /// <param name="firstLevelPage">FirstLevelPage pobrany z View</param>
        public FirstLevelVM(FirstLevel firstLevelPage)
        {
            levelType = LevelType.FirstLevel;

            FirstLevelPage = firstLevelPage;


            ChangePageCommand = new ChangePageCommand(this);
        }






        /// <summary>
        /// Metoda która po wywołaniu w setterze zbindowanej Properties sprawia że każda zmiana danej Propeties w ViewModel zmienia UI
        /// </summary>
        /// <param name="propertyName"></param>
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
