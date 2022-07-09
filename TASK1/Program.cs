int Prompt(string message)
{
    Console.Write(message);
    string a_String = Console.ReadLine();
    return int.Parse(a_String);

}

void PrintNaturalNumbers(int numberM, int numberN)
{
    if (numberM > numberN) return;

    if (numberN % 2 == 1){

    numberN--;

}

PrintNaturalNumbers(numberM, numberN-2);
System.Console.Write($"{numberN}; ");

}

int numberM = Prompt("Введите число 1: ");
int numberN = Prompt("Введите число 2: ");

System.Console.WriteLine();

System.Console.Write($"M = {numberM}, N = {numberN} -> ");
PrintNaturalNumbers(numberM, numberN);
System.Console.WriteLine();

