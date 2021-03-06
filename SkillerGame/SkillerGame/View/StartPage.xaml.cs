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
    /// Logika interakcji dla klasy StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        /// <summary>
        /// Standardowy Konstruktor inicjujący komponenty z xamla i inicjujący Binding
        /// </summary>
        public StartPage()
        {
            InitializeComponent();
            CodeBehindBinding();
        }

        /// <summary>
        /// Metoda odpowiedzialna za code behind Binding 
        /// </summary>
        public void CodeBehindBinding()
        {
            //Tworzenie instancji ViewModel w codebehind zamiast w XAMLU
            StartPageVM vm = new StartPageVM(this);

            // zrobienie Bindingu w CodeBehind
            Binding binding = new Binding("ChangePageCommand");
            binding.Source = vm;
            letsStartButton.SetBinding(Button.CommandProperty, binding);
        }

        
    }
}
