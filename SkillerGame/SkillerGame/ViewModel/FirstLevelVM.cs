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
        /// Properties przechowuje aktualny stan gry
        /// </summary>

        private FirstLevelStateType FirstLevelStateType { get; set; }
        ///<summary>
        ///Przycisk do gry
        /// </summary>

        private List<Button> Buttons { get; set; }

        ///<summary>
        ///Liczba w buttonach
        /// </summary>

        private int Number { get; set; }

        /// <summary>
        /// Properties przechowuje Komęde do zmiany Page
        /// </summary>
        public ChangePageCommand ChangePageCommand { get; }

        ///<summary>
        ///Komenda do zmiany stanu gry
        /// </summary>

        public CheckNumberCommand CheckNumberCommand { get; }


        ///<summary>
        ///Timer
        /// </summary>

        public DispatcherTimer Timer {get; set;}

        /// <summary>
        /// Konstruktor który inicjuje pobrany z View FirstLevel oraz Komende odpowiedzialną za zmiane aktualnego Page
        /// </summary>
        /// <param name="firstLevelPage">FirstLevelPage pobrany z View</param>
        public FirstLevelVM(FirstLevel firstLevelPage)
        {
            

            FirstLevelPage = firstLevelPage;
            GenerateNumbersWithOneOther();

            CurrentSecond = 15;
            StartTimer();

            ChangePageCommand = new ChangePageCommand(this);
           // CheckNumberCommand = new CheckNumberCommand(this);
        }

        ///<summary>
        ///Zegar gry
        /// </summary>

        private void StartTimer()
        {
            Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromSeconds(1);
            Timer.Tick += ChangeSumSeconds;
            Timer.Start();
        }


        ///<summary>
        ///Odliczanie do końca czasu gry
        /// </summary>


        private void ChangeSumSeconds(object sender, EventArgs e)
        {


            if(CurrentSecond == 0)
            {
                FirstLevelStateType = FirstLevelStateType.OutOfTime;
                CheckCurrentStateType();
            }
            else if (CurrentSecond < 0)
            {
                throw new ArgumentOutOfRangeException("Błąd");
            }
            else
            {
                FirstLevelPage.SecondsInfo.Text = CurrentSecond--.ToString();
            }
        }


        ///<summary>
        ///Metoda odpowiedzialna za generowanie liczb z jedną inną
        /// </summary>


        private void GenerateNumbersWithOneOther()
        {
            
            Buttons = FirstLevelData.SetListOfButtons(FirstLevelPage);
            Number = FirstLevelData.SetNumber();

            Random rnd = new Random();
            int number = rnd.Next(1, 85);
            for(int i=0; i < Buttons.Count; i++)
            {
                Buttons[i].Content = 7;
            }

            /*
            if(position == number)
            {
                Buttons[position].Content = 1;
            }
            else
            {
                for (int i = 0 ; i < Buttons.Count; i++)
                {
                    Buttons[i].Content = Number;
                }
            }
            */
        }

        public void CheckNumber(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int choose = Convert.ToInt32(btn.Content);

            if (choose == 1)
            {
                FirstLevelStateType = FirstLevelStateType.GoodNumber;
                CheckCurrentStateType();
                MessageBox.Show("Wygrałeś");
            }
            else
            {
                FirstLevelStateType = FirstLevelStateType.WrongNumber;
                CheckCurrentStateType();
            }
        }


        private void CheckCurrentStateType()
        {
            switch (FirstLevelStateType)
            {
                case FirstLevelStateType.GoodNumber:
                    Timer.Stop();
                    MessageBox.Show("Wygrałeś");
                    NavigateHelper.ChangePage(this.FirstLevelPage, "MenuPage.xaml");
                    break;
                case FirstLevelStateType.WrongNumber:
                    Timer.Stop();
                    MessageBox.Show("Zła liczba, przegrałeś");
                    NavigateHelper.ChangePage(this.FirstLevelPage, "MenuPage.xaml");
                    break;
                case FirstLevelStateType.OutOfTime:
                    FirstLevelPage.SecondsInfo.Text = CurrentSecond.ToString();
                    Timer.Stop();
                    MessageBox.Show("Czas się skończył, przegrałeś");
                    NavigateHelper.ChangePage(this.FirstLevelPage, "MenuPage.xaml");
                    break;
            }
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
