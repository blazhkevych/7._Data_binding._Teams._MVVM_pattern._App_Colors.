using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using task.Model;

namespace task;

public partial class App : Application
{
    #region Добавление цветов в список, для тестирования.
    private void OnStartup()
    {
        List<ColorModel> colors = new List<ColorModel>
        {
            new ColorModel(255, 0, 0, 0),
            new ColorModel(0, 255, 0, 0),
            new ColorModel(0, 0, 255, 0),
            new ColorModel(0, 0, 0, 255),
            new ColorModel(255, 255, 255, 255),
            new ColorModel(0, 0, 0, 0),
            new ColorModel(255, 255, 255, 0),
            new ColorModel(255, 255, 0, 255),
            new ColorModel(255, 0, 255, 255),
            new ColorModel(0, 255, 255, 255)
        };
    }
    #endregion
}