using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : GridHeritage
{
    public List<Square> GetSquareList()
    {
        return gridEditor.squareList;
    }
}
