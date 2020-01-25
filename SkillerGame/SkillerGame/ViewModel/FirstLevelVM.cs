using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

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
        /// Aktualny stan gry
        /// </summary>
        
        private int CurrentState { get; set; }

        private int currentSecond;

        /// <summary>
        /// Aktualna liczba sekund
        /// </summary>

        public int CurrentSecond
        {
            get { return currentSecond; }
            set
            {
                currentSecond = value;
                OnPropertyChanged("CurrentSecond");
            }
        }

        /// <summary>
        /// Aktualny stan gry
        /// </summary>

       // private FirstLevelStateType FirstLevelStateType { get; set; }

        /// <summary>
        /// Properties przechowuje Komęde do zmiany Page
        /// </summary>
        public ChangePageCommand ChangePageCommand { get; }



        /// <summary>
        /// Konstruktor który inicjuje pobrany z View FirstLevel oraz Komende odpowiedzialną za zmiane aktualnego Page
        /// </summary>
        /// <param name="firstLevelPage">FirstLevelPage pobrany z View</param>
        public FirstLevelVM(FirstLevel firstLevelPage)
        {
            

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
