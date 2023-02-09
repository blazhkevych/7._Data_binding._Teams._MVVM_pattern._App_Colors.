using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using task.Model;

namespace task.ViewModel;

// ViewModel главного окна.
public class MainViewModel : ViewModelBase
{
    // Конструктор.
    public MainViewModel(List<ColorModel> colors)
    {
        // Инициализируем коллекцию обьектов маленькой вспомагательной вьюмодели.
        // Оборачиваем каждую модель цвета(ColorModel) в маленькую вспомагательную вьюмодель(ColorViewModel).
        ColorsList = new ObservableCollection<ColorViewModel>(colors.Select(color => new ColorViewModel(color)));
    }

    // Хранит обьекты маленькой вспомагательной вьюмодели, которая оборачивает модель цвета(ColorModel).
    public ObservableCollection<ColorViewModel> ColorsList { get; set; }
}