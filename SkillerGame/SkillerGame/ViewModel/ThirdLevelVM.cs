using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// Properties przechowuje Komęde do zmiany Page
        /// </summary>
        public ChangePageCommand ChangePageCommand { get; }

        public ThirdLevelVM()
        {
           

        }

        public ThirdLevelVM(ThirdLevel thirdLevelPage)
        {
            levelType = LevelType.ThirdLevel;

            ThirdLevelPage = thirdLevelPage;
            RandomizePositionsOfNumbers();


            ChangePageCommand = new ChangePageCommand(this);
        }

        public void RandomizePositionsOfNumbers()
        {
            List<string> numbers = new List<string>(20);
            numbers.Add("1");
            numbers.Add("2");
            numbers.Add("3");
            numbers.Add("4");
            numbers.Add("5");
            numbers.Add("6");
            numbers.Add("7");
            numbers.Add("8");
            numbers.Add("9");
            numbers.Add("10");
            numbers.Add("11");
            numbers.Add("12");
            numbers.Add("13");
            numbers.Add("14");
            numbers.Add("15");
            numbers.Add("16");
            numbers.Add("17");
            numbers.Add("18");
            numbers.Add("19");
            numbers.Add("20");

            var rand = new Random();
            var randomList = numbers.OrderBy(x => rand.Next()).ToList();

            //1 wiersz
            ThirdLevelPage.button1.Content = randomList.ElementAt(0);
            ThirdLevelPage.button2.Content = randomList.ElementAt(1);
            ThirdLevelPage.button3.Content = randomList.ElementAt(2);
            ThirdLevelPage.button4.Content = randomList.ElementAt(3);
            ThirdLevelPage.button5.Content = randomList.ElementAt(4);

            //2 wiersz
            ThirdLevelPage.button6.Content = randomList.ElementAt(5);
            ThirdLevelPage.button7.Content = randomList.ElementAt(6);
            ThirdLevelPage.button8.Content = randomList.ElementAt(7);
            ThirdLevelPage.button9.Content = randomList.ElementAt(8);
            ThirdLevelPage.button10.Content = randomList.ElementAt(9);

            //3 wiersz
            ThirdLevelPage.button11.Content = randomList.ElementAt(10);
            ThirdLevelPage.button12.Content = randomList.ElementAt(11);
            ThirdLevelPage.button13.Content = randomList.ElementAt(12);
            ThirdLevelPage.button14.Content = randomList.ElementAt(13);
            ThirdLevelPage.button15.Content = randomList.ElementAt(14);

            //4 wiersz
            ThirdLevelPage.button16.Content = randomList.ElementAt(15);
            ThirdLevelPage.button17.Content = randomList.ElementAt(16);
            ThirdLevelPage.button18.Content = randomList.ElementAt(17);
            ThirdLevelPage.button19.Content = randomList.ElementAt(18);
            ThirdLevelPage.button20.Content = randomList.ElementAt(19);

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
