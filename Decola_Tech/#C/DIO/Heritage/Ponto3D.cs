namespace DIO.Heritage
{
    public class Ponto3D : Ponto  // Ponto3D herda a classe Ponto
    {
		public int z;

		public Ponto3D(int x, int y, int z): base(x, y)
		{
			this.z = z;
			CalcularDistancia();
		}
        
		public static void Calcular()		// Definir método como "static" faz com que ele pertença à classe e
		{									// não à instância, dessa forma é preciso chamar a classe para usá-lo
			// Code
		}

		public override void CalcularDistancia3()
		{
			// Code
			base.CalcularDistancia3();		// O método pode ser sobrescrito, e no final voltar a chamar o método original
											// utilizando a classe base
		}
    }
}