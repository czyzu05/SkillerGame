using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkillerGame;

namespace UnitTestProject
{
    [TestClass]
    public class NavigateHelperTest
    {
        [DataTestMethod]
        [DataRow(LevelType.FirstLevel)]
        public void Method_ChangeCurrentLevel_LevelType_FirstLevel_Expected_LevelType_SecondLevel_Sucess(LevelType levelType)
        {
            //Arrange
            var LevelType = levelType;

            var MenuPage = new MenuPage();           

            var VMMenuPage = new MenuPageVM(MenuPage);
            VMMenuPage.LevelType = LevelType;

            //Expected
            var expLevelType = LevelType.SecondLevel;
            

            //Act
            NavigateHelper.ChangeCurrentLevel(VMMenuPage);


            //Assert
            Assert.AreEqual(expLevelType, VMMenuPage.LevelType);

            
        }

        [DataTestMethod]
        [DataRow(LevelType.SecondLevel)]
        public void Method_ChangeCurrentLevel_LevelType_SecondLevel_Expected_LevelType_FirstLevel_Sucess(LevelType levelType)
        {
            //Arrange
            var LevelType = levelType;

            var MenuPage = new MenuPage();

            var VMMenuPage = new MenuPageVM(MenuPage);
            VMMenuPage.LevelType = LevelType;

            //Expected
            var expLevelType = LevelType.FirstLevel;


            //Act
            NavigateHelper.ChangeCurrentLevel(VMMenuPage);


            //Assert
            Assert.AreEqual(expLevelType, VMMenuPage.LevelType);


        }

        [DataTestMethod]
        [DataRow(LevelType.ThirdLevel)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Method_ChangeCurrentLevel_LevelType_FirstLevel_Expected_Exception_Failed(LevelType levelType)
        {
            //Arrange
            var LevelType = levelType;

            var MenuPage = new MenuPage();

            var VMMenuPage = new MenuPageVM(MenuPage);
            VMMenuPage.LevelType = LevelType;

            

            //Act
            NavigateHelper.ChangeCurrentLevel(VMMenuPage);


        }

        [DataTestMethod]
        [DataRow(LevelType.SecondLevel)]
        public void Method_ChangePage_LevelType_SecondLevel_Expected_LevelType_FirstLevel_Sucess(LevelType levelType)
        {
            //Arrange
            var LevelType = levelType;

            var MenuPage = new MenuPage();

            var VMMenuPage = new MenuPageVM(MenuPage);
            VMMenuPage.LevelType = LevelType;

            //Expected
            var expLevelType = LevelType.FirstLevel;


            //Act
            NavigateHelper.ChangeCurrentLevel(VMMenuPage);


            //Assert
            Assert.AreEqual(expLevelType, VMMenuPage.LevelType);


        }


    }
}
