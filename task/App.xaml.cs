using System.Collections.Generic;
using System.Windows;
using task.Model;
using task.ViewModel;

namespace task;

public partial class App : Application
{
    private void OnStartup(object sender, StartupEventArgs e)
    {
        // Создали главное окно. (главная вьюшка)
        MainWindow view = new MainWindow();
        // Показываем главное окно.
        view.Show();
    }
}