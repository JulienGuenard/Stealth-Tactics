using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManagerHeritage : MonoBehaviour
{
    static public ColorManager instance;

    [HideInInspector] public ColorManagerStrategyMap colorMStratMap;
    [HideInInspector] public ColorManagerTacticalMap colorMTactMap;

    virtual public void Awake()
    {
        if (instance == null) instance = GetComponent<ColorManager>();

        colorMStratMap = GetComponent<ColorManagerStrategyMap>();
        colorMTactMap = GetComponent<ColorManagerTacticalMap>();
    }
}
