/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then display "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze {
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap) {
        _mazeMap = mazeMap;
    }

    // Todo Maze Problem - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveLeft() {
        // FILL IN CODE
        var left = (_currX - 1, _currY);

        if (_mazeMap.ContainsKey(left)) {
            var directions = _mazeMap[left];
            if (directions[1]) {
                _currX--;
            } else {
                Console.WriteLine("Cannot go that way!");
            }
        } else {
            Console.WriteLine("Cannot go that way!");
        }
            

    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveRight() {
        // FILL IN CODE
        var right = (_currX + 1, _currY);

        if (_mazeMap.ContainsKey(right)) {
            var directions = _mazeMap[right];
            if (directions[0]) {
                _currX++;
            } else {
                Console.WriteLine("Cannot go that way!");
            }
        } else {
            Console.WriteLine("Cannot go that way!");
        }
            
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveUp() {
        // FILL IN CODE
        var up = (_currX, _currY - 1);

        if (_mazeMap.ContainsKey(up)) {
            var directions = _mazeMap[up];
            if (directions[3]) {
                _currY--;
            } else {
                Console.WriteLine("Cannot go that way!");
            }
        } else {
            Console.WriteLine("Cannot go that way!");
        }
            
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveDown() {
        // FILL IN CODE
        var down = (_currX, _currY + 1);

        if (_mazeMap.ContainsKey(down)) {
            var directions = _mazeMap[down];
            if (directions[2]) {
                _currY++;
            } else {
                Console.WriteLine("Cannot go that way!");
            }
        } else {
            Console.WriteLine("Cannot go that way!");
        }
            
    }

    public void ShowStatus() {
        Console.WriteLine($"Current location (x={_currX}, y={_currY})");
    }
}