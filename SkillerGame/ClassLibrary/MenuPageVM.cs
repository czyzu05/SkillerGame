﻿using SkillerGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
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
        public MenuPage MenuPage { get; }


        private string currentPage;
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


        private LevelType levelType;
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
        /// Properties przechowuje Komęde do zmiany Page
        /// </summary>
        public ChangePageCommand ChangePageCommand { get; }

        /// <summary>
        /// Properties przechowuje Komęde do zmiany aktualnego Poziomu w Menu Głównym
        /// </summary>
        public ChangeCurrentLevelCommand ChangeCurrentLevelCommand { get; }



        /// <summary>
        ///  Konstruktor który inicjuje pobrany z View MenuPage oraz kilka zmiennych
        /// </summary>
        /// <param name="menuPage">MenuPage pobrany z View</param>
        public MenuPageVM(MenuPage menuPage)
        {
            LevelType = LevelType.FirstLevel;
            CurrentPage = "Poziom 1";
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