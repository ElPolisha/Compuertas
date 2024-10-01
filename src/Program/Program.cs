namespace Program;

class Program
{
    static void Main(string[] args)
    {
        CompuertaAND compuerta1 = new CompuertaAND("AND1");
        compuerta1.AgregarEntrada("A", 1);
        compuerta1.AgregarEntrada("B", 1);

        CompuertaOR compuerta2 = new CompuertaOR("OR1");
        compuerta2.AgregarEntrada("C", 0);
        compuerta2.AgregarEntrada("D", compuerta1);

        CompuertaNOT compuerta3 = new CompuertaNOT("NOT1");
        compuerta3.AgregarEntrada("E", compuerta2);

        Console.WriteLine($"Resultado de AND1: {compuerta1.Calcular()}");
        Console.WriteLine($"Resultado de OR1: {compuerta2.Calcular()}");
        Console.WriteLine($"Resultado de NOT1: {compuerta3.Calcular()}");
    }
}