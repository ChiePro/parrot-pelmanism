using System.Windows;

namespace ParrotPelmanism
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        void App_Startup(object sender, StartupEventArgs e)
        {
            //2秒スプラッシュスクリーンを待機させる
            System.Threading.Thread.Sleep(2000);

        }

    }
}
