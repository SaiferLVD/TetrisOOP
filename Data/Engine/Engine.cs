using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris.Data.Engine
{
    public class GameEngine
    {

    }


    /// <summary>Все возможные варианты типа клетки на игровой доске.</summary> 
    public enum CellType
    {
        Empty,     // Пустая
        Red,       // S
        Green,     // Z
        Blue,      // Г
        Yellow,    // □
        Orange,    // L
        Purple,    // T
        LightBlue, // I
        Wall,      // Стена
    }
}
