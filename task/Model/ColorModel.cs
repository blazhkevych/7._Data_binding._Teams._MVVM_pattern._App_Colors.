namespace task.Model;

public class ColorModel
{
    public ColorModel(byte alpha, byte red, byte green, byte blue)
    {
        Alpha = alpha;
        Red = red;
        Green = green;
        Blue = blue;
    }

    public byte Alpha { get; set; }

    public byte Red { get; set; }

    public byte Green { get; set; }

    public byte Blue { get; set; }

    public override string ToString()
    {
        return $"{ToHex()}";
        //return $"ARGB: ({Alpha}, {Red}, {Green}, {Blue})";
    }

    // Метод конвертирует цвет из формата ARGB в формат "FF48BD00" и возвращает строку.
    private string ToHex()
    {
        var hex = Alpha.ToString("X2") + Red.ToString("X2") + Green.ToString("X2") + Blue.ToString("X2");
        return hex;
    }
}