using System.Windows;

namespace task;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        // Позиция окна при старте программы по центру.
        WindowStartupLocation = WindowStartupLocation.CenterScreen;
    }
}