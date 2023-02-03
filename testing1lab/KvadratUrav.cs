namespace testing1lab
{
    public class KvadratUrav
    {
        public string[]? FindRoots(double? a, double? b, double? c)
        {
            string[] roots = new string[2];

            string[] message = new string[1];

            if (a is double && b is double && c is double)
            {
                if (a != 0)
                {
                    var discriminant = b * b - 4.0 * a * c;

                    if (discriminant == 0)
                    {
                        roots = new[] { Convert.ToString((-b / 2.0 * a)) };
                    }
                    else if (discriminant > 0)
                    {
                        roots = new[]
                        {
                            Convert.ToString(Math.Round((double)((-b + Math.Sqrt((double)discriminant))/(2.0*a)), 3)),
                            Convert.ToString(Math.Round((double)((-b - Math.Sqrt((double)discriminant))/(2.0*a)), 3))
                    };
                    }
                    else
                    {
                        message[0] = "Корни уравнения комплексные";
                        return message;
                    }
                }
                else
                {
                    message[0] = "Уравнение не является квадратным";
                    return message;
                }
            }
            else
            {
                message[0] = "Неверно введены данные";
                return message;
            }
            return roots;
        }
    }
}