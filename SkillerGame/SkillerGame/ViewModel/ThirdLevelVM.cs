using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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
           
            List<Button> buttons = ThirdLevelData.SetListOfButtons(ThirdLevelPage);
            List<string> numbers = ThirdLevelData.SetListOfNumbers();
                
            var rand = new Random();
            var randomList = numbers.OrderBy(x => rand.Next()).ToList();
            
            for(int i=0;i<buttons.Count;i++)
            {                
                buttons[i].Content = randomList.ElementAt(i);
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
