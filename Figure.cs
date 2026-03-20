using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
// === ЭТАП 1. Паттерн Фабричный метод ===
public abstract class Figure
{
    public Color Color { get; set; }
    public abstract UIElement CreateUIElement(double size = 50);
}