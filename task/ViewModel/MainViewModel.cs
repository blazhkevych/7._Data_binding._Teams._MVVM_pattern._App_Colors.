using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using task.Commands;
using task.Model;

namespace task.ViewModel;

// ViewModel главного окна.
public class MainViewModel : ViewModelBase
{
    public ObservableCollection<ColorViewModel> ColorList { get; set; }
    public MainViewModel()
    {
        ColorList = new ObservableCollection<ColorViewModel>();
    }

    private int colorAlpha = 0;
    public int ColorAlpha
    {
        get { return colorAlpha; }
        set
        {
            colorAlpha = value;
            SetColor();
            OnPropertyChanged(nameof(colorAlpha));
        }
    }

    private int colorRed = 0;
    public int ColorRed
    {
        get { return colorRed; }
        set
        {
            colorRed = value;
            SetColor();
            OnPropertyChanged(nameof(colorRed));
        }
    }

    private int colorGreen = 0;
    public int ColorGreen
    {
        get { return colorGreen; }
        set
        {

            colorGreen = value;
            SetColor();
            OnPropertyChanged(nameof(colorGreen));
        }
    }

    private int colorBlue = 0;
    public int ColorBlue
    {
        get { return colorBlue; }
        set
        {
            colorBlue = value;
            SetColor();
            OnPropertyChanged(nameof(colorBlue));
        }
    }

    private string color = "#0";
    public string Color
    {
        get { return color; }
        set
        {
            color = value;
            OnPropertyChanged(nameof(color));
        }
    }

    private void SetColor()
    {
        string textAlpha = Convert.ToString(ColorAlpha, 16);
        if (textAlpha.Length == 1)
            textAlpha = "0" + textAlpha;
        if (!CheckAlpha)
            textAlpha = "00";
        string textRed = Convert.ToString(ColorRed, 16);
        if (textRed.Length == 1)
            textRed = "0" + textRed;
        if (!CheckRed)
            textRed = "00";
        string textGreen = Convert.ToString(ColorGreen, 16);
        if (textGreen.Length == 1)
            textGreen = "0" + textGreen;
        if (!CheckGreen)
            textGreen = "00";
        string textBlue = Convert.ToString(ColorBlue, 16);
        if (textBlue.Length == 1)
            textBlue = "0" + textBlue;
        if (!CheckBlue)
            textBlue = "00";
        Color = "#" + textAlpha + textRed + textGreen + textBlue;
    }

    private DelegateCommand addCommand;

    public ICommand AddCommand
    {
        get
        {
            if (addCommand == null)
            {
                addCommand = new DelegateCommand(param => this.AddItem(), param => this.CanAddItem());
            }
            return addCommand;
        }
    }

    private void AddItem()
    {
        Color tmpC = new Color(Color);
        ColorViewModel tmp = new ColorViewModel(tmpC);
        ColorList.Add(tmp);

    }

    private bool CanAddItem()
    {
        for (int i = 0; i < ColorList.Count; i++)
        {
            if (Color == ColorList[i].Name)
                return false;
        }
        return true;
    }

    private int index_selected_listbox = -1;

    public int Index_selected_listbox
    {
        get { return index_selected_listbox; }
        set
        {
            index_selected_listbox = value;
            OnPropertyChanged(nameof(index_selected_listbox));
        }
    }

    public int Count_ColorList
    {
        get { return ColorList.Count; }

    }

    private DelegateCommand deleteCommand;

    public ICommand DeleteCommand
    {
        get
        {
            if (deleteCommand == null)
            {
                deleteCommand = new DelegateCommand(param => this.DeleteItem(), null);
            }
            return deleteCommand;
        }
    }

    private void DeleteItem()
    {
        try
        {
            ColorList.RemoveAt(Index_selected_listbox);
        }
        catch (Exception ex)
        {
            StreamWriter sw = new StreamWriter("../../Exception.txt", false);

            string line = ex.ToString();
            sw.WriteLine(line);
            line = Index_selected_listbox.ToString();
            sw.WriteLine(line);
            line = "Количество элементов: " + ColorList.Count.ToString();
            sw.WriteLine(line);
            sw.Close();
        }
    }




    private bool checkAlpha = true;
    public bool CheckAlpha
    {
        get { return checkAlpha; }
        set
        {
            checkAlpha = value;
            SetColor();
            OnPropertyChanged(nameof(checkAlpha));
        }
    }

    private bool checkRed = true;
    public bool CheckRed
    {
        get { return checkRed; }
        set
        {
            checkRed = value;
            SetColor();
            OnPropertyChanged(nameof(checkRed));
        }
    }
    private bool checkGreen = true;
    public bool CheckGreen
    {
        get { return checkGreen; }
        set
        {
            checkGreen = value;
            SetColor();
            OnPropertyChanged(nameof(checkGreen));
        }
    }
    private bool checkBlue = true;
    public bool CheckBlue
    {
        get { return checkBlue; }
        set
        {
            checkBlue = value;
            SetColor();
            OnPropertyChanged(nameof(checkBlue));
        }
    }




}