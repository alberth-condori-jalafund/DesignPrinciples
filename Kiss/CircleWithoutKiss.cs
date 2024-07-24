namespace kiss;
// El objetivo es calcular el area de un circulo
public class CircleWithoutKiss
{
    private double _radio;

    public CircleWithoutKiss(double radio)
    {
        _radio = radio;
    }

    public double CalculateDiameter()
    {
        return 2 * _radio;
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * _radio;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(_radio, 2);
    }
}
