using System;
namespace uteq
{
	public class Ball
	{
		public int PositionX { get; set; }
		public int PositionY { get; set; } = 0;
		public string Source { get; set; }

		public Ball()
		{
		}

		public void OnDraw()
		{
			#region Se pinta pelota
			Console.SetCursorPosition(PositionX, PositionY);
			Console.WriteLine(Source);
            #endregion
        }
    }
}

