using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AngeliA.Sprint2.Task0.V21.Lib
{
    public class Class1 : ISprint2Task0V21
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            // Operations: ==, !=, <, >, <=, >=
            bool[] result = new bool[]
            {
            x == y,
            y != y,
            x < y,
            y > x,
            x <= y,
            y >= x,
            };

            return result;
        }
    }
}
