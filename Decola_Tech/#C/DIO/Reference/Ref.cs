namespace DIO.Reference
{
    public class Ref
    {
		// static void Inverter (int x, int y) > nesse caso (funciona) recebe valores, usar ref força a receber referência
		static void Inverter (ref int x, ref int y)
		{
			int temp = x;
			x = y;
			y = temp;
		}

		public static void Inverter()
		{
			int i = 1, j = 2;
			/* Inverter(i, j); usar desse jeito apenas passa os valores mas não altera as variáveis em 
				si, logo ao printar os valores eles não teriam sido invertidos, ao usar ref, passa a variável em si,
				então ela será mudada pelo método (ponteiros de C) */
			Inverter(ref i, ref j);
			System.Console.WriteLine($"{i}{j}");
		}
    }
}