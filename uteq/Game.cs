using System;
using System.Threading;
using uteq.Core;

namespace uteq
{
    public class Game
    {
        private IGameObjects tablero;
        private Ball ball;
        private Player playerA;
        private Player playerB;

        private static Game? _instance;

        public static Game Instance { get
            {
                if (_instance == null)
                {
                    _instance = new Game();
                }
                return _instance;
            }
            private set { }
        }

        private Game()
        {
            playerA = new Player();
            playerB = new Player();
            ball = new Ball();
            tablero = new Tablero(ball);
            ball.Source = "x";
            playerA.Source = ">";
            playerB.Source = "<";
            playerA.Positionx = 0;
            playerA.Positiony = ((Tablero)tablero).Height/2;
            playerB.Positionx = ((Tablero)tablero).Width;
            playerB.Positiony = ((Tablero)tablero).Height / 2;
        }

        public void OnPlay()
        {
            int velocidadx = 1;
            int velocidady = 1;
            while (true)
            {
                tablero.OnDraw();
                #region Render player a
                Console.SetCursorPosition(playerA.Positionx, playerA.Positiony);
                Console.Write(playerA.Source);
                #endregion

                #region Render player b
                Console.SetCursorPosition(playerB.Positionx, playerB.Positiony);
                Console.Write(playerB.Source);
                #endregion

                #region Render ball
                Console.SetCursorPosition(ball.PositionX, ball.PositionY);
                Console.Write(ball.Source);
                ball.PositionX += velocidadx;
                ball.PositionY += velocidady;
                if (ball.PositionX >= ((Tablero)tablero).Width)
                    velocidadx = -1;
                if (ball.PositionX <= 0)
                    velocidadx = 1;

                if (ball.PositionY >= ((Tablero)tablero).Height)
                    velocidady = -1;
                if (ball.PositionY <= 1)
                    velocidady = 1;

                Thread.Sleep(100);
                Console.Clear();
                #endregion

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.W:
                            if (playerA.Positiony > 1)
                                playerA.Positiony--;
                            break;
                        case ConsoleKey.S:
                            if (playerA.Positiony < ((Tablero)tablero).Height)
                                playerA.Positiony++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (playerB.Positiony > 1)
                                playerB.Positiony--;
                            break;
                        case ConsoleKey.DownArrow:
                            if (playerB.Positiony < ((Tablero)tablero).Height)
                                playerB.Positiony++;
                            break;
                    }

                }
            }
        }

        public void OnPause()
        {

        }
    }
}
