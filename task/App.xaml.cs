using System.Windows;

namespace task;

public partial class App : Application
{
    private void OnStartup(object sender, StartupEventArgs e)
    {
        // Создали главное окно. (главная вьюшка)
        var view = new MainWindow();
        // Показываем главное окно.
        view.Show();
    }
}