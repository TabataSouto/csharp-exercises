namespace StaticClassesAndMethods;

public class Car {
    // propriedades/atributos
    public double _topSpeedKph = 200;
    public double TopSpeed {
      get { return _topSpeedKph; }
      set { _topSpeedKph = value; }
    }
    public double TopSpeedMph {
      get { return Car.KphToMph(_topSpeedKph); }
    }

    // métodos
    public static double KphToMph(double kph) {
      return kph / 1.61;
    }
}