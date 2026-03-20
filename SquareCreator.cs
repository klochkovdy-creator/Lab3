using System.Windows.Media;
// === ЭТАП 1. Паттерн Фабричный метод ===
public abstract class SquareCreator
{
    public abstract Square CreateSquare();
}

public class RedSquareCreator : SquareCreator
{
    public override Square CreateSquare() => new Square { Color = Colors.Red };
}

public class GreenSquareCreator : SquareCreator
{
    public override Square CreateSquare() => new Square { Color = Colors.Green };
}

public class BlueSquareCreator : SquareCreator
{
    public override Square CreateSquare() => new Square { Color = Colors.Blue };
}