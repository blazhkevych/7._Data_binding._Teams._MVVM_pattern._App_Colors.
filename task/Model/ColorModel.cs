namespace task.Model;

// Модель цвета.
public class ColorModel
{
    // Конструктор.
    public ColorModel(byte alpha, byte red, byte green, byte blue)
    {
        Alpha = alpha;
        Red = red;
        Green = green;
        Blue = blue;
    }

    // Свойства.
    public byte Alpha { get; set; }

    public byte Red { get; set; }

    public byte Green { get; set; }

    public byte Blue { get; set; }

    // Итоговый цвет.
    public string ColorCode => GetColorCode();

    // Метод, который возвращает строку с кодом цвета.
    private string GetColorCode()
    {
        return $"#{Alpha:X2}{Red:X2}{Green:X2}{Blue:X2}";
    }
}