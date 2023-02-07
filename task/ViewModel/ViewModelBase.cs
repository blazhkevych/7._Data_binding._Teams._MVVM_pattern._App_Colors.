using System.ComponentModel;

namespace task.ViewModel;

// Базовый класс для всех ViewModel.
public abstract class ViewModelBase : INotifyPropertyChanged
{
    // Событие, которое вызывается при изменении свойства.
    public event PropertyChangedEventHandler PropertyChanged;

    // Метод, который вызывает событие PropertyChanged.
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}