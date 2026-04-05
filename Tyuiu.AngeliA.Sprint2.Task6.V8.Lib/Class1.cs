using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AngeliA.Sprint2.Task6.V8.Lib
{
    public class Class1 : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            int k = m - 1;
            if (m == 1)
            {
                switch (m)
                {
                    case 1: return "";
                    case 2: return "31." + "0" + (n - 1).ToString();
                    case 3: return "28." + "0" + (n - 1).ToString();
                    case 4: return "31." + "0" + (n - 1).ToString();
                    case 5: return "30." + "0" + (n - 1).ToString();
                    case 6: return "31." + "0" + (n - 1).ToString();
                    case 7: return "30." + "0" + (n - 1).ToString();
                    case 8: return "31." + "0" + (n - 1).ToString();
                    case 9: return "31." + "0" + (n - 1).ToString();
                    case 10: return "30." + "0" + (n - 1).ToString();
                    case 11: return "31." + (n - 1).ToString();
                    case 12: return "30." + (n - 1).ToString();
                    default:
                        throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
                }
            }
            else if (m < 32 && m != 1)
            {
                if (n < 10)
                {
                    if (m < 10)
                    {
                        return "0" + k + ".0" + n;
                    }
                    else
                    {
                        return k + ".0" + n;
                    }
                }
                else
                {
                    if (m < 10)
                    {
                        return "0" + k + "." + n;
                    }
                    else
                    {
                        return k + "." + n;
                    }
                }
            }
            else
            {
                throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {n}");
            }

        }
    }
}
