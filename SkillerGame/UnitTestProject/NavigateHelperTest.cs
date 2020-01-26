using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkillerGame;

namespace UnitTestProject
{
    [TestClass]
    public class NavigateHelperTest
    {
        #region FirstLevel Test - ChangeCurrentLevel Method
        [DataTestMethod]
        [DataRow(LevelType.FirstLevel)]
        public void Method_ChangeCurrentLevel_LevelType_FirstLevel_ButtonNext_Expected_LevelType_SecondLevel_Sucess(LevelType levelType)
        {
            //Arrange
            var LevelType = levelType;

            var MenuPage = new MenuPage();

            var VMMenuPage = new MenuPageVM(MenuPage);
            VMMenuPage.LevelType = LevelType;

            //Expected
            var expLevelType = LevelType.SecondLevel;


            //Act
            NavigateHelper.ChangeCurrentLevel(VMMenuPage, ButtonType.NextButton);


            //Assert
            Assert.AreEqual(expLevelType, VMMenuPage.LevelType);


        }

        [DataTestMethod]
        [DataRow(LevelType.FirstLevel)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Method_ChangeCurrentLevel_LevelType_FirstLevel_ButtonPrevious_Expected_Exception_Failed(LevelType levelType)
        {
            //Arrange
            var LevelType = levelType;

            var MenuPage = new MenuPage();

            var VMMenuPage = new MenuPageVM(MenuPage);
            VMMenuPage.LevelType = LevelType;



            //Act
            NavigateHelper.ChangeCurrentLevel(VMMenuPage, ButtonType.PreviousButton);
        }
        #endregion

        #region SecondLevel Test - ChangeCurrentLevel Method
        [DataTestMethod]
        [DataRow(LevelType.SecondLevel)]
        public void Method_ChangeCurrentLevel_LevelType_SecondLevel_ButtonPrevious_Expected_LevelType_FirstLevel_Sucess(LevelType levelType)
        {
            //Arrange
            var LevelType = levelType;

            var MenuPage = new MenuPage();

            var VMMenuPage = new MenuPageVM(MenuPage);
            VMMenuPage.LevelType = LevelType;

            //Expected
            var expLevelType = LevelType.FirstLevel;


            //Act
            NavigateHelper.ChangeCurrentLevel(VMMenuPage, ButtonType.PreviousButton);


            //Assert
            Assert.AreEqual(expLevelType, VMMenuPage.LevelType);


        }

        [DataTestMethod]
        [DataRow(LevelType.SecondLevel)]
        public void Method_ChangeCurrentLevel_LevelType_SecondLevel_ButtonNext_Expected_LevelType_ThirdLevel_Sucess(LevelType levelType)
        {
            //Arrange
            var LevelType = levelType;

            var MenuPage = new MenuPage();

            var VMMenuPage = new MenuPageVM(MenuPage);
            VMMenuPage.LevelType = LevelType;

            //Expected
            var expLevelType = LevelType.ThirdLevel;


            //Act
            NavigateHelper.ChangeCurrentLevel(VMMenuPage, ButtonType.NextButton);


            //Assert
            Assert.AreEqual(expLevelType, VMMenuPage.LevelType);


        }


        #endregion

        #region ThirdLevel Test - ChangeCurrentLevel Method

        [DataTestMethod]
        [DataRow(LevelType.ThirdLevel)]
        public void Method_ChangeCurrentLevel_LevelType_ThirdLevel_ButtonPrevious_Expected_LevelType_SecondLevel_Sucess(LevelType levelType)
        {
            //Arrange
            var LevelType = levelType;

            var MenuPage = new MenuPage();

            var VMMenuPage = new MenuPageVM(MenuPage);
            VMMenuPage.LevelType = LevelType;

            //Expected
            var expLevelType = LevelType.SecondLevel;


            //Act
            NavigateHelper.ChangeCurrentLevel(VMMenuPage, ButtonType.PreviousButton);


            //Assert
            Assert.AreEqual(expLevelType, VMMenuPage.LevelType);


        }


        [DataTestMethod]
        [DataRow(LevelType.ThirdLevel)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Method_ChangeCurrentLevel_LevelType_ThirdLevel_ButtonNext_Expected_Exception_Failed(LevelType levelType)
        {
            //Arrange
            var LevelType = levelType;

            var MenuPage = new MenuPage();

            var VMMenuPage = new MenuPageVM(MenuPage);
            VMMenuPage.LevelType = LevelType;



            //Act
            NavigateHelper.ChangeCurrentLevel(VMMenuPage, ButtonType.NextButton);


        }

        #endregion

    }
}
