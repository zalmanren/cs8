using System;
using System.Diagnostics;
namespace Packt.Shared;
public struct DisplaymentVector
{
    public int X;
    public int Y;
    public DisplaymentVector(int initialX, int initialY)
    {
        X=initialX;
        Y=initialY;
    }
    public static DisplaymentVector operator +(DisplaymentVector v1, DisplaymentVector v2)
    {
        return new DisplaymentVector(v1.X + v2.X, v1.Y + v2.Y);
    }
}