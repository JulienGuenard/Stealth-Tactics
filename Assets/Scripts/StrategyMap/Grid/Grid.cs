using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : GridHeritage
{
    public List<GameObject> GetSquareList()
    {
        return gridEditor.squareList;
    }
}
