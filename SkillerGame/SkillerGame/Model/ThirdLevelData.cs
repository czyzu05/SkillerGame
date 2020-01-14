using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SkillerGame
{
   public static class ThirdLevelData
    {
     
        /// <summary>
        /// Lista liczb które wyświtlają się w odpowiednim Buttonie
        /// </summary>
        /// <returns></returns>
        public static List<string> SetListOfNumbers()
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

            return numbers;
        }

        /// <summary>
        /// Lista Buttonów przeznaczonych do gry na trzecim poziomie
        /// </summary>
        /// <param name="thirdLevelPage"></param>
        /// <returns></returns>
        public static List<Button> SetListOfButtons(ThirdLevel thirdLevelPage)
        {
            var ThirdLevelPage = thirdLevelPage;

            List<Button> buttons = new List<Button>(20);
            buttons.Add(ThirdLevelPage.button1);
            buttons.Add(ThirdLevelPage.button2);
            buttons.Add(ThirdLevelPage.button3);
            buttons.Add(ThirdLevelPage.button4);
            buttons.Add(ThirdLevelPage.button5);
            buttons.Add(ThirdLevelPage.button6);
            buttons.Add(ThirdLevelPage.button7);
            buttons.Add(ThirdLevelPage.button8);
            buttons.Add(ThirdLevelPage.button9);
            buttons.Add(ThirdLevelPage.button10);
            buttons.Add(ThirdLevelPage.button11);
            buttons.Add(ThirdLevelPage.button12);
            buttons.Add(ThirdLevelPage.button13);
            buttons.Add(ThirdLevelPage.button14);
            buttons.Add(ThirdLevelPage.button15);
            buttons.Add(ThirdLevelPage.button16);
            buttons.Add(ThirdLevelPage.button17);
            buttons.Add(ThirdLevelPage.button18);
            buttons.Add(ThirdLevelPage.button19);
            buttons.Add(ThirdLevelPage.button20);

            return buttons;


        }

    }
}
