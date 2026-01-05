using System.Windows;

namespace Figma
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Устанавливаем тему (опционально)
            SetTheme();
        }

        private void SetTheme()
        {
            // Можно добавить смену темы
            Resources.MergedDictionaries.Clear();
            Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new System.Uri("/Styles/Colors.xaml", System.UriKind.Relative)
            });
        }
    }
}