// Собрать строку с числами от a до b, a ≤ b
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return string.Empty;
}

System.Console.WriteLine(NumbersFor(1, 10));
System.Console.WriteLine(NumbersRec(1, 10));