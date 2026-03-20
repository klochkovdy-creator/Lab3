using System.Windows.Media;
// === ЭТАП 1. Паттерн Фабричный метод ===
public abstract class CircleCreator
{
    public abstract Circle CreateCircle();
}

public class RedCircleCreator : CircleCreator
{
    public override Circle CreateCircle() => new Circle { Color = Colors.Red };
}

public class GreenCircleCreator : CircleCreator
{
    public override Circle CreateCircle() => new Circle { Color = Colors.Green };
}

public class BlueCircleCreator : CircleCreator
{
    public override Circle CreateCircle() => new Circle { Color = Colors.Blue };
}