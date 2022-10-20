using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareManager : MonoBehaviour
{
    public Color neutralColor;
    public Color hoveredColor;
    public Color selectedColor;

    private GameObject squareLastHovered;
    private GameObject squareHovered;
    private GameObject squareSelected;
    private GameObject squareLastSelected;

    static public SquareManager instance;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    private void Update()
    {
        ColorUpdate();
        if (squareHovered == null) return;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            squareSelected = squareHovered;
        }
    }

    public void SetSquareHovered(GameObject square)
    {
        squareHovered = square;
    }

    public void SetSquareSelected(GameObject square)
    {
        if (squareSelected != null) squareLastSelected = squareSelected;
        squareSelected = square;
    }

    void ColorUpdate()
    {
        foreach(GameObject obj in Grid.instance.GetSquareList())
        {
            obj.GetComponent<SpriteRenderer>().color = neutralColor;
        }

        if (squareHovered != null) squareHovered.GetComponent<SpriteRenderer>().color = hoveredColor;
        if (squareSelected != null) squareSelected.GetComponent<SpriteRenderer>().color = selectedColor;
    }
}
