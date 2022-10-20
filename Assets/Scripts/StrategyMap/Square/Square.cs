using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public Vector2 coords;
    public TokenBuilding tokenBuilding;
    public GameObject commandant;
    
    private void OnMouseEnter()
    {
        SquareManager.instance.SetSquareHovered(this);
    }

    private void OnMouseExit()
    {
        SquareManager.instance.SetSquareHovered(null);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Grid_Commandant") commandant = other.gameObject;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == commandant) commandant = null;
    }
}
