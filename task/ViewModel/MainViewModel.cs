using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Input;
using task.Commands;
using task.Model;

namespace task.ViewModel;

// ViewModel главного окна.
public class MainViewModel : ViewModelBase
{
    private DelegateCommand addCommand;


    private bool checkAlpha = true;
    private bool checkBlue = true;
    private bool checkGreen = true;

    private bool checkRed = true;

    private string color = "#0";

    private int colorAlpha;

    private int colorBlue;

    private int colorGreen;

    private int colorRed;

    private DelegateCommand deleteCommand;

    private int index_selected_listbox = -1;

    public MainViewModel()
    {
        ColorList = new ObservableCollection<ColorViewModel>();
    }

    public ObservableCollection<ColorViewModel> ColorList { get; set; }

    public int ColorAlpha
    {
        get => colorAlpha;
        set
        {
            colorAlpha = value;
            SetColor();
            OnPropertyChanged(nameof(colorAlpha));
        }
    }

    public int ColorRed
    {
        get => colorRed;
        set
        {
            colorRed = value;
            SetColor();
            OnPropertyChanged(nameof(colorRed));
        }
    }

    public int ColorGreen
    {
        get => colorGreen;
        set
        {
            colorGreen = value;
            SetColor();
            OnPropertyChanged(nameof(colorGreen));
        }
    }

    public int ColorBlue
    {
        get => colorBlue;
        set
        {
            colorBlue = value;
            SetColor();
            OnPropertyChanged(nameof(colorBlue));
        }
    }

    public string Color
    {
        get => color;
        set
        {
            color = value;
            OnPropertyChanged(nameof(color));
        }
    }

    public ICommand AddCommand
    {
        get
        {
            if (addCommand == null) addCommand = new DelegateCommand(param => AddItem(), param => CanAddItem());
            return addCommand;
        }
    }

    public int Index_selected_listbox
    {
        get => index_selected_listbox;
        set
        {
            index_selected_listbox = value;
            OnPropertyChanged(nameof(index_selected_listbox));
        }
    }

    public int Count_ColorList => ColorList.Count;

    public ICommand DeleteCommand
    {
        get
        {
            if (deleteCommand == null) deleteCommand = new DelegateCommand(param => DeleteItem(), null);
            return deleteCommand;
        }
    }

    public bool CheckAlpha
    {
        get => checkAlpha;
        set
        {
            checkAlpha = value;
            SetColor();
            OnPropertyChanged(nameof(checkAlpha));
        }
    }

    public bool CheckRed
    {
        get => checkRed;
        set
        {
            checkRed = value;
            SetColor();
            OnPropertyChanged(nameof(checkRed));
        }
    }

    public bool CheckGreen
    {
        get => checkGreen;
        set
        {
            checkGreen = value;
            SetColor();
            OnPropertyChanged(nameof(checkGreen));
        }
    }

    public bool CheckBlue
    {
        get => checkBlue;
        set
        {
            checkBlue = value;
            SetColor();
            OnPropertyChanged(nameof(checkBlue));
        }
    }

    private void SetColor()
    {
        var textAlpha = Convert.ToString(ColorAlpha, 16);
        if (textAlpha.Length == 1)
            textAlpha = "0" + textAlpha;
        if (!CheckAlpha)
            textAlpha = "00";
        var textRed = Convert.ToString(ColorRed, 16);
        if (textRed.Length == 1)
            textRed = "0" + textRed;
        if (!CheckRed)
            textRed = "00";
        var textGreen = Convert.ToString(ColorGreen, 16);
        if (textGreen.Length == 1)
            textGreen = "0" + textGreen;
        if (!CheckGreen)
            textGreen = "00";
        var textBlue = Convert.ToString(ColorBlue, 16);
        if (textBlue.Length == 1)
            textBlue = "0" + textBlue;
        if (!CheckBlue)
            textBlue = "00";
        Color = "#" + textAlpha + textRed + textGreen + textBlue;
    }

    private void AddItem()
    {
        var tmpC = new Color(Color);
        var tmp = new ColorViewModel(tmpC);
        ColorList.Add(tmp);
    }

    private bool CanAddItem()
    {
        for (var i = 0; i < ColorList.Count; i++)
            if (Color == ColorList[i].Name)
                return false;
        return true;
    }

    private void DeleteItem()
    {
        try
        {
            ColorList.RemoveAt(Index_selected_listbox);
        }
        catch (Exception ex)
        {
            var sw = new StreamWriter("../../Exception.txt", false);

            var line = ex.ToString();
            sw.WriteLine(line);
            line = Index_selected_listbox.ToString();
            sw.WriteLine(line);
            line = "Количество элементов: " + ColorList.Count;
            sw.WriteLine(line);
            sw.Close();
        }
    }
}