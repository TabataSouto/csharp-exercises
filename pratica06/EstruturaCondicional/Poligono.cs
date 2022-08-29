namespace EstruturaCondicional;

public class Poligono {
    public static string IdentifyPolygon(int numberSide)
    {

    string? polygonName;
    
    switch (numberSide)
    {
        case < 3:
            polygonName = "Não é um polígono";
            break;
        case 3:
            polygonName = "Triângulo";
            break;
        case 4:
            polygonName = "Quadrado";
            break;
        case 5:
            polygonName = "Pentágono";
            break;
        default:
            polygonName = "Polígono não identificado";
            break;
    }
    return polygonName;
  }
}