using MobileApp.Views;

namespace MobileApp
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MyLocationPage();
        }
    }
}