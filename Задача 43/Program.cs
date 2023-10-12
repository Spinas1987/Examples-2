// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int Coeficent = 0;
const int Constant = 1;
const int X = 0;
const int Y = 1;
const int Line1 = 1;
const int Line2 = 2;

double lineData1 = InputLineData(Line1);
double lineData2 = InputLineData(Line2);

if (ValidDataLines(lineData1, lineData2))
{
    double coord = FindCoords(lineData11, lineData2);
    Console.WriteLine($"Точа пересечения уровнений y = { lineData1[Coeficent] * X + (lineData1[Constant])} и y = { lineData2[Coeficent] * X + (lineData2[Constant])} ");
    Console.WriteLine("имеет кординаты ({coord[x]} ,{coord[x]}) ");
}


double Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}


double[] InputLineData(int numberOfLine)
{
    double[] lineDate = new double[2];
    lineData[Coeficent] = Prompt($"Введите коэффицент для {numberOfLine} приямой >");
    lineData[Constant] = Prompt($"Введите константу для {numberOfLine} приямой >");
    return lineData;
}

double FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coords = new double[2];
    coord(X) = (lineData1(Constant) - lineData2(Constant)) / (lineData2(oeficent) - lineData1(oeficent));
    coords(Y) = lineData1(Constant) * coord(X) + lineData1(Constant);
    return coords;
}
bool ValidDataLines(double[] lineData1, double[] lineData2)
{
    if (lineData1(Coeficent) == lineData2(Coeficent))
    {
        if (lineData1(Constant) == lineData2(Constant))
        {
            Console.WriteLine("Приямые совподают");
            return false;
        }
        else
        {
            Console.WriteLine("Приямые параллельны");
            return false;
        }
    }
    return true;
}

