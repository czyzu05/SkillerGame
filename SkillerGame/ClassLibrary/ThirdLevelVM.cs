using SkillerGame;
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

namespace ClassLibrary
{
    public class ThirdLevelVM : INotifyPropertyChanged
    {

        /// <summary>
        /// Standardowy event z interfejsu INotifyPropertyChanged 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Propierties która ma za zadanie przechowywać Page pobrany z View 
        /// </summary>
        public ThirdLevel ThirdLevelPage { get; }

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
        ///  Properties przechowuje aktualny stan gry
        /// </summary>
        private ThirdLevelStateType ThirdLevelStateType { get; set; }
        /// <summary>
        /// Properties przechowuje Przyciski do gry
        /// </summary>
        private List<Button> Buttons { get; set; }
        /// <summary>
        /// Properties przechowuje Listę liczb reprezentowanych jako typ String
        /// </summary>
        private List<string> Numbers { get; set; }


        /// <summary>
        /// Properties przechowuje Komendę do zmiany Page
        /// </summary>
        public ChangePageCommand ChangePageCommand { get; }

        /// <summary>
        /// Properties Przechowuje Komende do zmiany Stanu gry
        /// </summary>
        public CheckNumberCommand CheckNumberCommand { get; }

        /// <summary>
        /// Properties przechowuje DispatcherTimer 
        /// </summary>
        public DispatcherTimer Timer { get; set; }



        /// <summary>
        /// Konstruktor który inicjuje pobrany z View ThirdLevelPage , wywołuje metody odpowiedzialne za działanie gry oraz inicjuje Komendy odpowiedzialne za działanie
        /// gry oraz za zmiane aktulnego Page
        /// </summary>
        /// <param name="thirdLevelPage">ThirdLevelpage pobrany z View</param>
        public ThirdLevelVM(ThirdLevel thirdLevelPage)
        {


            ThirdLevelPage = thirdLevelPage;
            RandomizePositionsOfNumbers();

            //Ustawienie poczatkowej ilosci sekund 
            CurrentSecond = 25;
            StartTimer();


            ChangePageCommand = new ChangePageCommand(this);
            CheckNumberCommand = new CheckNumberCommand(this);

        }

        /// <summary>
        /// Metoda która wywołuje zegar gry oraz metodę ChangeAmountOfSeconds co 1 sekundę
        /// </summary>
        private void StartTimer()
        {
            Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromSeconds(1);
            Timer.Tick += ChangeAmountOfSeconds;
            Timer.Start();
        }

        /// <summary>
        /// Metoda odpowiedzialna za zmniejszanie pozostałej liczby sekund do momentu zakończenia gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeAmountOfSeconds(object sender, EventArgs e)
        {
            if (CurrentSecond == 0)
            {
                ThirdLevelStateType = ThirdLevelStateType.OutOfTime;
                CheckCurrentStateType();
            }

            ThirdLevelPage.SecondsInfo.Text = CurrentSecond--.ToString();

        }

        /// <summary>
        /// Metoda odowiedzialna za losowanie liczb pobranych z Listy w odpowiednie miejsca(Przyciski)
        /// </summary>
        private void RandomizePositionsOfNumbers()
        {

            Buttons = ThirdLevelData.SetListOfButtons(ThirdLevelPage);
            Numbers = ThirdLevelData.SetListOfNumbers();

            var rand = new Random();
            var randomList = Numbers.OrderBy(x => rand.Next()).ToList();

            for (int i = 0; i < Buttons.Count; i++)
            {
                Buttons[i].Content = randomList.ElementAt(i);
            }

        }

        /// <summary>
        /// Metoda odpowiedzialna za sprawdzenie czy podana liczba na jaką wskazaliśmy jest tą poprawną
        /// </summary>
        /// <param name="button">Przycisk wskazany przez gracza</param>
        public void CheckNumber(Button button)
        {
            var buttonContent = button.Content;
            Numbers = ThirdLevelData.SetListOfNumbers();


            if (buttonContent.ToString() == Numbers[CurrentState].ToString())
            {
                ThirdLevelStateType = ThirdLevelStateType.GoodNumber;
                CheckCurrentStateType();
                button.Content = " ";
                button.IsEnabled = false;
                ChangeStateOfThirdLevel();
            }
            else
            {
                ThirdLevelStateType = ThirdLevelStateType.WrongNumber;
                button.Background = Brushes.Red;
                var correctAnswer = Buttons.Select((Value, Index) => new { Value, Index }).Single(p => p.Value.Content.ToString() == Numbers[CurrentState]);
                Buttons[correctAnswer.Index].Background = Brushes.Green;
                CheckCurrentStateType();
            }



        }

        /// <summary>
        /// Metoda odpowiedzialna za zmiane aktualnego stanu gry , zwraca <see cref="CurrentState"/> typu int reprezentujący nowy stan gry , poprzez zwiększenie aktualnej wartości o 1 
        /// </summary>      
        private int ChangeStateOfThirdLevel()
        {
            if (CurrentState == 19)
            {
                ThirdLevelStateType = ThirdLevelStateType.Win;
                CheckCurrentStateType();
            }

            return CurrentState++;

        }

        /// <summary>
        /// Metoda odpowiedzialna za sprawdzenie rodzaju aktulnego stanu gry i w zależności od tego podjęcie odowiednich akcji
        /// </summary>
        private void CheckCurrentStateType()
        {


            switch (ThirdLevelStateType)
            {
                case ThirdLevelStateType.GoodNumber:
                    //MessageBox.Show("Dobra liczba  !!!");                    
                    break;
                case ThirdLevelStateType.WrongNumber:
                    Timer.Stop();
                    MessageBox.Show("Zła liczba , Przegrałeś !!!");
                    NavigateHelper.ChangePage(this.ThirdLevelPage, "MenuPage.xaml");
                    break;
                case ThirdLevelStateType.OutOfTime:
                    ThirdLevelPage.SecondsInfo.Text = CurrentSecond.ToString(); //ustawione w celu wykrycia przez UI zmiany liczby sekund z 1 na 0 
                    Timer.Stop();
                    MessageBox.Show("Czas sie skończył");
                    NavigateHelper.ChangePage(this.ThirdLevelPage, "MenuPage.xaml");
                    break;
                case ThirdLevelStateType.Win:
                    Timer.Stop();
                    MessageBox.Show("Wygrałeś !!!");
                    NavigateHelper.ChangePage(this.ThirdLevelPage, "MenuPage.xaml");
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