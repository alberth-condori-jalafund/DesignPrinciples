namespace kiss;
// El objetivo es calcular el area de un circulo
public class CircleWithKiss
{
    private double _radio;

    public CircleWithKiss(double radio)
    {
        _radio = radio;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(_radio, 2);
    }

}
