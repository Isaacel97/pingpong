using System;
using uteq.Core;

namespace uteq
{
	public class Tablero : IGameObjects
	{
		public int Width { get; set; } = 25;
		public int Height { get; set; } = 10;
		public Ball Ball { get; set; }

		public Tablero(Ball ball)
		{
			Ball = ball;
		}

		public void OnDraw()
		{
			for (int i = 0; i < Width; i++)
			{
				Console.SetCursorPosition(i, 0);
				Console.WriteLine("_");
				Console.SetCursorPosition(i, Height);
                Console.WriteLine("_");
            }

            for (int i = 1; i < Height+1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("|");
                Console.SetCursorPosition(Width, i);
                Console.WriteLine("|");
            }
        }
	}
}

