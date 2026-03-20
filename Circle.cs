using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
// === ЭТАП 1. Паттерн Фабричный метод ===
public class Circle : Figure
{
    public override UIElement CreateUIElement(double size = 50)
    {
        return new Ellipse
        {
            Width = size,
            Height = size,
            Fill = new SolidColorBrush(Color),
            Margin = new Thickness(5)
        };
    }
}