using System;
using System.Windows;
using System.Windows.Controls;
using WpfMvvmUA2.ViewModel;
using WpfMvvmUA2.Views.Controls;

namespace WpfMvvmUA2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
        }

        private void sidebar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedMenu = sidebar.SelectedItem as NavButton;

            if (selectedMenu != null && selectedMenu.Navlink != null)
            {
                navframe.Navigate(selectedMenu.Navlink);
            }
        }

        private void QuitterButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
