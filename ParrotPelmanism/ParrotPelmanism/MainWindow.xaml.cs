using System;
using System.Windows;
using System.Windows.Navigation;

namespace ParrotPelmanism
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            _navi = this.myFrame.NavigationService;

            _navi.Navigate(Pages.PageDic["Start"], UriKind.Relative);

        }

        private NavigationService _navi;
    }
}
