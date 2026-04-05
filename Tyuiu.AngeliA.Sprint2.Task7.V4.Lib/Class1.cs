using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AngeliA.Sprint2.Task7.V4.Lib
{
    public class Class1 : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x <= 0 && (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && y >= 0)
            {
                return true;
            }
            else if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (Math.Pow(x, 2) + Math.Pow(y, 2) >= 0.09) && y >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
