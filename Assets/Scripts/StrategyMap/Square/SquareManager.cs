using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareManager : MonoBehaviour
{
    private Square squareLastHovered;
    private Square squareHovered;
    private Square squareSelected;
    private Square squareLastSelected;
    private List<Square> squareActionList = new List<Square>();

    private GameObject commandantSelected;

    static public SquareManager instance;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    private void Update()
    {
        ClickSquare();
        ColorUpdate();
        SelectCommandant();
    }

    void ClickSquare()
    {
        if (squareHovered == null) return;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            squareSelected = squareHovered;
            squareActionList.Clear();
        }
    }

    void SelectCommandant()
    {
        if (squareSelected == null) return;

        if (squareSelected.commandant == null)
        {
            commandantSelected = null;
            return;
        }

        if (commandantSelected == squareSelected.commandant) return;

        commandantSelected = squareSelected.commandant;
        squareActionList = SquareGetAdjacent(squareSelected);
    }

    List<Square> SquareGetAdjacent(Square squareSelected)
    {
        List<Square> newList = new List<Square>();
        newList.Add(GetSquare(squareSelected, 1, 0));
        newList.Add(GetSquare(squareSelected, -1, 0));
        newList.Add(GetSquare(squareSelected, 0, 1));
        newList.Add(GetSquare(squareSelected, 0, -1));
        return newList;
    }

    Square GetSquare(Square fromSquare, int x, int y)
    {
        foreach (Square obj in Grid.instance.GetSquareList())
        {
            if (obj.coords.x == squareSelected.coords.x + x)
            {
                if (obj.coords.y == squareSelected.coords.y + y)
                {
                    return obj;
                }
            }
        }

        return null;
    }

    public void SetSquareHovered(Square square)
    {
        squareHovered = square;
    }

    public void SetSquareSelected(Square square)
    {
        if (squareSelected != null) squareLastSelected = squareSelected;
        squareSelected = square;
    }

    void ColorUpdate()
    {
        foreach(Square obj in Grid.instance.GetSquareList())
        {
            ColorManager.instance.NeutralColor(obj);
        }

        ColorManager.instance.HoveredColor(squareHovered);

        if (squareSelected != null) ColorManager.instance.SelectedColor(squareSelected);
        if (commandantSelected != null) ColorManager.instance.SelectedCommandantColor(squareSelected);

        if (squareActionList.Count != 0)
        {
            foreach (Square obj in squareActionList)
            {
                try { ColorManager.instance.ActionColor(obj); } catch {}
            }
        }
    }
}
