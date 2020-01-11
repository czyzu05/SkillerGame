using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillerGame
{

    /// <summary>
    /// ViewModel dla Strony Startowej
    /// </summary>
    public class StartPageVM : INotifyPropertyChanged
    {

        /// <summary>
        /// Standardowy event z interfejsu INotifyPropertyChanged 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Propierties która ma za zadanie przechowywać Page  pobrany z View 
        /// </summary>
        public StartPage StartPage { get;}


        /// <summary>
        /// Properties przechowuje Komęde do zmiany Page
        /// </summary>
        public ChangePageCommand ChangePageCommand { get;}



        /// <summary>
        ///  Konstruktor który inicjuje pobrany z View StartPage oraz kilka zmiennych
        /// </summary>
        /// <param name="startPage">StartPage pobrany z View</param>
        public StartPageVM(StartPage startPage)
        {
            StartPage = startPage;


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
