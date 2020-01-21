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
    public static class NavigateHelper
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
           
            switch(currentSelectedLevel)
            {
                case LevelType.FirstLevel:
                    if(ButtonType==ButtonType.NextButton)
                    {
                        VMMenuPage.CurrentPage = "Poziom " + (int)(currentSelectedLevel + 1);
                        VMMenuPage.CurrentImage = "Images/error.png";
                        VMMenuPage.LevelType = currentSelectedLevel + 1;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException($"{nameof(ButtonType)} jest spoza dopuszczalnych przypadków");
                    }
                    break;
                case LevelType.SecondLevel:
                    if (ButtonType == ButtonType.PreviousButton)
                    {
                        VMMenuPage.CurrentPage = "Poziom " + (int)(currentSelectedLevel - 1);
                        VMMenuPage.CurrentImage = "Images/FirstLevelImage.png";
                        VMMenuPage.LevelType = currentSelectedLevel - 1;
                    }
                    else if (ButtonType == ButtonType.NextButton)
                    {
                        VMMenuPage.CurrentPage = "Poziom " + (int)(currentSelectedLevel + 1);
                        VMMenuPage.CurrentImage = "Images/ThirdLevelImage.png";
                        VMMenuPage.LevelType = currentSelectedLevel + 1;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException($"{nameof(ButtonType)} jest spoza dopuszczalnych przypadków");
                    }
                    break;
                case LevelType.ThirdLevel:
                    if (ButtonType == ButtonType.PreviousButton)
                    {
                        VMMenuPage.CurrentPage = "Poziom " + (int)(currentSelectedLevel - 1);
                        VMMenuPage.CurrentImage = "Images/error.png";
                        VMMenuPage.LevelType = currentSelectedLevel - 1;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException($"{nameof(ButtonType)} jest spoza dopuszczalnych przypadków");
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"{nameof(LevelType)} jest spoza dopuszczalnych przypadków");
                    
            }

            /*
            //zmiana z Level 1 na Level 2
            if (currentSelectedLevel == LevelType.FirstLevel && ButtonType == ButtonType.NextButton)
            {
                VMMenuPage.CurrentPage = "Poziom "+ (int)(currentSelectedLevel+1);
                VMMenuPage.CurrentImage = "Images/error.png";
                VMMenuPage.LevelType = currentSelectedLevel + 1;
                

            }

            //Do Poprawy 
            //zmienic na switch
            //zmiana z Level 2 na Level 1
            else if (currentSelectedLevel == LevelType.SecondLevel && ButtonType == ButtonType.PreviousButton)
            {
                VMMenuPage.CurrentPage = "Poziom "+ (int)(currentSelectedLevel - 1);
                VMMenuPage.CurrentImage = "Images/FirstLevelImage.png";
                VMMenuPage.LevelType = currentSelectedLevel-1;
            }

            //zmiana z Level 2 na Level 3
            else if (currentSelectedLevel == LevelType.SecondLevel && ButtonType == ButtonType.NextButton)
            {
                VMMenuPage.CurrentPage = "Poziom "+ (int)(currentSelectedLevel + 1);
                VMMenuPage.CurrentImage = "Images/error.png";
                VMMenuPage.LevelType = currentSelectedLevel + 1;
            }

            //zmiana z Level 3 na Level 2
            else if (currentSelectedLevel == LevelType.ThirdLevel && ButtonType==ButtonType.PreviousButton)
            {
                VMMenuPage.CurrentPage = "Poziom " + (int)(currentSelectedLevel - 1);
                VMMenuPage.CurrentImage = "Images/error.png";
                VMMenuPage.LevelType = currentSelectedLevel-1;
            }

            else
                throw new ArgumentOutOfRangeException($"{nameof(LevelType)} jest spoza dopuszczalnych przypadków");
                */
            
            

        }

    }
}
