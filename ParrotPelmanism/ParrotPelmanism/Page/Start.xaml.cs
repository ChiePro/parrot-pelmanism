using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace ParrotPelmanism
{
    /// <summary>
    /// Start.xaml の相互作用ロジック
    /// </summary>
    public partial class Start : Page
    {

        public Start()
        {
            InitializeComponent();
        }

        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            var navi = NavigationService.GetNavigationService(this);
            navi.Navigate(Pages.PageDic["MainGame"], UriKind.Relative);
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("終了しますか？", "Information", MessageBoxButton.YesNo,MessageBoxImage.Information) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                System.Environment.Exit(0);
            }
        }
    }
}
