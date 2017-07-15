using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GunfightDemo
{
    using System;
    using System.Threading;
    public class GunfightGame
    {
        public class Point
        {
            public int row;
            public int col;
        }
        const int WindowWidth = 50;
        const int WindowHeight = 10;
        private const int ScreenLowerBorder = WindowHeight - 2;
        private const int EnemyStartOffSet = WindowWidth;
        private const int ScreenUpperBorder = 2;
        private static Random randGenerator = new Random(); //Изпечатва рандом числа/позиции.
        private static bool IsGameOver = false;
        private const int CollisionAOE = 1;

        /*Player info*/
        private static int playerRow = 0;
        private static int playerCol = 0;
        private static string playerFigure = "{0}";
        static ConsoleColor playerColor = ConsoleColor.Red;

        /* Enemy info */
        static List<Point> enemies = new List<Point>();
        private static string enemyFigure = "%";
        private static ConsoleColor enemyColor = ConsoleColor.Cyan;
        private static int EnemySpawnChance = 10;

        /*Bullet info */
        static List<Point> bullets = new List<Point>();
        static ConsoleColor bulletsColor = ConsoleColor.Red;
        private static string bulletsFigure = "-";

        public static void Main()
        {
            InitialiseSettings();

            while (!IsGameOver)
            {
                
                Clear();
                CheckCollision();
                Update();
                Draw();

                Thread.Sleep(100); //Забавя премигването на играча.
            }
        }

        #region Utility Methods

        public static void InitialiseSettings()
        {
            Console.WindowWidth = WindowWidth;
            Console.WindowHeight = WindowHeight;
            Console.BufferWidth = WindowWidth;
            Console.BufferHeight = WindowHeight;

            Console.CursorVisible = false;
        }

        public static bool DoObjectsCollide(int firstRow, int firstCol, int secondRow, int SecondCol)
        {
            int colOffSet = Math.Abs(firstCol - SecondCol);

            return firstRow == secondRow &&
                colOffSet <= CollisionAOE;
        }
        public static void PrintOnPosition(int row, int col, string text, ConsoleColor color)
        {
            Console.SetCursorPosition(col, row); //премества курсора на дадена позиция
            Console.ForegroundColor = color; //задава цвят
            Console.Write(text);
        }
        public static bool IsEnemyInBounds(int row, int col)
        {
            return row >= ScreenUpperBorder &&
                   row <= WindowHeight - 1 &&
                   col >= 0 &&
                   col <= WindowWidth - 1;
        }

        #endregion

        #region Player Methods
        public static void ClearPlayer() // Зачиства следите от човечето/фигурата.
        {
            PrintOnPosition(playerRow, playerCol, "   ", playerColor);
        }
        public static void DrawPlayer() //Рисуваме човечето
        {
            PrintOnPosition(playerRow, playerCol, playerFigure, playerColor);

        }

        public static void UpdatePlayer()
        {
            //Пазим координатите на човечето, като текуща позиция(колона,ред)
            ReadInput();
        }

        public static void ReadInput() //Проверяваме клавиши
        {

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();

                //Хак, който спира човечето да се мърда само!!! Запомни!!!
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                //End of hack.

                if (userInput.Key == ConsoleKey.LeftArrow && playerCol > 0)
                {
                    playerCol--;
                }
                else if (userInput.Key == ConsoleKey.RightArrow && playerCol < WindowWidth - 3)
                {
                    playerCol++;
                }
                else if (userInput.Key == ConsoleKey.DownArrow && playerRow < ScreenLowerBorder)
                {
                    playerRow++;
                }
                else if (userInput.Key == ConsoleKey.UpArrow && playerRow > ScreenUpperBorder)
                {
                    playerRow--;
                }
                else if (userInput.Key == ConsoleKey.Spacebar)
                {
                    bullets.Add(new Point
                    {
                        row = playerRow,
                        col = playerCol + 2
                    });
                }
            }
        }
        #endregion

        #region Enemy Methods
        public static void SpawnEnemies()
        {
            int chance = randGenerator.Next(100);

            if (chance < EnemySpawnChance)
            {
                int row = randGenerator.Next(ScreenUpperBorder, ScreenLowerBorder);
                int col = randGenerator.Next(0, WindowWidth) + EnemyStartOffSet + 20;

                enemies.Add(new Point
                {
                    row = row, //Реда на новият враг е реда който съм генерирал.
                    col = col //Колоната на новият враг е колоната която съм генерирал.
                });

            }
        }
        public static void ClearEnemies()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                if (IsEnemyInBounds(enemies[i].row, enemies[i].col))
                {
                    PrintOnPosition(enemies[i].row, enemies[i].col, " ", enemyColor);
                }

            }
        }
        public static void DrawEnemies()
        {
            for (int cnt = 0; cnt < enemies.Count; cnt++)
            {
                if (IsEnemyInBounds(enemies[cnt].row, enemies[cnt].col))
                {
                    PrintOnPosition(enemies[cnt].row, enemies[cnt].col, enemyFigure, enemyColor);
                }

            }
        }


        public static void UpdateEnemies()
        {
            SpawnEnemies();

            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].col--;
                if (enemies[i].col < 0)
                {
                    enemies.RemoveAt(i);
                    i--;
                }
            }
            
        }
        #endregion

        #region Bullet Methods
        public static void ClearBullets()
        {
            for (int cnt = 0; cnt < bullets.Count; cnt++)
            {
                if (IsEnemyInBounds(bullets[cnt].row, bullets[cnt].col))
                {
                    PrintOnPosition(bullets[cnt].row, bullets[cnt].col, " ", bulletsColor);
                }

            }
        }

        public static void DrawBullets()
        {
            for (int cnt = 0; cnt < bullets.Count; cnt++)
            {
                if (IsEnemyInBounds(bullets[cnt].row, bullets[cnt].col))
                {
                    PrintOnPosition(bullets[cnt].row, bullets[cnt].col, bulletsFigure, bulletsColor);
                }
                
            }
        }

        public static void UpdateBullets()
        {
            for (int cnt = 0; cnt < bullets.Count; cnt++)
            {
                bullets[cnt].col++;
                if (bullets[cnt].col > WindowWidth - 1)
                {
                    bullets.RemoveAt(cnt);
                    cnt--;
                }
            }
        }
        #endregion

        #region Collision Methods
        public static void CheckEnemyBuletsCollision()
        {
            for (int bulletIndex = 0; bulletIndex < bullets.Count; bulletIndex++)
            {
                for (int enemyIndex = 0; enemyIndex < enemies.Count; enemyIndex++)
                {

                    if (DoObjectsCollide(
                        bullets[bulletIndex].row,
                        bullets[bulletIndex].col,
                        enemies[enemyIndex].row,
                        enemies[enemyIndex].col))
                    {
                        bullets.RemoveAt(bulletIndex);
                        enemies.RemoveAt(enemyIndex);
                        enemyIndex--;
                        bulletIndex--;
                        break;
                    }
                }
            }
        }

        public static void CheckEnemyPlayerCollision()
        {
            for (int enemyIndex = 0; enemyIndex < enemies.Count; enemyIndex++)
            {

                if (DoObjectsCollide(
                    enemies[enemyIndex].row,
                    enemies[enemyIndex].col,
                    playerRow,
                    playerCol + 2))
                {
                    IsGameOver = true;
                    
                }
            }
        }
        public static void CheckCollision()
        {
            CheckEnemyBuletsCollision();
            CheckEnemyPlayerCollision();
        }

        #endregion

        #region General Methods
        public static void Clear() //Главен метод за зачистване в играта.
        {
            ClearPlayer();
            ClearEnemies();
            ClearBullets();
        }
        public static void Update() //Мейн метод
        {
            UpdatePlayer();
            UpdateEnemies();
            UpdateBullets();
        }
        public static void Draw() //Мейн метод
        {
            DrawPlayer();
            DrawEnemies();
            DrawBullets();

        }
        #endregion
    }
}

