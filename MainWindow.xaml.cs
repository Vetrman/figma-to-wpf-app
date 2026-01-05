using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace Figma
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetStartedButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var border = sender as System.Windows.Controls.Border;
            if (border != null)
            {
                var original = border.Background;
                border.Background = new SolidColorBrush(Color.FromRgb(0, 120, 215));

                var timer = new DispatcherTimer
                {
                    Interval = System.TimeSpan.FromMilliseconds(200) // Исправлено
                };

                timer.Tick += (s, args) =>
                {
                    border.Background = original;
                    timer.Stop();
                };

                timer.Start();

                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void LayerItem_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is System.Windows.Controls.StackPanel panel)
            {
                panel.Background = new SolidColorBrush(Color.FromArgb(20, 0, 0, 0));
            }
        }

        private void LayerItem_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is System.Windows.Controls.StackPanel panel)
            {
                panel.Background = Brushes.Transparent;
            }
        }

        private void LayerItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is System.Windows.Controls.StackPanel panel)
            {
                var original = panel.Background;
                panel.Background = new SolidColorBrush(Color.FromArgb(40, 13, 153, 255));

                var timer = new DispatcherTimer
                {
                    Interval = System.TimeSpan.FromMilliseconds(300) // Исправлено
                };

                timer.Tick += (s, args) =>
                {
                    panel.Background = original;
                    timer.Stop();
                };

                timer.Start();

                System.Media.SystemSounds.Beep.Play();
            }
        }
    }
}