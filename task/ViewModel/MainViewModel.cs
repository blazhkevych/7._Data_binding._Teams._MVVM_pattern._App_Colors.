using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using task.Commands;
using task.Model;

namespace task.ViewModel;

// ViewModel главного окна.
public class MainViewModel : ViewModelBase
{
    // 4 булевских свойсвтва для чекбоксов.
    private bool _isAlphaChecked;
    private bool _isRedChecked;
    private bool _isGreenChecked;
    private bool _isBlueChecked;

    // Конструктор.
    public MainViewModel(List<ColorModel> colors)
    {
        // Инициализируем коллекцию обьектов маленькой вспомагательной вьюмодели.
        // Оборачиваем каждую модель цвета(ColorModel) в маленькую вспомагательную вьюмодель(ColorViewModel).
        ColorsList = new ObservableCollection<ColorViewModel>(colors.Select(color => new ColorViewModel(color)));
    }

    // Хранит обьекты маленькой вспомагательной вьюмодели, которая оборачивает модель цвета(ColorModel).
    public ObservableCollection<ColorViewModel> ColorsList { get; set; }

    // Команды. 
    private DelegateCommand _addColorCommand;

    public ICommand AddColorCommand
    {
        get
        {
            if (_addColorCommand == null)
            {
                _addColorCommand = new DelegateCommand(AddColor, CanAddColor);
            }
            return _addColorCommand;
        }
    }

    private void AddColor(object o)
    {
       // Получаем текущие значения из слайдеров.
       byte alpha = (byte)Application.Current.MainWindow.FindResource("Alpha");


       

        // Создаем новую модель цвета.
        //ColorModel colorModel = new ColorModel();


    }

    private bool CanAddColor(object o)
    {
        // Если такого цвета в листбоксе нету, то можно добавлять.
        return true;
        // Если такой цвет есть в листбоксе, то нельзя добавлять.
        return false;

    }
}