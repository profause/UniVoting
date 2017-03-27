﻿using System.Windows;
using System.Windows.Controls;

namespace UniVoting.WPF.Administrators
{
    /// <summary>
    /// Interaction logic for AdminMenuPage.xaml
    /// </summary>
    public partial class AdminMenuPage : Page
    {
        public AdminMenuPage()
        {
            InitializeComponent();
        }

        private void BtnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
              NavigationService?.Navigate(new AdminCreateAccountPage());
            
        }

        private void BtnSetUpElection_Click(object sender, RoutedEventArgs e)
        {
            
                NavigationService?.Navigate(new AdminSetUpElectionPage());
            
        }

        private void BtnSetUpPostions_Click(object sender, RoutedEventArgs e)
        {
            
                NavigationService?.Navigate(new AdminSetUpPositionPage());
            
        }

        private void BtnSetUpCandidates_Click(object sender, RoutedEventArgs e)
        {
            
                NavigationService?.Navigate(new AdminSetUpCandidatesPage());
            
        }
    }
}
