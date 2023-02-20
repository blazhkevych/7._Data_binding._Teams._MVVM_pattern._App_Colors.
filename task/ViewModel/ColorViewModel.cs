using task.Commands;
using task.Model;

namespace task.ViewModel;

// ViewModel цвета.
public class ColorViewModel : ViewModelBase 
{
    private Color color;

    public ColorViewModel(Color color_)
    {
        this.color = color_;
    }

    public string Name
    {
        get { return color.Name; }
        set
        {
            color.Name = value;
            OnPropertyChanged(nameof(Name));
        }
    }
}