using MauiAppNet7.Services;

namespace MauiAppNet7
{
    public partial class App : Application
    {
        public App(Car car)
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}