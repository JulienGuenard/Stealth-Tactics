using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

[ExecuteInEditMode]
public class GridEditor : GridHeritage
{
    public bool canEdit;
    public GameObject square;
    public int gridX;
    public int gridY;
    public float offsetX;
    public float offsetY;

    public List<Square> squareList;

    void Update()
    {
        if (!canEdit) return;
        if (gridX < 1) return;
        if (gridY < 1) return;

        foreach (Square obj in squareList) DestroyImmediate(obj);

        squareList.Clear();
        for (int x = 0; x < gridX; x++)
        {
            for (int y = 0; y < gridY; y++)
            {
                GameObject obj = Instantiate(square, transform.position + new Vector3(x * offsetX, y * offsetY,0), Quaternion.identity);
                obj.transform.SetParent(gameObject.transform);

                Square objSquare = obj.GetComponent<Square>();
                squareList.Add(objSquare);
                objSquare.coords = new Vector2(x, y);
                obj.name = x + ", " + y;
            }
        }
    }
}
