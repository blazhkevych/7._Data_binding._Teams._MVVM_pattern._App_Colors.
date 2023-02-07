using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task.Model;

namespace task.ViewModel
{
    // ViewModel главного окна.
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ColorViewModel> ColorsList { get; set; }

        // Конструктор.
        public MainViewModel(List<ColorModel> colors)
        {
            ColorsList = new ObservableCollection<ColorViewModel>(colors.Select(color => new ColorViewModel(color)));
        }

    }
}
