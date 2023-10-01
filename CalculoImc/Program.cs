namespace SantaADS
{
    public static class IMC
    {
        public static int Main(string[] args)
        {
            string? Speso;
            string? SAltura;
            string? Snome;

            Console.Write("Digite seu nome: ");
            Snome = Console.ReadLine();

            Console.Write("Digite sua altura em M (entre 1,2m e 2,0m): ");
            SAltura = Console.ReadLine();

            float fAltura;

            if (!float.TryParse(SAltura, out fAltura))
            {
                Console.Write("Altura digitada invalida!");

            }
            if (fAltura < 1.2 || fAltura > 2.0)
            {
                Console.WriteLine("Altura fora da faixa!");
                return 1;
            }

            Console.Write("Digite seu peso em kg:(entre 40kg e 150 kg) : ");
            Speso = Console.ReadLine();

            float fPeso;

            if (!float.TryParse(Speso, out fPeso))
            {
                Console.WriteLine("Peso digitado invalido!");
                return 1;
            }
            if (fPeso < 40 || fPeso > 150)
            {
                Console.WriteLine("Peso fora da faixa");
                return 1;
            }

            float imc = fPeso / (fAltura * fAltura);
            Console.WriteLine(Snome.Trim() + ", o seu imc vale: " + imc.ToString("N1"));

            if (imc < 17)
            {
                Console.WriteLine("Diagnostico: Muito abaixo do peso");
                return 1;
            }

            if (imc > 17 && imc < 18.49)
            {
                Console.WriteLine("Diagnostico: Abaixo do peso");
                return 1;
            }
            if (imc > 18.5 && imc < 24.99)
            {
                Console.WriteLine("Diagnostico:	Peso normal");
                return 1;
            }
            if (imc > 25 && imc < 29.99)
            {
                Console.WriteLine("Diagnostico: Acima do peso");
                return 1;

            }
            if (imc > 30 && imc < 34.99)
            {
                Console.WriteLine("Diagnostico: Obesidade I");
                return 1;
            }
            if (imc > 35 && imc < 39.99)
            {
                Console.WriteLine("Diagnostico: Obesidade II (severa)");
                return 1;
            }
            if (imc > 40)
            {
                Console.WriteLine("Diagnostico:  Obesidade III (mórbida)");
                return 1;
            }





            return 0;
        }
    }
}