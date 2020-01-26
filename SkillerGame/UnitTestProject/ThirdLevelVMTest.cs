using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillerGame;
using System.Windows.Controls;

namespace UnitTestProject
{
    [TestClass]
    public class ThirdLevelVMTest
    {
        #region Method CheckNumbers
        [TestMethod]
        public void Method_CheckNumbers_ButtonContent_1_CurrentState_0_Expected_ThirdLevelStateType_GoodNumber()
        {
            //Arrange          
            Button Button = new Button();
            Button.Content = "1";
            var buttonContent = Button.Content;
            var Numbers = ThirdLevelData.SetListOfNumbers();

            var ThirdLevel = new ThirdLevel();

            var VMThirdLevel = new ThirdLevelVM(ThirdLevel);
            VMThirdLevel.CurrentState = 0;



            //Expected
            var expThirdLevelStateType = ThirdLevelStateType.GoodNumber;


            //Act
            VMThirdLevel.CheckNumber(Button);


            //Assert
            Assert.AreEqual(expThirdLevelStateType, VMThirdLevel.ThirdLevelStateType);


        }
        /*
      W związku z tym że moja połączenie z ViewModel wymaga podania jako argument View (przy tworzeniu konstruktora ViewModel) to nie jestem w stanie zrobić testów jednostkowych używając ClassLibrary
       ponieważ Class Library nie ma dostępu do View(tkiego jak np: MenuPage , FirstLevel , ThirdLevel). ponadto bez utworzenia w przypadku testowym obiektu typu View
       nie jestem w wstanie przetestować żadnej z metod. Dlatego więc użyłem NameSpace SkillerGame jednak tu pojawia się problem z że w momencie jak testuję poniższą metodę
       wyskakuje TextBlock z informacją o Spodziewanym Typie Stanu(ThirdLevelStateType_WrongNumber).W pierwszej testowanej metodzie nie ma tego problemu ale jest to 
       spowodowane tym że akurat w metodzie odpowiedzialnej za Sprawdzenie Typu Aktualnego Stanu Gry(CheckCurrentStateType()) nie ma sprecyzowanej żadnej akcjii dla 
       przypadku ThirdLevelStateType.GoodNumber.
       
    */
        /*
            [TestMethod]
            public void Method_CheckNumbers_ButtonContent_5_CurrentState_7_Expected_ThirdLevelStateType_WrongNumber()
            {
                //Arrange          
                Button Button = new Button();
                Button.Content = "5";
                var buttonContent = Button.Content;
                var Numbers = ThirdLevelData.SetListOfNumbers();

                var ThirdLevel = new ThirdLevel();

                var VMThirdLevel = new ThirdLevelVM(ThirdLevel);
                VMThirdLevel.CurrentState = 7;



                //Expected
                var expThirdLevelStateType = ThirdLevelStateType.WrongNumber;


                //Act
                VMThirdLevel.CheckNumber(Button);


                //Assert
                Assert.AreEqual(expThirdLevelStateType, VMThirdLevel.ThirdLevelStateType);


            }

        */
        #endregion
    }
}
