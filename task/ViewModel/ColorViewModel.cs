using task.Model;

namespace task.ViewModel;

// ViewModel цвета.
public class ColorViewModel : ViewModelBase
{
    private readonly Color color;

    public ColorViewModel(Color color_)
    {
        color = color_;
    }

    public string Name
    {
        get => color.Name;
        set
        {
            color.Name = value;
            OnPropertyChanged(nameof(Name));
        }
    }
}