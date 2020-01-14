using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SkillerGame
{
    /// <summary>
    /// Klasa przechowuje w sobie metody które są przydatne przy nawigowaniu
    /// </summary>
    public class NavigateHelper
    {
        private static MenuPageVM VMMenuPage;

        private static ButtonType ButtonType;

        /// <summary>
        /// Zmiana aktualnego Page na inny Page
        /// </summary>
        /// <param name="currentParent"></param>
        /// <param name="nextPage"></param>
        public static void ChangePage(DependencyObject currentParent , string nextPage )
        {

            Frame pageFrame = null;
            DependencyObject currParent = VisualTreeHelper.GetParent(currentParent);
            while (currParent != null && pageFrame == null)
            {
                pageFrame = currParent as Frame;
                currParent = VisualTreeHelper.GetParent(currParent);
            }

            
            if (pageFrame != null)
            {
                pageFrame.Source = new Uri(nextPage, UriKind.Relative);
            }
        }

        /// <summary>
        /// Zmiana aktualnie wybranego Poziomu na inny Poziom
        /// </summary>
        /// <param name="currentParent"></param>
        public static void ChangeCurrentLevel(MenuPageVM vm , ButtonType buttonType)
        {
          
            VMMenuPage = vm;
            ButtonType = buttonType;
            var currentSelectedLevel = VMMenuPage.LevelType;            

            if (currentSelectedLevel == LevelType.FirstLevel && ButtonType == ButtonType.NextButton)
            {
                VMMenuPage.CurrentPage = "Poziom 2";
                VMMenuPage.CurrentImage = "Images/error.png";
                VMMenuPage.LevelType = LevelType.SecondLevel;
                

            }

            //Do Poprawy
            //Zrobic ze np Poziom [LevelType.FirstLevel](liczba np :1,2,3 itd)
            else if (currentSelectedLevel == LevelType.SecondLevel && ButtonType == ButtonType.PreviousButton)
            {
                VMMenuPage.CurrentPage = "Poziom 1";
                VMMenuPage.CurrentImage = "Images/FirstLevelImage.png";
                VMMenuPage.LevelType = currentSelectedLevel-1;
            }

            else if (currentSelectedLevel == LevelType.SecondLevel && ButtonType == ButtonType.NextButton)
            {
                VMMenuPage.CurrentPage = "Poziom 3";
                VMMenuPage.CurrentImage = "Images/error.png";
                VMMenuPage.LevelType = currentSelectedLevel + 1;
            }

            else if (currentSelectedLevel == LevelType.ThirdLevel && ButtonType==ButtonType.PreviousButton)
            {
                VMMenuPage.CurrentPage = "Poziom 2";
                VMMenuPage.CurrentImage = "Images/error.png";
                VMMenuPage.LevelType = LevelType.SecondLevel;
            }

            else
                throw new ArgumentOutOfRangeException($"{nameof(LevelType)} jest spoza dopuszczalnych przypadków");

            
            

        }

    }
}
