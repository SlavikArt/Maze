namespace Maze
{
    public class Character
    {
        // позиция главного персонажа
        public ushort PosX { get; set; }
        public ushort PosY { get; set; }
        public LevelForm Parent { get; set; }

        public int Health { get; set; }
        public int Steps { get; set; }
        public int Score { get; set; }
        public int Energy { get; set; }
        public int CoffeCD { get; set; }
        public Character(LevelForm parent)
        {
            PosX = 0;
            PosY = 2;
            Parent = parent;
            Health = 100;
            Steps = 0;
            Score = 0;
            Energy = 500;
            CoffeCD = 0;
        }

        public void Clear()
        {
            Parent.Controls["pic" + PosY + "_" + PosX].BackgroundImage =
                Parent.maze.cells[PosY, PosX].Texture =
                Cell.Images[(int)(Parent.maze.cells[PosY, PosX].Type = CellType.HALL)];
        }
        public void Clear(CellType type)
        {
            Parent.Controls["pic" + PosY + "_" + PosX].BackgroundImage =
                Parent.maze.cells[PosY, PosX].Texture =
                Cell.Images[(int)(Parent.maze.cells[PosY, PosX].Type = type)];
        }

        public void MoveRight()
        {
            PosX++;
            Steps++;
            Energy--;
            CoffeCD--;
        }

        public void MoveLeft()
        {
            PosX--;
            Steps++;
            Energy--;
            CoffeCD--;
        }

        public void MoveUp()
        {
            PosY--;
            Steps++;
            Energy--;
            CoffeCD--;
        }

        public void MoveDown()
        {
            PosY++;
            Steps++;
            Energy--;
            CoffeCD--;
        }

        public void Show()
        {
            Parent.Controls["pic" + PosY + "_" + PosX].BackgroundImage =
                Parent.maze.cells[PosY, PosX].Texture =
                Cell.Images[(int)(Parent.maze.cells[PosY, PosX].Type = CellType.HERO)];
        }
    }
}