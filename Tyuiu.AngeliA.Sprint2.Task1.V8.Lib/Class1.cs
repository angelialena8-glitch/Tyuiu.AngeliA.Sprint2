using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AngeliA.Sprint2.Task1.V8.Lib
{
    public class Class1 : ISprint2Task1V8
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = [(a != b) | (c < d), (a == b) & (a != b), (a <= b) || (a != b), (a >= b) && (c <= d), !(b > a), (a <= b) ^ (c < d)];
            return res;
        }
    }
}
