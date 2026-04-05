using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AngeliA.Sprint2.Task2.V8.Lib
{
    public class Class1 : ISprint2Task2V8
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool a = true;
            if ((x >= 2) && (x <= 14) && (y >= 2) && (y <= 12))
            {
                if ((x >= 3) && (x <= 8) && (y >= 2) && (y <= 2))
                {
                    return a = false;
                }
                if ((x >= 12) && (x <= 14) && (y >= 2) && (y <= 2))
                {
                    return a = false;
                }
                if ((x >= 6) && (x <= 8) && (y >= 3) && (y <= 4))
                {
                    return a = false;
                }
                if ((x >= 13) && (x <= 14) && (y >= 3) && (y <= 5))
                {
                    return a = false;
                }
                if ((x == 12) && (y == 4))
                {
                    return a = false;
                }
                if ((x >= 10) && (x <= 12) && (y == 5))
                {
                    return a = false;
                }
                if ((x >= 3) && (x <= 5) && (y >= 8) && (y <= 10))
                {
                    return a = false;
                }
                if ((x >= 7) && (x <= 8) && (y >= 7) && (y <= 8))
                {
                    return a = false;
                }
                if ((x >= 3) && (x <= 6) && (y == 12))
                {
                    return a = false;
                }
                if ((x >= 10) && (x <= 11) && (y >= 8) && (y <= 9))
                {
                    return a = false;
                }
                if ((x == 14) && (y >= 8) && (y <= 9))
                {
                    return a = false;
                }
                if ((x >= 10) && (x <= 14) && (y >= 10) && (y <= 12))
                {
                    return a = false;
                }

                return a;
            }
            else
            {
                return false;
            }
        }
    }
}
