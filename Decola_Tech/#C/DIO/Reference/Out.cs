namespace DIO.Reference
{
    public class Out
    {
        static void Dividir(int x, int y, out int resultado, out int resto)
		// colocar out na definição do método, já explicita qual variável vai ser retornada
		{
			resultado = x / y;
			resto = x % y;
		}

		public static void Dividir()
		{
			Dividir(10, 3, out int result, out int rest);
			// colocar out na chamada do método define para qual varíavel os valores serão retornados
			// resultado -> result  e  resto -> rest
			System.Console.WriteLine("{0} {1}", result, rest);
		}
    }
}