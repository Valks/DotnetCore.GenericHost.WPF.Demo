using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Demo.DI.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CancellationTokenSource _cts;

        public MainWindow(Services.CounterService counterService)
        {
            _cts = new CancellationTokenSource();

            CounterService = counterService;

            CounterService.ExecuteAsync(_cts.Token);

            InitializeComponent();
        }

        public Services.CounterService CounterService { get; }

        protected override void OnClosing(CancelEventArgs e)
        {
            _cts.Cancel();
            base.OnClosing(e);
        }
    }
}
