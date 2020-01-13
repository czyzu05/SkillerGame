﻿using System;
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
        public static void ChangeCurrentLevel(MenuPageVM vm)
        {

            
                VMMenuPage = vm;

            if (VMMenuPage.LevelType == LevelType.FirstLevel)
            {
                VMMenuPage.CurrentPage = "Poziom 2";
                VMMenuPage.CurrentImage = "Images/error.png";
                VMMenuPage.LevelType = LevelType.SecondLevel;
                

            }

            else if (VMMenuPage.LevelType == LevelType.SecondLevel)
            {
                VMMenuPage.CurrentPage = "Poziom 3";
                VMMenuPage.CurrentImage = "Images/error.png";
                VMMenuPage.LevelType = LevelType.ThirdLevel;
            }

            else if (VMMenuPage.LevelType == LevelType.ThirdLevel)
            {
                VMMenuPage.CurrentPage = "Poziom 1";
                VMMenuPage.CurrentImage = "Images/FirstLevelImage.png";
                VMMenuPage.LevelType = LevelType.FirstLevel;
            }

            else
                throw new ArgumentOutOfRangeException($"{nameof(LevelType)} jest spoza dopuszczalnych przypadków");

            
            

        }

    }
}
