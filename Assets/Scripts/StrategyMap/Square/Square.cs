using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    private void OnMouseEnter()
    {
        SquareManager.instance.SetSquareHovered(this.gameObject);
    }

    private void OnMouseExit()
    {
        SquareManager.instance.SetSquareHovered(null);
    }
}
