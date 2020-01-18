using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace SkillerGame
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
        /// Properties przechowuje typ poziomu
        /// </summary>
        public LevelType levelType { get; }

        /// <summary>
        /// Aktualny stan gry
        /// </summary>
        public int CurrentState { get; set;}

        private int currentSecond;

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
        /// Properties przechowuje Komęde do zmiany Page
        /// </summary>
        public ChangePageCommand ChangePageCommand { get; }

        /// <summary>
        /// Properties Przechowuje Komęde do zmiany Stanu gry
        /// </summary>
        public CheckNumberCommand CheckNumberCommand { get; }

        /// <summary>
        /// Properties przechowuje DispatcherTimer
        /// </summary>
        public DispatcherTimer Timer { get; set; }
      

        public ThirdLevelVM()
        {
           

        }

        public ThirdLevelVM(ThirdLevel thirdLevelPage)
        {
            levelType = LevelType.ThirdLevel;

            ThirdLevelPage = thirdLevelPage;
            RandomizePositionsOfNumbers();

            //Ustawienie poczatkowej ilosci sekund 
            CurrentSecond = 25;
            StartTimer();


            ChangePageCommand = new ChangePageCommand(this);
            CheckNumberCommand = new CheckNumberCommand(this);

        }

        /// <summary>
        /// Metoda która wywołuje metodę ChangeAmountOfSeconds co 1 sekundę
        /// </summary>
        public void StartTimer()
        {
            Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromSeconds(1);
            Timer.Tick += ChangeAmountOfSeconds;
            Timer.Start();
        }

        /// <summary>
        /// Metoda odpowiedzialna za zmniejszanie pozostałej liczby sekund do zakończenia gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeAmountOfSeconds(object sender, EventArgs e)
        {
            if (CurrentSecond == 0)
            {
                ThirdLevelPage.SecondsInfo.Text = CurrentSecond.ToString();
                Timer.Stop();
                MessageBox.Show("Czas sie skończył");                
                NavigateHelper.ChangePage(this.ThirdLevelPage, "MenuPage.xaml");
            }

            ThirdLevelPage.SecondsInfo.Text = CurrentSecond--.ToString();

            

        }

        public void RandomizePositionsOfNumbers()
        {
            
            List<Button> buttons = ThirdLevelData.SetListOfButtons(ThirdLevelPage);
            List<string> numbers = ThirdLevelData.SetListOfNumbers();
                
            var rand = new Random();
            var randomList = numbers.OrderBy(x => rand.Next()).ToList();
            
            for(int i=0;i<buttons.Count;i++)
            {                
                buttons[i].Content = randomList.ElementAt(i);
            }

        }

        
        public void CheckNumber(Button button)
        {
            var buttonContent = button.Content;
            List<string> numbers = ThirdLevelData.SetListOfNumbers();
            

           
                if (buttonContent.ToString() == numbers[CurrentState].ToString())
                {
                    MessageBox.Show("Dobrze !!!");                   
                    ChangeStateOfThirdLevel(); //CurrentState++;
                }
                else
                    MessageBox.Show("Źle !!!");

            

        }

        public int ChangeStateOfThirdLevel()
        {
            if(CurrentState==19)
              return CurrentState = 0;

            return CurrentState++;

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
