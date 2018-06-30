using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace ParrotPelmanism
{
    /// <summary>
    /// MainGame.xaml の相互作用ロジック
    /// </summary>
    public partial class MainGame : Page
    {

        private class BindingData
        {
            public string time { get; set; } = "00:00:00.00";
            public string miss { get; set; } = "0回";
        }

        public MainGame()
        {
            NavigationService navi = NavigationService.GetNavigationService(this);
            InitializeComponent();
            this.DataContext = new BindingData();
        }


        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService navi = NavigationService.GetNavigationService(this);
            navi.Navigate(Pages.PageDic["Start"], UriKind.Relative);
        }
    }

    
}
