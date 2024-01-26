using System;
using uteq.Core;

namespace uteq
{
	public class Player
	{
		public int Positionx { get; set; }
		public int Positiony { get; set; } = 0;
		public object? Source { get; set; }
		public ICommand MoveUp { get; set; }
		public ICommand MoveDown { get; set; }

		public Player()
		{
			MoveDown = new GameCommand(Down, CanMove);
			MoveUp = new GameCommand(Up, CanMove);
		}

		private bool CanMove(object down)
		{
			return true;
		}

		private void Up(object move)
		{
			Console.Write("");
		}

		public void Down(object move)
		{
			Console.Write("");
		}

		public void OnDraw()
		{
			#region Se pinta Player A
			Console.SetCursorPosition(Positionx, Positiony);
			Console.Write(Source);
            #endregion
        }


    }
}

