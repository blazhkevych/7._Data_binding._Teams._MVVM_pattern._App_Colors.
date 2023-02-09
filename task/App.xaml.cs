using System.Collections.Generic;
using System.Windows;
using task.Model;
using task.ViewModel;

namespace task;

public partial class App : Application
{
    private void OnStartup(object sender, StartupEventArgs e)
    {
        #region Добавление цветов в список, для тестирования.

        var colors = new List<ColorModel>
        {
            new(255, 0, 0, 0),
            new(0, 255, 0, 0),
            new(0, 0, 255, 0),
            new(0, 0, 0, 255),
            new(255, 255, 255, 255),
            new(0, 0, 0, 0),
            new(255, 255, 255, 0),
            new(255, 255, 0, 255),
            new(255, 0, 255, 255),
            new(0, 255, 255, 255)
        };

        #endregion

        // Создали главное окно. (главная вьюшка)
        var mainWindow = new MainWindow();
        // Создали обьект главной ViewModel. И все цвета созданные выше передаем в конструктор.
        var mainViewModel = new MainViewModel(colors);
        // Устанавливаем DataContext главного окна на главную ViewModel. Чтобы наша вьюшка знала про вьюмодель.
        // Это же мы делали в XAML, в другом примере. В Window.Resources создавали ViewModel.
        // Теперь наша вьюшка знает про вьюмодель.
        mainWindow.DataContext = mainViewModel;
        // Показываем главное окно.
        mainWindow.Show();
    }
}