using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridHeritage : MonoBehaviour
{
    static public Grid instance;
    [HideInInspector] public GridEditor gridEditor;

    virtual public void Awake()
    {
        if (instance == null) instance = GetComponent<Grid>();

        gridEditor = GetComponent<GridEditor>();
    }
}
