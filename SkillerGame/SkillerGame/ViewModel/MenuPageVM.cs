using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillerGame
{
    /// <summary>
    /// ViewModel dla Menu wybierania Poziomów
    /// </summary>
    public class MenuPageVM : INotifyPropertyChanged
    {

        /// <summary>
        /// Standardowy event z interfejsu INotifyPropertyChanged 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Propierties która ma za zadanie przechowywać Page z pobrany z View 
        /// </summary>
        public MenuPage MenuPage { get;  }


        private string currentImage;
        /// <summary>
        /// Properties przechowuje ścieżkę do obrazka dla aktualnie wybranego poziomu
        /// </summary>
        public string CurrentImage
        {
            get { return currentImage; }
            set
            {
                currentImage = value;
                OnPropertyChanged("CurrentImage");
            }
        }


        private  string currentPage;
        /// <summary>
        /// Properties przechowuje aktualny Page w postaci string 
        /// </summary>
        public string CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;
                OnPropertyChanged(nameof(CurrentPage));
            }
        }


        private  LevelType levelType;
        /// <summary>
        /// Properties przechowuje typ poziomu
        /// </summary>
        public LevelType LevelType
        {
            get { return levelType; }
            set
            {
                levelType = value;
                OnPropertyChanged(nameof(LevelType));
            }
        }

        /// <summary>
        /// Rodzaj przycisku do nawigacji pomiędzy różnymi poziomami w Menu Głównym
        /// </summary>
        public ButtonType ButtonType { get; set; }



        /// <summary>
        /// Properties przechowuje Komęde do zmiany Page
        /// </summary>
        public ChangePageCommand ChangePageCommand { get;  }

        /// <summary>
        /// Properties przechowuje Komęde do zmiany aktualnego Poziomu w Menu Głównym
        /// </summary>
        public ChangeCurrentLevelCommand ChangeCurrentLevelCommand { get;  }



        /// <summary>
        ///  Konstruktor który inicjuje pobrany z View MenuPage oraz kilka zmiennych
        /// </summary>
        /// <param name="menuPage">MenuPage pobrany z View</param>
        public MenuPageVM(MenuPage menuPage)
        {

            LevelType = LevelType.FirstLevel;
            CurrentPage = "Poziom 1";
            CurrentImage = "Images/FirstLevelImage.png";
            MenuPage = menuPage;
           



            ChangePageCommand = new ChangePageCommand(this);

            ChangeCurrentLevelCommand = new ChangeCurrentLevelCommand(this);
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
