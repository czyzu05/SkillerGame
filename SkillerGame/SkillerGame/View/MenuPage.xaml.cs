﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SkillerGame
{
    /// <summary>
    /// Logika interakcji dla klasy MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
            Awake();
            
            
        }

        public void Awake()
        {
            //Tworzenie instancji ViewModel w codebehind zamiast w XAMLU
            MenuPageVM vm = new MenuPageVM(this);

            // zrobienie Bindingu w CodeBehind
            Binding binding = new Binding("ChangePageCommand");
            binding.Source = vm;
            startButton.SetBinding(Button.CommandProperty, binding);

            //Bindowanie przycisku Next w CodeBehind
            Binding binding2 = new Binding("ChangeCurrentLevelCommand");
            binding2.Source = vm;
            forwardButton.SetBinding(Button.CommandProperty, binding2);

            //Bindowanie przycisku Cofinij w CodeBehind
            Binding binding3 = new Binding("ChangeCurrentLevelCommand");
            binding3.Source = vm;
            backWardButton.SetBinding(Button.CommandProperty, binding3);

            //Bindowanie TextBlocka odpowiedzalnego za wyswietlanie informacjii o aktualnym poziomie
            Binding binding4 = new Binding("CurrentPage");
            binding4.Source = vm;
            levelInfo.SetBinding(TextBlock.TextProperty, binding4);

            


        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            //NavigateHelper.ChangePage(this, "FirstLevel.xaml");
        }
    }
}
