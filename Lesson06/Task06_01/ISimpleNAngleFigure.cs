using System;
namespace Task06_01
{
    public interface ISimpleNAngleFigure
    {
        double Height { get; set; }
        double SidesLenght { get; }
        double Base { get; }
        double AngleBetweenSides { get; set; }
        int SidesCount { get; }


        double FigureArea { get; }
        double FigurePerimetr { get; }
        void Draw();
    }
}
