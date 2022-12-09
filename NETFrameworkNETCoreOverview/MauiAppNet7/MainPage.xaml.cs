using MauiAppNet7.Services;

namespace MauiAppNet7
{
    public partial class MainPage : ContentPage
    {
                
        int count = 0;
        ITimeService timeService;


        public MainPage(ITimeService timeService)
        {
            InitializeComponent();
            this.timeService = timeService;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            TimeLabel.Text = timeService.GetCurrentTime();
           
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}