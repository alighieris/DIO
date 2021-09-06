namespace DIO.Heritage
{
    public class Ponto
    {
        public int x, y;

		private int distancia;  // Váriável está disponível apenas dentro da classe

		public Ponto(int x, int y)
		{
			this.x = x;
			this.y = y;

		}
		protected void CalcularDistancia() 		// Método só pode ser acessado pelas classes filhas
		{
			CalcularDistancia2();
		}
		private void CalcularDistancia2(){		// Método só pode ser acessado dentro da classe Ponto
			// Code
		}

		public virtual void CalcularDistancia3()	// Usar "virtual" permite que o método seja sobrescrito pelas classes filhas
		{
			// Code
		}
    }
}