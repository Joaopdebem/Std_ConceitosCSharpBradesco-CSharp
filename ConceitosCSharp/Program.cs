class StructClasse {
    public struct PontoS{
        public int X;
        public int Y;
    }
    public class PontoC {
        public int X;
        public int Y;
    }
        public static void Main(){
            PontoS ponto = new PontoS{ X = 5, Y = 3};
            PontoS ponto2 = ponto;
            ponto.X = 3;

            System.Console.WriteLine($"Ponto  : {ponto.X}.");
            System.Console.WriteLine($"Ponto 2: {ponto2.X}.");

            PontoC ponto3 = new PontoC	{ X = 6, Y = 9};
            PontoC ponto4 = ponto3;
            ponto3.X = 3;

            System.Console.WriteLine($"Ponto 3: {ponto3.X}.");
            System.Console.WriteLine($"Ponto 4: {ponto4.X}.");

            ponto3.X = 11;
        }
}