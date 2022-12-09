using Microsoft.Extensions.Logging;
using System;
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

namespace WpfNET7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ILogger<MainWindow> logger;


        public MainWindow(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<MainWindow>();
            InitializeComponent();


            //throw new ApplicationException("The app crashed");
        }

        protected override void OnContentRendered(EventArgs e)
        {
            base.OnContentRendered(e);

            logger.LogInformation("MainWindow rendered!!! Juhuu!!!!!!");
        }
    }
}
