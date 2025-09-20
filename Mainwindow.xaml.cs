using System;
using System.Windows;
using System.Windows.Threading;

namespace MyClockSaver
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            Timer_Tick(null, null);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ClockText.Text = DateTime.Now.ToString("HH:mm"); // 24-hour format
            // Agar 12-hour AM/PM format chahiye to: "hh:mm tt"
        }
    }
}
