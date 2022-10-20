using System.Collections;
using System.Collections.Generic;
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

    public List<GameObject> squareList;

    void Update()
    {
        if (!canEdit) return;
        if (gridX < 1) return;
        if (gridY < 1) return;

        foreach (GameObject obj in squareList) DestroyImmediate(obj);

        squareList.Clear();
        for (int x = 0; x < gridX; x++)
        {
            for (int y = 0; y < gridY; y++)
            {
                GameObject obj = Instantiate(square, transform.position + new Vector3(x * offsetX, y * offsetY,0), Quaternion.identity);
                squareList.Add(obj);
                obj.transform.SetParent(gameObject.transform);
            }
        }
    }
}
